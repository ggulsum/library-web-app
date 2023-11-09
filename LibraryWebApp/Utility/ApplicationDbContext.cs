using Microsoft.EntityFrameworkCore;
namespace LibraryWebApp.Utility
{
    //DbContext sinifindan turetildigi icin
    public class ApplicationDbContext:DbContext
    {
        //Su an burada asp.net mekanizmasina gore entity ile db arasındaki kopru sinifini oluşturuyoruz.
        
        //constructions
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) { }  
        
    }
}
