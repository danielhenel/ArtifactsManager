using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactsManager
{
    public class Getter
    {
        static ArtifactsManagerContext context = new ArtifactsManagerContext();


        public static List<User> getUsers()
        {
            return (from user in context.Users
                    select user).ToList();
        }
    }
}
