using FileManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Controller
{
    public class dbTestController
    {
        public static void initializeDB()
        {
            using (var _context = new DBFileContext())
            {
                //var dir = new ClassDir { name = "Library" };
                _context.TableDir.Add(new ClassDir { name = "All Books" });
                _context.TableDir.Add(new ClassDir { name = "Unread" });
                _context.TableDir.Add(new ClassDir { name = "Recent" });
                _context.SaveChanges();
            }
        }
    }
}
