using System.Windows.Forms;

namespace YMapReplace
{
    partial class YMapReplacerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericZ = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.replaceButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pathYmapTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericRotZ = new System.Windows.Forms.NumericUpDown();
            this.numericRotY = new System.Windows.Forms.NumericUpDown();
            this.numericRotX = new System.Windows.Forms.NumericUpDown();
            this.deleteCheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.replaceModelTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRotX)).BeginInit();
            this.SuspendLayout();
            // 
            // numericZ
            // 
            this.numericZ.Location = new System.Drawing.Point(270, 139);
            this.numericZ.Name = "numericZ";
            this.numericZ.Size = new System.Drawing.Size(108, 20);
            this.numericZ.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "YMAP Replacer";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 565);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(582, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(12, 527);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(582, 34);
            this.replaceButton.TabIndex = 3;
            this.replaceButton.Text = "Start replacement";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(486, 257);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(108, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pathYmapTextBox
            // 
            this.pathYmapTextBox.Location = new System.Drawing.Point(15, 90);
            this.pathYmapTextBox.Name = "pathYmapTextBox";
            this.pathYmapTextBox.Size = new System.Drawing.Size(579, 20);
            this.pathYmapTextBox.TabIndex = 5;
            this.pathYmapTextBox.Click += new System.EventHandler(this.pathYmapTextBox_OnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path to ymap";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(15, 139);
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(111, 20);
            this.numericX.TabIndex = 7;
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(143, 139);
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(111, 20);
            this.numericY.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Position XYZ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rotation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericRotZ
            // 
            this.numericRotZ.Location = new System.Drawing.Point(270, 184);
            this.numericRotZ.Name = "numericRotZ";
            this.numericRotZ.Size = new System.Drawing.Size(108, 20);
            this.numericRotZ.TabIndex = 13;
            // 
            // numericRotY
            // 
            this.numericRotY.Location = new System.Drawing.Point(143, 184);
            this.numericRotY.Name = "numericRotY";
            this.numericRotY.Size = new System.Drawing.Size(111, 20);
            this.numericRotY.TabIndex = 12;
            // 
            // numericRotX
            // 
            this.numericRotX.Location = new System.Drawing.Point(15, 184);
            this.numericRotX.Name = "numericRotX";
            this.numericRotX.Size = new System.Drawing.Size(111, 20);
            this.numericRotX.TabIndex = 11;
            // 
            // deleteCheckbox
            // 
            this.deleteCheckbox.AutoSize = true;
            this.deleteCheckbox.Location = new System.Drawing.Point(270, 234);
            this.deleteCheckbox.Name = "deleteCheckbox";
            this.deleteCheckbox.Size = new System.Drawing.Size(73, 17);
            this.deleteCheckbox.TabIndex = 15;
            this.deleteCheckbox.Text = "Delete";
            this.deleteCheckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Model";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(15, 232);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(111, 20);
            this.modelTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Replace model";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // replaceModelTextBox
            // 
            this.replaceModelTextBox.Location = new System.Drawing.Point(143, 232);
            this.replaceModelTextBox.Name = "replaceModelTextBox";
            this.replaceModelTextBox.Size = new System.Drawing.Size(111, 20);
            this.replaceModelTextBox.TabIndex = 18;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 257);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 23);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(143, 257);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(111, 23);
            this.delButton.TabIndex = 21;
            this.delButton.Text = "Supprimer";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(15, 286);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(579, 121);
            this.listBoxFiles.TabIndex = 22;
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(15, 413);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(579, 108);
            this.listBoxLogs.TabIndex = 23;
            // 
            // YMapReplacerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 600);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.replaceModelTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.deleteCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericRotZ);
            this.Controls.Add(this.numericRotY);
            this.Controls.Add(this.numericRotX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericZ);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.numericX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathYmapTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "YMapReplacerForm";
            this.Text = "YMAP Replacer";
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRotX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox pathYmapTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericRotZ;
        private System.Windows.Forms.NumericUpDown numericRotY;
        private System.Windows.Forms.NumericUpDown numericRotX;
        private System.Windows.Forms.CheckBox deleteCheckbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox replaceModelTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.NumericUpDown numericZ;
        private ListBox listBoxFiles;
        private ListBox listBoxLogs;
    }
}

