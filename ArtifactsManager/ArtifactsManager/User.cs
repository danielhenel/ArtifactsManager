using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactsManager
{
    public class User
    {
        [Key]
        public string login { get; set; }  
        public string password { get; set; }  
        public string role { get; set; } 
        public bool canRemoveArtifacts { get; set; }
        public bool canEditArtifacts { get; set; }
        public bool canAddArtifacts { get; set; }
    }
}
