using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeWalker.GameFiles;
using CodeWalker.World;
using SharpDX;

namespace YMapReplace
{    
    public partial class YMapReplacerForm : Form
    {
        private List<MetaHash> deleteList = new List<MetaHash>();
        private List<ReplaceEntity> replaceList = new List<ReplaceEntity>();
        private List<String> fileList = new List<string>();

        public YMapReplacerForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            float posX = (float)numericX.Value;
            float posY = (float)numericY.Value;
            float posZ = (float)numericZ.Value;

            float rotX = (float)numericRotX.Value;
            float rotY = (float)numericRotY.Value;
            float rotZ = (float)numericRotZ.Value;

            string model = modelTextBox.Text;
            if (string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Please provide a model name.");
                return;
            }

            bool deleteEntity = deleteCheckbox.Checked;
            string replaceModel = replaceModelTextBox.Text;
            if (!deleteEntity && string.IsNullOrEmpty(replaceModel))
            {
                MessageBox.Show("You forgot to put a replacement model.");
                return;
            }

            if (deleteEntity)
            {
                listBoxFiles.Items.Add(model + " will be deleted.");
                MetaHash hashConv = GetMetaHash2(model);
                deleteList.Add(hashConv);
            }
            else
            {
                listBoxFiles.Items.Add(model + " will be replaced by " + replaceModel + ". XYZ: " + posX + " " + posY + " " + posZ + " | Rotation: " + rotX + " " + rotY + " " + rotZ);
                replaceList.Add(new ReplaceEntity(model, replaceModel, posX, posY, posZ, rotX, rotY, rotZ));
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.Items.Count == 0) return;
            object lastEntry = listBoxFiles.Items[listBoxFiles.Items.Count - 1];

            if (lastEntry.ToString().Contains("deleted"))
            {
                deleteList.RemoveAt(deleteList.Count - 1);
            }
            else
            {
                replaceList.RemoveAt(replaceList.Count - 1);
            }

            listBoxFiles.Items.RemoveAt(listBoxFiles.Items.Count - 1);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            replaceList.Clear();
            deleteList.Clear();
            listBoxFiles.Items.Clear();
            listBoxLogs.Items.Clear();
        }

        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        fileList.Add(f);
                    }
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        // from CodeWalker
        private MetaHash GetMetaHash2(string name)
        {
            uint hash = 0;
            if (!uint.TryParse(name, out hash))//don't re-hash hashes
            {
                hash = JenkHash.GenHash(name);
                JenkIndex.Ensure(name);
            }

            return hash;
        }
 
        private void replaceButton_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.Items.Count == 0) return;

            string pathToYmap = pathYmapTextBox.Text;
            if (string.IsNullOrEmpty(pathToYmap))
            {
                MessageBox.Show("The path is not valid.");
                return;
            }

            fileList = new List<string>();
            DirSearch(pathToYmap);

            int fileCount = fileList.Count;
            if (fileCount <= 0)
            {
                MessageBox.Show("This path is empty.");
                return;
            }

            progressBar1.Maximum = fileCount - 1;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                foreach (string filePath in fileList)
                {
                    bool modificationsMade = false;

                    YmapFile ymap = new YmapFile();
                    byte[] ymapBytes = File.ReadAllBytes(filePath);
                    ymap.Load(ymapBytes);
                    ymap.Name = Path.GetFileNameWithoutExtension(filePath);

                    YmapEntityDef[] entities = ymap.AllEntities;
                    if (entities == null) { continue; }

                    foreach (YmapEntityDef entity in entities)
                    {
                        MetaHash modelName = entity._CEntityDef.archetypeName;
                        foreach (ReplaceEntity entityData in replaceList)
                        {
                            MetaHash hash = GetMetaHash2(entityData.model);
                            if (hash == modelName)
                            {
                                MetaHash newHash = GetMetaHash2(entityData.newModel);
                                entity._CEntityDef.archetypeName = new MetaHash(newHash);
                                entity.SetPosition(entity.Position + new Vector3(0.0f + entityData.posX, 0.0f + entityData.posY, 0.0f + entityData.posZ));

                                // Quaternion are not supported yet (still need to port my js script and support Euler to make it easy)

                                listBoxLogs.Items.Add("Moved " + modelName + " from: " + ymap.Name + ".");
                                if (!modificationsMade) modificationsMade = true;
                                break;
                            }
                        }

                        if (deleteList.Contains(modelName))
                        {
                            ymap.RemoveEntity(entity);
                            Console.WriteLine("Deleted " + modelName);
                            listBoxLogs.Items.Add("Deleted " + modelName + " from: " + ymap.Name + ".");
                            if (!modificationsMade) modificationsMade = true;
                        }
                    }

                    if (modificationsMade)
                    {
                        byte[] newBytes = ymap.Save();
                        File.WriteAllBytes(filePath, newBytes);
                    }
                    progressBar1.PerformStep();
                }
                
                MessageBox.Show("Success!");
            }).Start();
        }

        private void pathYmapTextBox_OnClick(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                pathYmapTextBox.Text = fbd.SelectedPath;
            }
        }
    }
}
