//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demoex2.AppDataFile
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GromykoBD_2Entities : DbContext
    {
        private static GromykoBD_2Entities _context;
        public GromykoBD_2Entities()
            : base("name=GromykoBD_2Entities")
        {
        }

        public static GromykoBD_2Entities GetContext()
        {
            if (_context == null)
            {
                _context = new GromykoBD_2Entities();
            }
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Agent_Type> Agent_Type { get; set; }
        public virtual DbSet<History_Sales> History_Sales { get; set; }
        public virtual DbSet<Product_Type> Product_Type { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
