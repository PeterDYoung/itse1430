//Peter Young
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


namespace CharacterCreator.Winforms {
    public partial class MainForm : Form {
        private List<Character> _characters;

        public MainForm() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            _characters = new List<Character>();
            listBoxRoster.DataSource = _characters;
        }
        #region Event handlers
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
            if (newCharForm.ShowDialog(this) == DialogResult.OK) {
                AddCharacter(newCharForm.character);               
            }
                
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!_characters.Any ())
            {
                MessageBox.Show ("No Characters to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listBoxRoster.SelectedIndex==-1)
            {
                MessageBox.Show ("Select a Character to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newCharForm = new NewCharacterFrom ((Character)listBoxRoster.SelectedItem);            
            newCharForm.StartPosition = FormStartPosition.CenterParent;                       
            if (newCharForm.ShowDialog (this) == DialogResult.OK)
            {
                EditCharacter (newCharForm.character);
            }
        }
        private void deleteToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            DeleteSelectedCharacter ();
        }
        #endregion
        public void DeleteSelectedCharacter()
        {
            if (!_characters.Any ())
            {
                MessageBox.Show ("No Characters to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _characters.RemoveAt(listBoxRoster.SelectedIndex);
            listBoxRoster.DataSource = null;
            listBoxRoster.DataSource = _characters;
        }
        public void EditCharacter ( Character character )
        {
            _characters[listBoxRoster.SelectedIndex] = character;
            listBoxRoster.DataSource = null;
            listBoxRoster.DataSource = _characters;
        }

        public void AddCharacter (Character character)
        {
            _characters.Add(character);
            listBoxRoster.DataSource = null;
            listBoxRoster.DataSource = _characters;
        }

        
    }
}
