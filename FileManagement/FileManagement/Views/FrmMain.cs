using FileManagement.Controller;
using FileManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FileManagement.Views
{
    public partial class FrmMain : Form
    {
        public string address = "";
        public string foldername = "All Books";
        public string fileaddress;
        public string filename;
        public TimeSpan timeread;
        public DateTime daynow = DateTime.Now;
        public bool flag = true; // true là xóa folder; false là xóa file
        public FrmMain()
        {
            InitializeComponent();
            CreateDB();
            WaterMark_Search();
            WaterMark_Note();
            displayFolder();
            displayFiles();
            
        }

        private void ToolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Create WatermarkSearch
        private void WaterMark_Search()
        {
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search";
            txtSearch.Leave += TxtSearch_Leave;
            txtSearch.Enter += TxtSearch_Enter;
            //for (int i = 0; i < listFolder.Size.Width - 100; i++)
            //{
            //    lbSpace.Text += " ";
            //}
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text =="Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                txtSearch.ForeColor = Color.Gray;
                txtSearch.Text = "Search";
            }
        }
        #endregion

        #region Create WatermarkNote
        private void WaterMark_Note()
        {
            rtNote.ForeColor = Color.Gray;
            rtNote.Text = "Write here to make note";
            rtNote.Leave += RtNote_Leave;
            rtNote.Enter += RtNote_Enter;
            
        }

        private void RtNote_Enter(object sender, EventArgs e)
        {
            if (rtNote.Text == "Write here to make note")
            {
                rtNote.Text = "";
                rtNote.ForeColor = Color.Black;
            }
        }

        private void RtNote_Leave(object sender, EventArgs e)
        {
            if (rtNote.Text == "")
            {
                rtNote.ForeColor = Color.Gray;
                rtNote.Text = "Write here to make note";
            }
        }
        #endregion


        private void CreateDB()
        {
            try
            {
                dbTestController.initializeDB();
            }
            catch
            {
                return;
            }
        }

        private void newfilebt_Click(object sender, EventArgs e)
        {
            if (foldername == "All Books" || foldername == "Unread" || foldername == "Recent")
            {
                MessageBox.Show("Please select the folder");
                return;
            }
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.RestoreDirectory = true;
            dlgOpen.Filter = "*Doc Files(*.docx)|*.docx|*TXT Files(*.txt)|*.txt|*Doc Files(*.doc)|*.doc|*PDF Files(*.pdf)|*.pdf*";
            dlgOpen.FilterIndex = 1;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                //address = dlgOpen.FileName;
                //ClassFile file = new ClassFile();
                //file.filename = dlgOpen.SafeFileName;
                //file.address = dlgOpen.FileName;
                //FileInfo fileinfo = new FileInfo(address);
                //file.type = fileinfo.Extension.Trim();
                //file.note = "";
                //if (file.type == ".doc" || file.type == ".docx")
                //    file.icon = 1;
                //else if (file.type == ".pdf")
                //    file.icon = 2;
                //else if (file.type == ".txt")
                //    file.icon = 3;
                address = dlgOpen.FileName;
                ClassFile file = new ClassFile();
                file.filename = dlgOpen.SafeFileName;
                file.address = dlgOpen.FileName;
                FileInfo fileinfo = new FileInfo(address);
                file.type = fileinfo.Extension.Trim();
                file.note = "";
                file.lastread = Convert.ToDateTime("01/01/2000");
                file.flag = false;
                if (file.type == ".doc" || file.type == ".docx")
                    file.icon = 1;
                else if (file.type == ".pdf")
                    file.icon = 2;
                else if (file.type == ".txt")
                    file.icon = 3;
                file.ListFolder = new List<ClassDir>();

                if (FileControllers.CheckExistFile(address, foldername) == true)
                {
                    ClassFile filedb = FileControllers.getFileFormAddress(address);

                    foreach (ClassDir x in FileControllers.getListFolderFormAddress(address))
                    {
                        file.ListFolder.Add(x);
                    }
                    file.ListFolder.Add(FolderControllers.getFolder(foldername));
                    FileControllers.DeleteFile(filedb);
                    FileControllers.AddFile(file);
                }
                else
                {
                    file.ListFolder.Add(FolderControllers.getFolder(foldername));

                    FileControllers.AddFile(file);
                }
            }
            displayFiles();
        }
        private void displayFolder()
        {
            lstFolder.Clear();
            List<ClassDir> listFolder = FolderControllers.getListFolder();
            for(int i=0;i<listFolder.Count;i++)
            {
                if(listFolder[i].name == "All Books")
                {
                    ListViewItem fol = new ListViewItem(listFolder[i].name, 4);
                    lstFolder.Items.Add(fol);
                }
                else if(listFolder[i].name == "Recent")
                {
                    ListViewItem fol = new ListViewItem(listFolder[i].name, 5);
                    lstFolder.Items.Add(fol);
                }
                else if(listFolder[i].name == "Unread")
                {
                    ListViewItem fol = new ListViewItem(listFolder[i].name, 6);
                    lstFolder.Items.Add(fol);
                }
                else
                {
                    ListViewItem fol = new ListViewItem(listFolder[i].name, 0);
                    lstFolder.Items.Add(fol);
                }
            }
        }

        private void addfolderbt_Click(object sender, EventArgs e)
        {
            FrmNewFolder frm2 = new FrmNewFolder();
            frm2.ShowDialog();
            displayFolder();
        }


        private void lstFolder_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Delete)
                {
                    if(this.lstFolder.SelectedItems.Count<=0)
                    { return; 
                    }
                    ClassDir dir = FolderControllers.getFolder(lstFolder.SelectedItems[0].SubItems[0].Text);
                    if(dir.name == "All Books" || dir.name == "Unread" || dir.name == "Recent")
                    {
                        MessageBox.Show("Can't delete this folder");
                        return;
                    }
                    FolderControllers.DeleteFolder(dir);
                    displayFolder();
                }
            }
            catch
            {
                return;
            }
        }
        private void displayFiles()
        {
            lstFile.Clear();
            if (foldername == "All Books")
            {
                List<ClassFile> listfile = FileControllers.getAllfile();
                for (int i = 0; i < listfile.Count; i++)
                {
                    ListViewItem fil = new ListViewItem(listfile[i].filename, listfile[i].icon);
                    lstFile.Items.Add(fil);
                }
            }
            else if (foldername == "Unread")
            {
                List<ClassFile> listfile = FileControllers.getAllfile();
                foreach (ClassFile y in listfile.ToList())
                {
                    if (y.flag == true)
                        listfile.Remove(y);
                }
                for (int i = 0; i < listfile.Count; i++)
                {
                    ListViewItem fil = new ListViewItem(listfile[i].filename, listfile[i].icon);
                    lstFile.Items.Add(fil);
                }
            }
            else if (foldername == "Recent")
            {
                List<ClassFile> listfile = FileControllers.getAllfile();
                for(int i=0;i<listfile.Count;i++)
                {
                    timeread = daynow - listfile[i].lastread;
                    if(Convert.ToDouble(timeread.TotalDays.ToString())<=7)
                    {
                        ListViewItem fil = new ListViewItem(listfile[i].filename, listfile[i].icon);
                        lstFile.Items.Add(fil);
                    }
                }
            }
            else
            {
                List<ClassFile> listfile = FileControllers.getListFilefromFolder(foldername);
                for (int i = 0; i < listfile.Count; i++)
                {
                    ListViewItem fil = new ListViewItem(listfile[i].filename, listfile[i].icon);
                    lstFile.Items.Add(fil);
                }
            }
        }

        private void lstFolder_Click(object sender, EventArgs e)
        {
            try
            {
                flag = true;
                foldername = this.lstFolder.SelectedItems[0].SubItems[0].Text;
                lstFolder_DoubleClick(sender, e);
            }
            catch
            {
                return;
            }
        }

        private void lstFile_DoubleClick(object sender, EventArgs e)
        {
            ClassFile fi = new ClassFile();
            fi = FileControllers.getFileFormFilename(filename);
            try
            {
                if(fi == null)
                    {
                        return;
                    }
                Process.Start(fi.address);
                fi.flag = true;
                fi.lastread = DateTime.Now;
                FileControllers.UpdateFile(fi);
            }
            catch
            {
                FileControllers.DeleteFile(fi);
                MessageBox.Show("File doesn't exist", "Error", MessageBoxButtons.OK);
                displayFiles();
                return;
            }
        }

        private void lstFile_Click(object sender, EventArgs e)
        {
            try
            {
                flag = false;
                filename = this.lstFile.SelectedItems[0].SubItems[0].Text;
                ClassFile fi = new ClassFile();
                fi = FileControllers.getFileFormFilename(filename);
                rtNote.Text = fi.note;
                rtNote.ForeColor = Color.Black;
                if (rtNote.Text == "")
                {
                    WaterMark_Note();
                }
            }
            catch
            {
                return;
            }
        }

        private void lstFolder_DoubleClick(object sender, EventArgs e)
        {
            foldername = this.lstFolder.SelectedItems[0].SubItems[0].Text;
            displayFiles();
        }


        private void lstFile_KeyDown(object sender, KeyEventArgs e) // Delete file
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (this.lstFile.SelectedItems.Count <= 0)
                    {
                        return;
                    }
                    ClassFile fi = FileControllers.getFileFormFilename(lstFile.SelectedItems[0].SubItems[0].Text);

                    FileControllers.DeleteFile1(fi,foldername);
                    displayFiles();
                }
            }
            catch
            {
                return;
            }
        }

        private void rtNote_KeyDown(object sender, KeyEventArgs e) //Save note
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    FileControllers.UpdateFile2(filename, rtNote.Text);
                }
            }
            catch
            {
                return;
            }
        }


        private void ToolNewFolder_Click(object sender, EventArgs e)
        {
            addfolderbt_Click(sender, e);
        }

        private void ToolDeleteBook_Click(object sender, EventArgs e)
        {
            //try
            {
                if (flag == false)
                {
                    if (this.lstFile.SelectedItems.Count <= 0)
                    {
                        return;
                    }
                    ClassFile fi = FileControllers.getFileFormFilename(lstFile.SelectedItems[0].SubItems[0].Text);

                    FileControllers.DeleteFile1(fi, foldername);
                    displayFiles();
                }
            }
            //catch 
            //{ 
            //    return; 
            //}
        }

        private void ToolDeleteFolder_Click(object sender, EventArgs e)
        {
            if(flag == true)
            {
                if (this.lstFolder.SelectedItems.Count <= 0)
                {
                    return;
                }
                ClassDir dir = FolderControllers.getFolder(lstFolder.SelectedItems[0].SubItems[0].Text);
                if (dir.name == "All Books" || dir.name == "Unread" || dir.name == "Recent")
                {
                    MessageBox.Show("Can't delete this folder");
                    return;
                }
                FolderControllers.DeleteFolder(dir);
                displayFolder();
            }
        }

        private void ToolNew_Click(object sender, EventArgs e)
        {
            newfilebt_Click(sender, e);
        }

        private void ToolSave_Click(object sender, EventArgs e)
        {
            FileControllers.UpdateFile2(filename, rtNote.Text);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            lstFile.Clear();
            if(foldername == "All Books")
            {
                List<ClassFile> listfile = new List<ClassFile>();
                listfile = FileControllers.getListFile(txtSearch.Text);
                for (int i = 0; i < listfile.Count; i++)
                {
                    ListViewItem fil = new ListViewItem(listfile[i].filename, listfile[i].icon);
                    lstFile.Items.Add(fil);
                }
            }
            else if(foldername == "Unread")
            {
                List<ClassFile> listfile = new List<ClassFile>();
                listfile = FileControllers.getListFile(txtSearch.Text);
                for(int i=0;i<listfile.Count;i++)
                {
                    if(listfile[i].flag==false)
                    {
                        ListViewItem fil = new ListViewItem(listfile[i].filename, listfile[i].icon);
                        lstFile.Items.Add(fil);
                    }
                }
            }
            else if(foldername == "Recent")
            {
                List<ClassFile> listfile = new List<ClassFile>();
                listfile = FileControllers.getListFile(txtSearch.Text);
                for (int i = 0; i < listfile.Count; i++)
                {
                    timeread = daynow - listfile[i].lastread;
                    if (Convert.ToDouble(timeread.TotalDays.ToString()) <= 7)
                    {
                        ListViewItem fil = new ListViewItem(listfile[i].filename, listfile[i].icon);
                        lstFile.Items.Add(fil);
                    }
                }
            }
            else
            {
                List<ClassFile> listfile = new List<ClassFile>();
                listfile = FileControllers.getListFilefromFolder(foldername);
                for(int i=0;i<listfile.Count;i++)
                {
                    if(listfile[i].filename.Contains(txtSearch.Text))
                    {
                        ListViewItem fil = new ListViewItem(listfile[i].filename, listfile[i].icon);
                        lstFile.Items.Add(fil);
                    }
                }
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btSearch_Click(sender, e);
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstFile.View = View.SmallIcon;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstFile.View = View.LargeIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstFile.View = View.List;
        }

        private void tittleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstFile.View = View.Tile;
        }
        private void unreadbt_Click(object sender, EventArgs e)
        {
            try
            {
                ClassFile fi = new ClassFile();
                fi = FileControllers.getFileFormFilename(filename);
                if (fi == null)
                {
                    MessageBox.Show("Please select the folder to mark");
                    return;
                }                    
                fi.flag = false;
                fi.lastread = Convert.ToDateTime("01/01/2000");
                FileControllers.UpdateFile(fi);
            }
            catch
            { return; }
        }
    }
}
