//Peter Young
//11/8/19
//Cosc1430
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Diagnostics;

namespace CharacterCreator.Winforms
{

    public partial class NewCharacterFrom : Form
    {
        public Character character;
        //internal lists to handle ui elements 
        internal List<Label> rbLabelList;
        internal JArray jRaces;
        internal List<NumericUpDown> baseNumericUpDownList;
        internal List<Label> totalLabelList;
        

        public NewCharacterFrom ()
        {
            InitializeComponent ();            
        }
        public NewCharacterFrom (Character editableChar)
        {
            character = editableChar;
            InitializeComponent ();
        }
        public void EditMode (Character editCharacter) {
            character = editCharacter;
            textBoxName.Text = character.Name;
            character.Discription = richTextBox1.Text;
            baseSTRNumericUpDown.Text = character.Strength.ToString();
            baseDEXNumericUpDown.Text = character.Dexterity.ToString ();
            baseCONNumericUpDown.Text = character.Constitution.ToString ();
            baseINTNumericUpDown.Text = character.Intelligence.ToString ();
            baseWISNumericUpDown.Text = character.Wisdom.ToString ();
            baseCHANumericUpDown.Text = character.Charisma.ToString ();
            comboBoxClass.Text = character.Class.ToString ();
            comboBoxRace.Text = character.Race.ToString ();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            StackTrace stackTrace = new StackTrace ();
            

            comboBoxClass.DataSource = Enum.GetValues(typeof(Classes));
            comboBoxRace.DataSource = Enum.GetValues(typeof(Races));

            // list of labels for racial bounus to ability scores
            rbLabelList = new List<Label>();
            #region Add Racial bonus labels to list in order (STR,DEX,CON,INT,WIS,CHA)
            rbLabelList.Add(rbSTRLabel);
            rbLabelList.Add(rbDexLabel);
            rbLabelList.Add(rbConLabel);
            rbLabelList.Add(rbIntLabel);
            rbLabelList.Add(rbWisLabel);
            rbLabelList.Add(rbChaLabel);
            #endregion

            baseNumericUpDownList = new List<NumericUpDown>();
            #region Add base abilty score UpDowns to list in order (STR,DEX,CON,INT,WIS,CHA)
            baseNumericUpDownList.Add(baseSTRNumericUpDown);
            baseNumericUpDownList.Add(baseDEXNumericUpDown);
            baseNumericUpDownList.Add(baseCONNumericUpDown);
            baseNumericUpDownList.Add(baseINTNumericUpDown);
            baseNumericUpDownList.Add(baseWISNumericUpDown);
            baseNumericUpDownList.Add(baseCHANumericUpDown);
            #endregion

            totalLabelList = new List<Label>();
            #region Add Racial bonus labels to list in order (STR,DEX,CON,INT,WIS,CHA)
            totalLabelList.Add(totalSTRLabel);
            totalLabelList.Add(totalDEXLabel);
            totalLabelList.Add(totalCONLabel);
            totalLabelList.Add(totalINTLabel);
            totalLabelList.Add(totalWISLabel);
            totalLabelList.Add(totalCHALabel);
            #endregion

            //parse json containg arrays of ability score modifiers for each race using json.net
            jRaces = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("Races.json")).Races;

            if (character!=null)
            {
                EditMode (character);
            } else 
            {
                character = new Character ();
                errorProviderNameBox.SetError(textBoxName, "Enter a name");  
            }
            
            UpdateRacialBonus ();
            UpdateScores();
        }

        #region Event Handlers
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
        private void NewCharacterFrom_Load(object sender, EventArgs e) { }
        

        #region ValueChanged event handlers for all ability score NumericUpDowns
        private void baseSTRNumericUpDown_ValueChanged ( object sender, EventArgs e )
        {
            UpdateScores ();
        }

        private void baseDEXNumericUpDown_ValueChanged ( object sender, EventArgs e )
        {
            UpdateScores ();
        }

        private void baseConNumericUpDown_ValueChanged ( object sender, EventArgs e )
        {
            UpdateScores ();
        }

        private void baseINTNumericUpDown_ValueChanged ( object sender, EventArgs e )
        {
            UpdateScores ();
        }

        private void baseWISNumericUpDown_ValueChanged ( object sender, EventArgs e )
        {
            UpdateScores ();
        }

        private void baseChaNumericUpDown_ValueChanged ( object sender, EventArgs e )
        {
            UpdateScores ();
        }
        #endregion
        

        private void comboBoxRace_SelectedIndexChanged ( object sender, EventArgs e )
        {
            try
            {
                UpdateRacialBonus ();
                UpdateScores ();
            } catch { }
        }
        private void buttonSaveExit_Click ( object sender, EventArgs e )
        {
            
            character.Name = textBoxName.Text;
            character.Discription = richTextBox1.Text;
            character.Strength = Int32.Parse(baseSTRNumericUpDown.Text);
            character.Dexterity = Int32.Parse (baseDEXNumericUpDown.Text);
            character.Constitution = Int32.Parse (baseCONNumericUpDown.Text);
            character.Intelligence = Int32.Parse (baseINTNumericUpDown.Text);
            character.Wisdom = Int32.Parse (baseWISNumericUpDown.Text);
            character.Charisma = Int32.Parse (baseCHANumericUpDown.Text);
            character.Class = (Classes) Enum.Parse(typeof(Classes), comboBoxClass.Text);
            character.Race = (Races)Enum.Parse (typeof (Races), comboBoxRace.Text);

            if (Validate(character)) {
                DialogResult = DialogResult.OK;
                this.Close();
            } else {
                MessageBox.Show("Invalid Chracter\nMake sure all fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void buttonExitNoSave_Click ( object sender, EventArgs e )
        {
            this.Close ();
        }
        #endregion

        #region Ulitlity methods
        private bool Validate(Character character) {
            if (!string.IsNullOrEmpty(character.Name)) {
                return true;
            }
            return false;
        }
        private void UpdateRacialBonus ()
        {
            string currRace = comboBoxRace.SelectedValue.ToString ();
            var jtRace = jRaces.FirstOrDefault (x => x.Value<string> ("Name")==currRace);
            var abilityScoreArr = jtRace["RacialBonus"].ToObject<int[]> ();

            //display racial bonus in atribute screen 
            for (int i = 0; i<6; i++)
            {
                rbLabelList[i].Text = abilityScoreArr[i].ToString ();
            }
        }
        private void UpdateScores ()
        {
            int[] abilityScores = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i<6; i++)
            {

                if (Int32.TryParse (rbLabelList[i].Text, out int num))
                {
                    abilityScores[i] += num;
                }
                abilityScores[i] += Decimal.ToInt32 (baseNumericUpDownList[i].Value);

            }
            for (int i = 0; i<6; i++)
            {
                totalLabelList[i].Text = abilityScores[i].ToString ();
            }
        }

        #endregion


    }
}
