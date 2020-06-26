using FileManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Controller
{
    public class FileControllers
    {
        public static bool AddFile(ClassFile file)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    foreach(var folder in file.ListFolder)
                    {
                        var folderdb = (from u in _context.TableDir
                                        where u.name == folder.name
                                        select u).SingleOrDefault();
                        folderdb.ListFile.Add(file);
                    }
                    file.ListFolder.Clear();
                    _context.TableFile.AddOrUpdate(file);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch { return false; }
        }
        public static bool CheckExistFile(string address, string foldername)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    var filedb = (from u in _context.TableFile
                                  where u.address == address
                                  select u).ToList();
                    foreach (ClassDir x in filedb[0].ListFolder)
                    {
                        if (x.name == foldername)
                            return false;
                    }
                    if (filedb.Count == 1)
                    { return true; }
                    else { return false; }
                }
            }
            catch { return false; }
        }
        public static ClassFile getFileFormAddress(string address)
        {
            //using (var _context = new DBFileContext())
            //{
            //    var filedb = (from u in _context.TableFile
            //                  where u.)
            //}
            using (var _context = new DBFileContext())
            {
                var filedb = (from u in _context.TableFile
                              where u.address == address
                              select u).ToList();
                
                if (filedb.Count == 1)
                { return filedb[0]; }
                else { return null; }
            }
        }
        public static List<ClassDir> getListFolderFormAddress(string address)
        {
            using (var _context = new DBFileContext())
            {
                var filedb = (from u in _context.TableFile
                              where u.address == address
                              select u).ToList();

                if (filedb.Count == 1)
                { return filedb[0].ListFolder.ToList(); }
                else { return null; }
            }
        }


        public static bool checkExistFolderInListFolder(string foldername, List<ClassDir> listfolder)
        {
            foreach(ClassDir x in listfolder)
            {
                if (x.name == foldername)
                    return true;
            }
            return false;

        }
        public static List<ClassFile> getAllfile()
        {
            using (var _context = new DBFileContext())
            {
                var files = (from u in _context.TableFile.AsEnumerable()
                             select new
                             {
                                 filename = u.filename,
                                 address = u.address,
                                 note = u.note,
                                 type = u.type,
                                 icon = u.icon,
                                 lastread = u.lastread,
                                 flag = u.flag,
                                 listfolder = u.ListFolder
                             }).Select(x => new ClassFile
                             {
                                 filename = x.filename,
                                 address = x.address,
                                 note = x.note,
                                 type = x.type,
                                 icon = x.icon,
                                 lastread = x.lastread,
                                 flag = x.flag,
                                 ListFolder = x.listfolder
                             }).ToList();
                return files;

            }
        }
        public static List<ClassFile> getListFilefromFolder(string foldername)
        {
            using (var _context = new DBFileContext())
            {
                var files = (from u in _context.TableFile.AsEnumerable()
                             select new
                             {
                                 filename = u.filename,
                                 address = u.address,
                                 note = u.note,
                                 type = u.type,
                                 icon = u.icon,
                                 lastread = u.lastread,
                                 flag = u.flag,
                                 listfolder = u.ListFolder
                             }).Select(x => new ClassFile
                             {
                                 filename = x.filename,
                                 address = x.address,
                                 note = x.note,
                                 type = x.type,
                                 icon = x.icon,
                                 lastread = x.lastread,
                                 flag = x.flag,
                                 ListFolder = x.listfolder
                             }).ToList();

            foreach (ClassFile y in files.ToList())
            {
                if (checkExistFolderInListFolder(foldername, y.ListFolder.ToList()) == false)
                    files.Remove(y);
            }
            return files.ToList();

            }
        }
        public static ClassFile getFileFormFilename(string filename)
        {

            using (var _context = new DBFileContext())
            {
                var filedb = (from u in _context.TableFile
                              where u.filename == filename
                              select u).ToList();

                if (filedb.Count == 1)
                { return filedb[0]; }
                else { return null; }
            }
        }
        public static bool UpdateFile(ClassFile file)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    _context.TableFile.AddOrUpdate(file);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateFile2(string name, string note )
        {
            using (var _context = new DBFileContext())
            {
                var files = (from u in _context.TableFile
                             where u.filename == name
                             select u).ToList();
                if (files.Count <= 0)
                    return false;
                files[0].note = note;
                _context.TableFile.AddOrUpdate(files[0]);
                _context.SaveChanges();
                return true;
            }
        }


        public static bool DeleteFile1(ClassFile file, string foldername)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    var filedb = (from u in _context.TableFile
                                  where u.filename == file.filename
                                  select u).Single();
                    if(foldername == "All Books")
                    {
                        _context.TableFile.Remove(filedb);
                        _context.SaveChanges();
                        return true;
                    }

                    foreach (ClassDir fo in filedb.ListFolder)
                    {
                        if (fo.name == foldername)
                        {
                            filedb.ListFolder.Remove(fo);
                            break;
                        }
                    }
                    if (filedb.ListFolder.Count <= 0)
                    {
                        _context.TableFile.Remove(filedb);

                    }
                    else
                    {
                        _context.TableFile.AddOrUpdate(filedb);
                    }

                    _context.SaveChanges();
                    return true;

                }
            }
            catch { return false; }
        }
        public static bool DeleteFile(ClassFile file)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    var dbFile = (from u in _context.TableFile
                                  where u.filename == file.filename
                                  select u).SingleOrDefault();

                    _context.TableFile.Remove(dbFile);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch { return false; }
        }

        public static List<ClassFile> getListFile(string txtSearch)
        {
            using (var _context = new DBFileContext())
            {
                var fi = (from u in _context.TableFile.AsEnumerable()
                          where u.filename.Contains(txtSearch)
                          select u).
                          Select(x => new ClassFile
                          {
                              filename = x.filename,
                              address = x.address,
                              type = x.type,
                              note = x.note,
                              icon = x.icon,
                              lastread = x.lastread,
                              flag = x.flag,
                              ListFolder = x.ListFolder
                          }).ToList();
                return fi;
            }
        }
    }
}
