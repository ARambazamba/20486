using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsApi
{
    //To manage Migrations & create the DB go to console:
    //[dotnet restore]
    //dotnet ef migrations add MIGRATION-NAME
    //dotnet ef database update

    public class SkillDBContext : IdentityDbContext
    {
        public SkillDBContext()
        {

        }

        public SkillDBContext(DbContextOptions<SkillDBContext> options) : base(options)
        {

        }

        public DbSet<Skill> Skills { get; set; }

    }
}
