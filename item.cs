using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    public class item
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }

        public string getTitle()
        {
            return title;
        }
    }
}
