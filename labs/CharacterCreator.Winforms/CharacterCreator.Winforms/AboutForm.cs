﻿//Peter Young
//11/8/19
//Cosc1430
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class AboutForm : Form
    {
        public AboutForm ()
        {
            InitializeComponent ();
        }

        private void button1_MouseClick ( object sender, MouseEventArgs e )
        {
            this.Close();
        }
    }
}
