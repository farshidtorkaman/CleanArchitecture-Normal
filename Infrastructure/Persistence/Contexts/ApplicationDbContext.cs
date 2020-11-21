using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTimeService _dateTime;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
                                    ICurrentUserService currentUserService,
                                    IDateTimeService dateTime) : base(options)
        {
            _currentUserService = currentUserService;

            _dateTime = dateTime;
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<AttributeGroup> AttributeGroups { get; set; }

        public DbSet<Attribute> Attributes { get; set; }

        public DbSet<AttributeItem> AttributeItems { get; set; }

        public DbSet<ProductAttribute> ProductAttributes { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                    
                        entry.Entity.CreatedBy = _currentUserService.UserIp;
                        entry.Entity.CreatedAt = _dateTime.Now;
                        break;
                    
                    case EntityState.Modified:
                        
                        entry.Entity.UpdatedBy = _currentUserService.UserIp;
                        entry.Entity.UpdatedAt = _dateTime.Now;
                        break;
                
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}