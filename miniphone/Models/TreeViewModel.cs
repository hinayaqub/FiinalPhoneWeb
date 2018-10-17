using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace miniphone.Models
{
    public class TreeViewModel
    {
        public int Id{get ; set;}
        public string branches { get; set; }
        public string nodes { get; set; }
        public string leaves { get; set; }

    }
}