using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactsManager
{
    public class User
    {
        private string login { get; set; }  
        private string password { get; set; }  
        private string role { get; set; } 
        public bool canRemoveArtifacts { get; set; }
        public bool canEditArtifacts { get; set; }
        public bool canAddArtifacts { get; set; }
    }
}
