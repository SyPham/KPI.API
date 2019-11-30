using API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : IdentityDbContext<User, Role, int, 
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, 
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}
        public DbSet<KPI> KPIs { get; set; }
        public DbSet<KPILevel> KPILevels { get; set; }

        public DbSet<API.Models.Data> Datas { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<SeenComment> SeenComments { get; set; }

        public DbSet<Resource> Resources { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Unit> Units { get; set; }

        public DbSet<Revise> Revises { get; set; }
        public DbSet<ActionPlan> ActionPlans { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ActionPlanDetail> ActionPlanDetails { get; set; }
        public DbSet<NotificationDetail> NotificationDetails { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ErrorMessage> ErrorMessages { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Uploader> Uploaders { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<CategoryKPILevel> CategoryKPILevels { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<OCCategory> OCCategories { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<StateSendMail> StateSendMails { get; set; }
        public DbSet<Setting> Settings { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>(userRole => 
            {
                userRole.HasKey(ur => new {ur.UserId, ur.RoleId});

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

        }
    }
}