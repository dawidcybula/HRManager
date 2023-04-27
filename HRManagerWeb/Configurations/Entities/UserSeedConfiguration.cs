using HRManagerWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRManagerWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            _ = builder.HasData(
                new Employee
                {
                    Id = "19f433ae-aacb-f721-abc57195deab",
                    Email = "admin@users.com",
                    NormalizedEmail = "ADMIN@USERS.COM",
                    UserName = "admin@users.com",
                    NormalizedUserName = "ADMIN@USERS.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                },
                new Employee
                {
                    Id = "16f433ae-aacb-f721-def57195deab",
                    Email = "normaluser@users.com",
                    NormalizedEmail = "NORMALUSER@USERS.COM",
                    UserName = "normaluser@users.com",
                    NormalizedUserName = "NORMALUSER@USERS.COM",
                    FirstName = "Normal",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                }


                ); ;

        }
    }
}