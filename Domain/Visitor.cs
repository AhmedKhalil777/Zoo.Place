using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Place.Domain
{
    public class Visitor
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(100)]
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public virtual Zoo zoo { get; set; }
    }
}
