
using Microsoft.EntityFrameworkCore;

namespace TakafulApi.api.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}

        // protected override void OnModelCreating(ModelBuilder modelBuilder){
        //     modelBuilder.Entity<Comment>()
        //     .Property(C=>C.StarRate)
        //     .HasDefaultValue(1);
        // }

       
       
     
    }
}