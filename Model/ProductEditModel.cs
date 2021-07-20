using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HTML_Form_Basic.Model
{
    public class ProductEditModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Rating { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}