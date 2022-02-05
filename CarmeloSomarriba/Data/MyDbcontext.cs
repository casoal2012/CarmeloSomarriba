using Microsoft.EntityFrameworkCore;

namespace CarmeloSomarriba.Data
{
    public class MyDbcontext : DbContext
    {
        public MyDbcontext(DbContextOptions<MyDbcontext> options) : base(options)
        {
        }



        
        
}
}

