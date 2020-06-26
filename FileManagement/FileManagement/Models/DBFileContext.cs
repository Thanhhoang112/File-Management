using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Models
{
    public class DBFileContext: DbContext
    {
        public DBFileContext():base("name=DBEntityFile")
        {

        }
        public DbSet<ClassFile> TableFile { get; set; }
        public DbSet<ClassDir> TableDir { get; set; }
    }
}
