using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videly.Models;

namespace Videly.ViewModel
{
    public class RandomViewModel
    {
        public List<Customer> Customer { get; set; }
        public List<Movies> Movies { get; set; }
    }
}
