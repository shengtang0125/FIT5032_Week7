using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_Week7.Models
{
    public partial class FIT5032_Models : DbContext
    {
        public FIT5032_Models()
            : base("name=FIT5032_Models1")
        {
        }

        public virtual DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
