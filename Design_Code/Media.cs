using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Code
{
    public abstract class Media
    {
        public int id;
        public string title;
        public string thumbnailURL;
        public abstract bool Upload(string path);
    }

    public class Image : Media
    {
        public string originalURL;
        public string optimizeURL;
        public override bool Upload(string path)
        {
            return true;
        }
    }
}
