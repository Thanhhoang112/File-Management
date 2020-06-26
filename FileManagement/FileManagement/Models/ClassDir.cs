using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement.Models
{
    [Table("Folder")]
    public class ClassDir
    {
        [Key]
        public string name { get; set; }
        public virtual ICollection<ClassFile> ListFile { get; set; }
        
    }
}
