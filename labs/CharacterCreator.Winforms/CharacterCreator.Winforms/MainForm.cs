
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CharacterCreator.Winforms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load ( object sender, EventArgs e )
        {

        }

        private void sfdnsToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void characterNewToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            var about = new AboutForm ();
            about.StartPosition = FormStartPosition.CenterParent;
            about.ShowDialog ();
        }

        private void aboutToolStripMenuItem1_Click ( object sender, EventArgs e )
        {
           
        }

        private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            System.Windows.Forms.Application.ExitThread ();
        }

        private void newToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            var newCharForm = new NewCharacterFrom();
            newCharForm.StartPosition = FormStartPosition.CenterParent;
            newCharForm.ShowDialog ();
        }
    }
}
