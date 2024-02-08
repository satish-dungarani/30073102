using PasswordManagerSystem.Models;
using System.Data.Entity;

public class PasswordManagerContext : DbContext
{
    public PasswordManagerContext() : base("name=ConnectionString")
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Password> Passwords { get; set; }
    public DbSet<PasswordHistory> PasswordHistories { get; set; }
    public DbSet<UserDetail> UserDetails { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(u => u.Id);
        modelBuilder.Entity<Password>().HasKey(p => p.Id);
        modelBuilder.Entity<PasswordHistory>().HasKey(ph => ph.Id);
        modelBuilder.Entity<UserDetail>().HasKey(ud => ud.Id);

        //modelBuilder.Entity<Password>()
        //    .HasRequired(p => p.User)
        //    .WithMany(u => u.Passwords)
        //    .HasForeignKey(p => p.UserId)
        //    .WillCascadeOnDelete(true);

        //modelBuilder.Entity<PasswordHistory>()
        //    .HasRequired(ph => ph.Password)
        //    .WithMany(p => p.PasswordHistories)
        //    .HasForeignKey(ph => ph.PasswordId)
        //    .WillCascadeOnDelete(true);


        base.OnModelCreating(modelBuilder);
    }
}
