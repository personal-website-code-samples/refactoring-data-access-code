namespace RefactorDataAccess.Infrastructure
{
    using Domain;
    using Microsoft.EntityFrameworkCore;

    public sealed class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base(new DbContextOptionsBuilder().UseSqlServer(string.Empty).Options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Widget> Widgets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Widget>(builder =>
            {
                builder.HasKey(widget => widget.Id);
                builder.Property(widget => widget.WidgetType);
                builder.Property(widget => widget.BatchNumber);
                builder.Property(widget => widget.CreatedOn);
            });
        }
    }
}
