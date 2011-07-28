using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

// test

namespace Exclusions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearchCarboniteDrive_Click(object sender, EventArgs e)
        {
            // Computer\Carbonite Backup Drive

            string[] files = Directory.GetFiles("\\Computer\\Carbonite Backup Drive", "*", SearchOption.AllDirectories);



        }
    }
}
