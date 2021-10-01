using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelFN.Text = Resource.FirstName;
            labelLN.Text = Resource.LastName;
            buttonAdd.Text = Resource.Add;
        }
    }
}
