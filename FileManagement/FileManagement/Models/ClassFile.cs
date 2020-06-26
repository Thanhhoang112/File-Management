using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Models
{
    [Table("File")]
    public class ClassFile
    {
        [Key]
        public string filename { get; set; }
        public string address { get; set; }
        public string note { get; set; }
        public string type { get; set; }
        public int icon { get; set; }
        public DateTime lastread { get; set; }
        public bool flag { get; set; }
        public virtual ICollection<ClassDir> ListFolder { get; set; }
    }
}
