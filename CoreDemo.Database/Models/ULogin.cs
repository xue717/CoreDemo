using System;
using System.Collections.Generic;

namespace CoreDemo.Database.Models
{
    public partial class ULogin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public bool Enable { get; set; }
    }
}
