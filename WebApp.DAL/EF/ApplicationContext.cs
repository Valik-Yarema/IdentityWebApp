using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DAL.Entities;

namespace WebApp.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext()
        : base("DBConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
        public DbSet<AddInfo> AddInfos { get; set; }
        public DbSet<PhoneRec> PhoneRecs { get; set; }       
        public DbSet<MessageRec> MessageRecs { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<ClientProfile> ClientProfiles { get; set; }

        /*public ApplicationContext(string connectionString) : base(connectionString) { }


        public ApplicationContext(DbSet<ClientProfile> clientProfiles)
        {
            ClientProfiles = clientProfiles;
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext("DefaultConnection");
        }*/
    }
}
