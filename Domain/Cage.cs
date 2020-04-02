using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Zoo.Place.Domain
{
    [Flags]
    public enum Environment
    {
        Water,
        Ground,
        Lake,
        Bettary,
        Mice

    }
    public class Cage
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public Environment EnvironmentType { get; set; }
        public int Capacity { get; set; }

        public float Area { get; set; }

        public string Address { get; set; }

        public virtual List<Animal> Animals { get; set; }

    }
}
