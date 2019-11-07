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


namespace CharacterCreator.Winforms
{

    public partial class NewCharacterFrom : Form
    {
        internal List<Label> rbLabelList;
        internal JArray jRaces;
        internal List<NumericUpDown> baseNumericUpDownList;
        internal List<Label> totalLabelList;
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
                abilityScores[i] += Decimal.ToInt32(baseNumericUpDownList[i].Value);
                
            }
            for (int i = 0; i<6; i++)
            {
                totalLabelList[i].Text = abilityScores[i].ToString ();
            }
        }
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

            baseNumericUpDownList = new List<NumericUpDown> ();
            #region Add base abilty score UpDowns to list in order (STR,DEX,CON,INT,WIS,CHA)
            baseNumericUpDownList.Add (baseSTRNumericUpDown);
            baseNumericUpDownList.Add (baseDEXNumericUpDown);
            baseNumericUpDownList.Add (baseConNumericUpDown);
            baseNumericUpDownList.Add (baseINTNumericUpDown);
            baseNumericUpDownList.Add (baseWISNumericUpDown);
            baseNumericUpDownList.Add (baseChaNumericUpDown);
            #endregion

            totalLabelList = new List<Label> ();
            #region Add Racial bonus labels to list in order (STR,DEX,CON,INT,WIS,CHA)
            totalLabelList.Add (totalSTRLabel);
            totalLabelList.Add (totalDEXLabel);
            totalLabelList.Add (totalCONLabel);
            totalLabelList.Add (totalINTLabel);
            totalLabelList.Add (totalWISLabel);
            totalLabelList.Add (totalCHALabel);
            #endregion

            //parse json containg arrays of ability score modifiers for each race using json.net
            jRaces = JsonConvert.DeserializeObject<dynamic> (File.ReadAllText ("Races.json")).Races;

            UpdateRacialBonus ();
            UpdateScores ();
        }

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
    }
}
