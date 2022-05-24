using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactsManager
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Element> Elements { get; } = new List<Element>();

    }
}
