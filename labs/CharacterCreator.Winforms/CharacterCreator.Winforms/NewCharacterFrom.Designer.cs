namespace CharacterCreator.Winforms
{
    partial class NewCharacterFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlNewCharacter = new System.Windows.Forms.TabControl();
            this.tabPageBio = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabPageClassRace = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPageAbilityScores = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.totalCHALabel = new System.Windows.Forms.Label();
            this.totalWISLabel = new System.Windows.Forms.Label();
            this.totalCONLabel = new System.Windows.Forms.Label();
            this.totalINTLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.totalDEXLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.rbChaLabel = new System.Windows.Forms.Label();
            this.rbSTRLabel = new System.Windows.Forms.Label();
            this.rbIntLabel = new System.Windows.Forms.Label();
            this.rbConLabel = new System.Windows.Forms.Label();
            this.rbDexLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baseCHANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.baseWISNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.baseINTNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.baseCONNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.baseDEXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.baseSTRNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rbWisLabel = new System.Windows.Forms.Label();
            this.totalSTRLabel = new System.Windows.Forms.Label();
            this.exitTabPage = new System.Windows.Forms.TabPage();
            this.buttonExitNoSave = new System.Windows.Forms.Button();
            this.buttonSaveExit = new System.Windows.Forms.Button();
            this.errorProviderNameBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlNewCharacter.SuspendLayout();
            this.tabPageBio.SuspendLayout();
            this.tabPageClassRace.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageAbilityScores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseCHANumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseWISNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseINTNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseCONNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDEXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSTRNumericUpDown)).BeginInit();
            this.exitTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlNewCharacter
            // 
            this.tabControlNewCharacter.Controls.Add(this.tabPageBio);
            this.tabControlNewCharacter.Controls.Add(this.tabPageClassRace);
            this.tabControlNewCharacter.Controls.Add(this.tabPageAbilityScores);
            this.tabControlNewCharacter.Controls.Add(this.exitTabPage);
            this.tabControlNewCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNewCharacter.Location = new System.Drawing.Point(0, 0);
            this.tabControlNewCharacter.Name = "tabControlNewCharacter";
            this.tabControlNewCharacter.SelectedIndex = 0;
            this.tabControlNewCharacter.Size = new System.Drawing.Size(800, 450);
            this.tabControlNewCharacter.TabIndex = 0;
            // 
            // tabPageBio
            // 
            this.tabPageBio.Controls.Add(this.richTextBox1);
            this.tabPageBio.Controls.Add(this.label17);
            this.tabPageBio.Controls.Add(this.label16);
            this.tabPageBio.Controls.Add(this.textBoxName);
            this.tabPageBio.Location = new System.Drawing.Point(4, 33);
            this.tabPageBio.Name = "tabPageBio";
            this.tabPageBio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBio.Size = new System.Drawing.Size(792, 413);
            this.tabPageBio.TabIndex = 1;
            this.tabPageBio.Text = "Bio";
            this.tabPageBio.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(681, 218);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "Bio (Optional)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(110, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(184, 29);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // tabPageClassRace
            // 
            this.tabPageClassRace.Controls.Add(this.panel1);
            this.tabPageClassRace.Location = new System.Drawing.Point(4, 33);
            this.tabPageClassRace.Name = "tabPageClassRace";
            this.tabPageClassRace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClassRace.Size = new System.Drawing.Size(792, 413);
            this.tabPageClassRace.TabIndex = 2;
            this.tabPageClassRace.Text = "Class/Race";
            this.tabPageClassRace.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxClass);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.comboBoxRace);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(134, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 191);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(261, 94);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(183, 32);
            this.comboBoxClass.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Race";
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(42, 94);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(183, 32);
            this.comboBoxRace.TabIndex = 0;
            this.comboBoxRace.SelectedIndexChanged += new System.EventHandler(this.comboBoxRace_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(251, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 25);
            this.label19.TabIndex = 3;
            this.label19.Text = "Class";
            // 
            // tabPageAbilityScores
            // 
            this.tabPageAbilityScores.Controls.Add(this.groupBox1);
            this.tabPageAbilityScores.Location = new System.Drawing.Point(4, 33);
            this.tabPageAbilityScores.Name = "tabPageAbilityScores";
            this.tabPageAbilityScores.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbilityScores.Size = new System.Drawing.Size(792, 413);
            this.tabPageAbilityScores.TabIndex = 0;
            this.tabPageAbilityScores.Text = "Ability Scores";
            this.tabPageAbilityScores.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label28, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalCHALabel, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.totalWISLabel, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.totalCONLabel, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.totalINTLabel, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label27, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.totalDEXLabel, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label26, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label25, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label23, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label21, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label22, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbChaLabel, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.rbSTRLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbIntLabel, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.rbConLabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.rbDexLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.baseCHANumericUpDown, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.baseWISNumericUpDown, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.baseINTNumericUpDown, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.baseCONNumericUpDown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.baseDEXNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.baseSTRNumericUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.rbWisLabel, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.totalSTRLabel, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(755, 294);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(397, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(113, 20);
            this.label28.TabIndex = 9;
            this.label28.Text = "Total Score";
            // 
            // totalCHALabel
            // 
            this.totalCHALabel.AutoSize = true;
            this.totalCHALabel.Location = new System.Drawing.Point(397, 245);
            this.totalCHALabel.Name = "totalCHALabel";
            this.totalCHALabel.Size = new System.Drawing.Size(23, 25);
            this.totalCHALabel.TabIndex = 9;
            this.totalCHALabel.Text = "0";
            // 
            // totalWISLabel
            // 
            this.totalWISLabel.AutoSize = true;
            this.totalWISLabel.Location = new System.Drawing.Point(397, 200);
            this.totalWISLabel.Name = "totalWISLabel";
            this.totalWISLabel.Size = new System.Drawing.Size(23, 25);
            this.totalWISLabel.TabIndex = 10;
            this.totalWISLabel.Text = "0";
            // 
            // totalCONLabel
            // 
            this.totalCONLabel.AutoSize = true;
            this.totalCONLabel.Location = new System.Drawing.Point(397, 110);
            this.totalCONLabel.Name = "totalCONLabel";
            this.totalCONLabel.Size = new System.Drawing.Size(23, 25);
            this.totalCONLabel.TabIndex = 10;
            this.totalCONLabel.Text = "0";
            // 
            // totalINTLabel
            // 
            this.totalINTLabel.AutoSize = true;
            this.totalINTLabel.Location = new System.Drawing.Point(397, 155);
            this.totalINTLabel.Name = "totalINTLabel";
            this.totalINTLabel.Size = new System.Drawing.Size(23, 25);
            this.totalINTLabel.TabIndex = 9;
            this.totalINTLabel.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(367, 245);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(24, 25);
            this.label27.TabIndex = 13;
            this.label27.Text = "=";
            // 
            // totalDEXLabel
            // 
            this.totalDEXLabel.AutoSize = true;
            this.totalDEXLabel.Location = new System.Drawing.Point(397, 65);
            this.totalDEXLabel.Name = "totalDEXLabel";
            this.totalDEXLabel.Size = new System.Drawing.Size(23, 25);
            this.totalDEXLabel.TabIndex = 9;
            this.totalDEXLabel.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(367, 200);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 25);
            this.label26.TabIndex = 13;
            this.label26.Text = "=";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(367, 155);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 25);
            this.label25.TabIndex = 13;
            this.label25.Text = "=";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(367, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 25);
            this.label23.TabIndex = 13;
            this.label23.Text = "=";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(367, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 25);
            this.label21.TabIndex = 13;
            this.label21.Text = "=";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(367, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 25);
            this.label22.TabIndex = 14;
            this.label22.Text = "=";
            // 
            // rbChaLabel
            // 
            this.rbChaLabel.AutoSize = true;
            this.rbChaLabel.Location = new System.Drawing.Point(229, 245);
            this.rbChaLabel.Name = "rbChaLabel";
            this.rbChaLabel.Size = new System.Drawing.Size(23, 25);
            this.rbChaLabel.TabIndex = 11;
            this.rbChaLabel.Text = "0";
            // 
            // rbSTRLabel
            // 
            this.rbSTRLabel.AutoSize = true;
            this.rbSTRLabel.Location = new System.Drawing.Point(229, 20);
            this.rbSTRLabel.Name = "rbSTRLabel";
            this.rbSTRLabel.Size = new System.Drawing.Size(23, 25);
            this.rbSTRLabel.TabIndex = 8;
            this.rbSTRLabel.Text = "0";
            // 
            // rbIntLabel
            // 
            this.rbIntLabel.AutoSize = true;
            this.rbIntLabel.Location = new System.Drawing.Point(229, 155);
            this.rbIntLabel.Name = "rbIntLabel";
            this.rbIntLabel.Size = new System.Drawing.Size(23, 25);
            this.rbIntLabel.TabIndex = 10;
            this.rbIntLabel.Text = "0";
            // 
            // rbConLabel
            // 
            this.rbConLabel.AutoSize = true;
            this.rbConLabel.Location = new System.Drawing.Point(229, 110);
            this.rbConLabel.Name = "rbConLabel";
            this.rbConLabel.Size = new System.Drawing.Size(23, 25);
            this.rbConLabel.TabIndex = 9;
            this.rbConLabel.Text = "0";
            // 
            // rbDexLabel
            // 
            this.rbDexLabel.AutoSize = true;
            this.rbDexLabel.Location = new System.Drawing.Point(229, 65);
            this.rbDexLabel.Name = "rbDexLabel";
            this.rbDexLabel.Size = new System.Drawing.Size(23, 25);
            this.rbDexLabel.TabIndex = 7;
            this.rbDexLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(229, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "RacialBonus";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(124, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Score";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Attribute";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intelligence";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Constitution";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dexterity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strength";
            // 
            // baseChaNumericUpDown
            // 
            this.baseCHANumericUpDown.Location = new System.Drawing.Point(124, 248);
            this.baseCHANumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.baseCHANumericUpDown.Name = "baseChaNumericUpDown";
            this.baseCHANumericUpDown.Size = new System.Drawing.Size(60, 29);
            this.baseCHANumericUpDown.TabIndex = 11;
            this.baseCHANumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.baseCHANumericUpDown.ValueChanged += new System.EventHandler(this.baseChaNumericUpDown_ValueChanged);
            // 
            // baseWISNumericUpDown
            // 
            this.baseWISNumericUpDown.Location = new System.Drawing.Point(124, 203);
            this.baseWISNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.baseWISNumericUpDown.Name = "baseWISNumericUpDown";
            this.baseWISNumericUpDown.Size = new System.Drawing.Size(60, 29);
            this.baseWISNumericUpDown.TabIndex = 10;
            this.baseWISNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.baseWISNumericUpDown.ValueChanged += new System.EventHandler(this.baseWISNumericUpDown_ValueChanged);
            // 
            // baseINTNumericUpDown
            // 
            this.baseINTNumericUpDown.Location = new System.Drawing.Point(124, 158);
            this.baseINTNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.baseINTNumericUpDown.Name = "baseINTNumericUpDown";
            this.baseINTNumericUpDown.Size = new System.Drawing.Size(60, 29);
            this.baseINTNumericUpDown.TabIndex = 9;
            this.baseINTNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.baseINTNumericUpDown.ValueChanged += new System.EventHandler(this.baseINTNumericUpDown_ValueChanged);
            // 
            // baseConNumericUpDown
            // 
            this.baseCONNumericUpDown.Location = new System.Drawing.Point(124, 113);
            this.baseCONNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.baseCONNumericUpDown.Name = "baseConNumericUpDown";
            this.baseCONNumericUpDown.Size = new System.Drawing.Size(60, 29);
            this.baseCONNumericUpDown.TabIndex = 8;
            this.baseCONNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.baseCONNumericUpDown.ValueChanged += new System.EventHandler(this.baseConNumericUpDown_ValueChanged);
            // 
            // baseDEXNumericUpDown
            // 
            this.baseDEXNumericUpDown.Location = new System.Drawing.Point(124, 68);
            this.baseDEXNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.baseDEXNumericUpDown.Name = "baseDEXNumericUpDown";
            this.baseDEXNumericUpDown.Size = new System.Drawing.Size(60, 29);
            this.baseDEXNumericUpDown.TabIndex = 7;
            this.baseDEXNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.baseDEXNumericUpDown.ValueChanged += new System.EventHandler(this.baseDEXNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Charisma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wisdom";
            // 
            // baseSTRNumericUpDown
            // 
            this.baseSTRNumericUpDown.Location = new System.Drawing.Point(124, 23);
            this.baseSTRNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.baseSTRNumericUpDown.Name = "baseSTRNumericUpDown";
            this.baseSTRNumericUpDown.Size = new System.Drawing.Size(60, 29);
            this.baseSTRNumericUpDown.TabIndex = 6;
            this.baseSTRNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.baseSTRNumericUpDown.ValueChanged += new System.EventHandler(this.baseSTRNumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "+";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "+";
            // 
            // rbWisLabel
            // 
            this.rbWisLabel.AutoSize = true;
            this.rbWisLabel.Location = new System.Drawing.Point(229, 200);
            this.rbWisLabel.Name = "rbWisLabel";
            this.rbWisLabel.Size = new System.Drawing.Size(23, 25);
            this.rbWisLabel.TabIndex = 12;
            this.rbWisLabel.Text = "0";
            // 
            // totalSTRLabel
            // 
            this.totalSTRLabel.AutoSize = true;
            this.totalSTRLabel.Location = new System.Drawing.Point(397, 20);
            this.totalSTRLabel.Name = "totalSTRLabel";
            this.totalSTRLabel.Size = new System.Drawing.Size(23, 25);
            this.totalSTRLabel.TabIndex = 9;
            this.totalSTRLabel.Text = "0";
            // 
            // exitTabPage
            // 
            this.exitTabPage.Controls.Add(this.buttonExitNoSave);
            this.exitTabPage.Controls.Add(this.buttonSaveExit);
            this.exitTabPage.Location = new System.Drawing.Point(4, 33);
            this.exitTabPage.Name = "exitTabPage";
            this.exitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.exitTabPage.Size = new System.Drawing.Size(792, 413);
            this.exitTabPage.TabIndex = 3;
            this.exitTabPage.Text = "Save/Exit";
            this.exitTabPage.UseVisualStyleBackColor = true;
            // 
            // buttonExitNoSave
            // 
            this.buttonExitNoSave.Location = new System.Drawing.Point(420, 155);
            this.buttonExitNoSave.Name = "buttonExitNoSave";
            this.buttonExitNoSave.Size = new System.Drawing.Size(223, 100);
            this.buttonExitNoSave.TabIndex = 1;
            this.buttonExitNoSave.Text = "Exit without Saving";
            this.buttonExitNoSave.UseVisualStyleBackColor = true;
            this.buttonExitNoSave.Click += new System.EventHandler(this.buttonExitNoSave_Click);
            // 
            // buttonSaveExit
            // 
            this.buttonSaveExit.Location = new System.Drawing.Point(118, 155);
            this.buttonSaveExit.Name = "buttonSaveExit";
            this.buttonSaveExit.Size = new System.Drawing.Size(223, 100);
            this.buttonSaveExit.TabIndex = 0;
            this.buttonSaveExit.Text = "Save and Exit";
            this.buttonSaveExit.UseVisualStyleBackColor = true;
            this.buttonSaveExit.Click += new System.EventHandler(this.buttonSaveExit_Click);
            // 
            // errorProviderNameBox
            // 
            this.errorProviderNameBox.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNameBox.ContainerControl = this;
            // 
            // NewCharacterFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlNewCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCharacterFrom";
            this.ShowIcon = false;
            this.Text = "Create New Character";
            this.Load += new System.EventHandler(this.NewCharacterFrom_Load);
            this.tabControlNewCharacter.ResumeLayout(false);
            this.tabPageBio.ResumeLayout(false);
            this.tabPageBio.PerformLayout();
            this.tabPageClassRace.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageAbilityScores.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseCHANumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseWISNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseINTNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseCONNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDEXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSTRNumericUpDown)).EndInit();
            this.exitTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNewCharacter;
        private System.Windows.Forms.TabPage tabPageAbilityScores;
        private System.Windows.Forms.TabPage tabPageBio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown baseCHANumericUpDown;
        private System.Windows.Forms.NumericUpDown baseWISNumericUpDown;
        private System.Windows.Forms.NumericUpDown baseINTNumericUpDown;
        private System.Windows.Forms.NumericUpDown baseCONNumericUpDown;
        private System.Windows.Forms.NumericUpDown baseDEXNumericUpDown;
        private System.Windows.Forms.NumericUpDown baseSTRNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ErrorProvider errorProviderNameBox;
        private System.Windows.Forms.TabPage tabPageClassRace;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.Label rbSTRLabel;
        private System.Windows.Forms.Label rbDexLabel;
        private System.Windows.Forms.Label rbConLabel;
        private System.Windows.Forms.Label rbWisLabel;
        private System.Windows.Forms.Label rbChaLabel;
        private System.Windows.Forms.Label rbIntLabel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label totalCHALabel;
        private System.Windows.Forms.Label totalWISLabel;
        private System.Windows.Forms.Label totalCONLabel;
        private System.Windows.Forms.Label totalINTLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label totalDEXLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label totalSTRLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage exitTabPage;
        private System.Windows.Forms.Button buttonExitNoSave;
        private System.Windows.Forms.Button buttonSaveExit;
    }
}