using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Db_Insert.Models
{
    public class Insert
    {
        public string Name { get; set; }
        public decimal Price { get; set; }  // Changed to decimal for monetary values
    }
}