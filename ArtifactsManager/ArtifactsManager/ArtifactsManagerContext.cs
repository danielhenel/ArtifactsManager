using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactsManager
{
    public class ArtifactsManagerContext : DbContext
    {
        private byte[] salt = new byte[128 / 8];
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ArtifactsManager;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Element> Elements { get; set; }


        public void createAdminIfNotExist()
        {

            using (var context = new ArtifactsManagerContext())
            {

                var query = from user in context.Users
                            where user.login == "admin"
                            select user.login;

                var result = query.FirstOrDefault();

                if (result == null)
                {
                    User admin = new User
                    {
                        login = "admin",
                        password = hashPassword("admin"),
                        canAddArtifacts = true,
                        canEditArtifacts = true,
                        canRemoveArtifacts = true,
                        role = "admin"
                    };
                    context.Users.Add(admin);
                    context.SaveChanges();
                }
            }
        }


        public string hashPassword(string password)
        { 
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);

                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 300000,
                    numBytesRequested: 256 / 8));

                return $"{hashed}:{Convert.ToBase64String(salt)}";
            }
        }

        public bool verifyPassword(string hashed, string password)
        {
             var tab = hashed.Split(':');
             var salt = Convert.FromBase64String(tab[1]);
       
             password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                 password: password,
                 salt: salt,
                 prf: KeyDerivationPrf.HMACSHA256,
                 iterationCount: 300000,
                 numBytesRequested: 256 / 8));

             if (tab[0] == password)
             {
                 return true;
             }
             return false;
        }

    }
}
