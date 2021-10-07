using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            labelFN.Text = Resource.FullName;
            buttonAdd.Text = Resource.Add;
            buttonFile.Text = Resource.File;
            buttonDel.Text = Resource.Delete;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBoxFN.Text
            };
            users.Add(u);
        }

        private void textBoxFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath; 
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv"; 
            sfd.DefaultExt = "csv"; 
            sfd.AddExtension = true; 

            
            if (sfd.ShowDialog() != DialogResult.OK) return;

            
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var u in users)
                {
                    sw.Write(u.ID);
                    sw.Write(";");
                    sw.Write(u.FullName);
                    sw.WriteLine();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var selectedUser = listUsers.SelectedItem;
            if (selectedUser!=null)
            {
                users.Remove((User)selectedUser);
            }
        }
    }
}
