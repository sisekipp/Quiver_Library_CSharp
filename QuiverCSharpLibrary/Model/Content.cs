using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiverCSharpLibrary.Model
{
    public class Content
    {
        public string Title { get; set; }

        public ICollection<Cell> Cells { get; set; }
    }
}
