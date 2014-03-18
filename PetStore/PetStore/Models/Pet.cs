using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PetStore.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Animal { get; set; }
        public string Description { get; set; }
        [Display(Name = "Received Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RecDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}