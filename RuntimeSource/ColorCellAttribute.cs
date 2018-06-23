using System;

namespace geniikw.DataSheetLab
{
    public class BigCheck : Attribute
    {
        public float max;
        public float r;
        public float g;
        public float b;

        public BigCheck(float max, float r=1f, float g=0f, float b=0f)
        {
            this.max = max;
            this.r = r; this.g = g; this.b = b;
        }
    }

    public class SmallCheck : Attribute
    {
        public float min;
        public float r;
        public float g;
        public float b;

        public SmallCheck(float min, float r = 0f, float g = 0f, float b = 1f)
        {
            this.min = min;
            this.r = r; this.g = g; this.b = b;
        }
    }
    
}