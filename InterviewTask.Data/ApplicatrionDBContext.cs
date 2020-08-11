using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using InterviewTask.Data.Entities;
using InterviewTask.Data.Extensions;

namespace InterviewTask.Data
{

    public class ApplicationDBContext : DbContext //:IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogins, RoleClaim, UserToken>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
             : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            

            builder.ApplyConfiguration(new UserConfiguration());


            


            var permittedCascadeDelete = builder.CascadeDeletePermitted_FK_Types();
            var cascadeFKs = builder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade
                              && !permittedCascadeDelete.Contains(fk.PrincipalEntityType.Name));


            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
            builder.DataSeed();
        }
    }
}
