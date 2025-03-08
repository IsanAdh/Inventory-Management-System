using KTMPos.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.DAL.Configurations
{
    public class LoginConfigurations : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            var login=GetLoginData();
            builder.HasData(login);

        }
        private List<Login> GetLoginData()
        {
            var logins = new List<Login>()
           {
               new Login
               {
                   Id=1,
                   UserName="isan",
                   Password="isan"
               }
           };
            return logins;
        }
    }
}
