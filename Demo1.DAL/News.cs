using System;

namespace Demo1.DAL
{
    public class News
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public DateTime InsertTime { get; set; }
        public bool HotNews { get; set; }

    }


}