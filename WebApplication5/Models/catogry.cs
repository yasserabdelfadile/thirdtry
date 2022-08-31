using System.Collections.Generic;
using System;
namespace WebApplication5.Models
{
    public class catogry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<news> news { get; set; }
    }
}
