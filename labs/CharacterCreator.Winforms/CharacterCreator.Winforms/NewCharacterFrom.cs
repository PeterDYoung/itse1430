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
    public partial class NewCharacterFrom : Form
    {
        public NewCharacterFrom ()
        {
            InitializeComponent ();            
        }


        private void tableLayoutPanel1_Paint ( object sender, PaintEventArgs e )
        {

        }

        private void textBoxName_Validating ( object sender, CancelEventArgs e )
        {
            if (textBoxName.Text == "")
            {
                errorProviderNameBox.SetError (textBoxName, "Enter a name");
                
            } else
            {
                errorProviderNameBox.SetError (textBoxName, String.Empty);
            }
            
        }

        private void bindingSource1_CurrentChanged ( object sender, EventArgs e )
        {

        }

        private void NewCharacterFrom_Load ( object sender, EventArgs e )
        {
            comboBoxClass.DataSource = Enum.GetValues (typeof(Classes));
            comboBoxRace.DataSource = Enum.GetValues (typeof (Races));
        }
    }
}
