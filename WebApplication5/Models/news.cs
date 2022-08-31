using System;

namespace WebApplication5.Models
{
    public class news
    {
        public int Id { get; set; }
        public string Name_title { get; set; }
        public string Image { get; set; }
        public string descrption { get; set; }
        public int catogryId { get; set; }
        public catogry catogry { get; set; }

    }
}
