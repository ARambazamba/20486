using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsApi
{
    public static class DBInitializer
    {
        public static void Initialize(SkillDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Skills.FirstOrDefault() == null)
            {
                var sk1 = new Skill { name = "node.js" };
                var sk2 = new Skill { name = "typescript" };

                context.Skills.AddRange(sk1, sk2);

                context.SaveChanges();
            }

        }
    }
}
