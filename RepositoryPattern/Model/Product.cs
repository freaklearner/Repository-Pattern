using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Can't be null")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Name Can't be Null")]
        public decimal Price { get; set; }
    }
}
