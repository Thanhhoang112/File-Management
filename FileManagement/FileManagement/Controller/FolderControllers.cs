using FileManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManagement.Models;
using System.Security.Policy;
using System.Data.Entity.Migrations;

namespace FileManagement.Controller
{
    public class FolderControllers
    {
        public static bool AddFolder(ClassDir folder)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    _context.TableDir.Add(folder);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch { return false; }
        }
        public static List<ClassDir> getListFolder()
        {
            using (var _context = new DBFileContext())
            {
                var folders = (from u in _context.TableDir.AsEnumerable()
                               select u).Select(x => new ClassDir
                               {
                                   name = x.name,
                               }).ToList();
                return folders;
            }
        }
        public static bool DeleteFolder(ClassDir folder)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    var dbFolder = (from u in _context.TableDir
                                    where u.name == folder.name
                                    select u).SingleOrDefault();
                    foreach (var file in dbFolder.ListFile)
                    {
                        foreach(var u in file.ListFolder)
                        {
                            if(u.name == folder.name)
                            {
                                file.ListFolder.Remove(u);
                                break;
                            }
                        }
                    }
                    _context.TableDir.Remove(dbFolder);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch { return false; }
        }
        public static ClassDir getFolder(string foldername)
        {
            using(var _context = new DBFileContext())
            {
                var folder = (from u in _context.TableDir
                              where u.name == foldername
                              select u).ToList();
                if (folder.Count == 1)
                {
                    return folder[0];
                }
                else
                    return null;
            }
        }
    }
    
}
