using FileManagement.Controller;
using FileManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement.Views
{
    public partial class FrmNewFolder : Form
    {
        public FrmNewFolder()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtFolderName.Text.Trim().Length <= 0)
            {
                errorProvider1.SetError(txtFolderName, "Enter the folder's name");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            ClassDir folder = new ClassDir();
            folder.name = this.txtFolderName.Text.Trim();
            if(FolderControllers.AddFolder(folder) == false)
            {
                errorProvider1.SetError(txtFolderName, "Folder already exist");
                return;
            }
            else
            {
                errorProvider1.Clear();
                this.Close();
            }


        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
