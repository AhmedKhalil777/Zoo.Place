using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Place.Domain
{
    public class Animal
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();



        public int Age { get; set; }


        public virtual AnimalClass AnimalClass { get; set; }

        public virtual Cage Cage { get; set; }
    }
}
