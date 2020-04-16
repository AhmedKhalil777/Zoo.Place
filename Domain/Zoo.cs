using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Place.Domain
{
    public class Zoo
    {

        [Key]
        public int Id { get; set; }
        [Column("ZooName", TypeName ="ntext")]
        [MaxLength(30)]
        public string Name { get; set; }

        public string Address { get; set; }

        public string PicPath { get; set; }
        public virtual List<Cage> Cages { get; set; }
        public virtual List<AnimalClass> Classes  { get; set; }

        public virtual List<Visitor> Visitors { get; set; }

    }
}
