using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiverCSharpLibrary.Model
{
    public class Meta
    {

        public DateTime CreatedAt { get; set; }

        public ICollection<string> Tags { get; set; }

        public string Title { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Guid Uuid { get; set; }

    }
}
