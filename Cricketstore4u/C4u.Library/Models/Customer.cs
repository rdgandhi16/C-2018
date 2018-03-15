using C4u.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace C4u.Library.Models
{
    
    public class Customer:ICutomer
    {
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
