using HRManagerWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRManagerWeb.Data
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
      public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "cac433ae-ffab-f791-1addb453ac61",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.User.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "41c433ae-ffab-1ou1-1abda403efd4",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper(),
                }

                ); ;

        }
    }
}