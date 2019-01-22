using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lesson19
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public string Type { get; set; }


        public virtual ICollection<Song> Songs { get; set; }
    }
}
