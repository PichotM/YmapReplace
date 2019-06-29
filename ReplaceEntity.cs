using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMapReplace
{
    public class ReplaceEntity
    {
        public string model { get; set; }
        public string newModel { get; set; }

        public float posX { get; set; }
        public float posY { get; set; }
        public float posZ { get; set; }

        public float rotX { get; set; }
        public float rotY { get; set; }
        public float rotZ { get; set; }

        public ReplaceEntity(string modelName, string newModelName, float x, float y, float z, float rotx = 0f, float roty = 0f, float rotz = 0f)
        {
            model = modelName;
            newModel = newModelName;
            posX = x;
            posY = y;
            posZ = z;
            rotX = rotx;
            rotX = roty;
            rotZ = rotz;
        }
    }
}
