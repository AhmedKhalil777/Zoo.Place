using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Place.Domain
{
    public class AnimalClass
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("ClassName" , TypeName ="ntext")]
        [MaxLength(50)]
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public float AgeRange  { get; set; }

        public string Information { get; set; }

        public virtual List<Animal> Animals { get; set; }
    }
}
