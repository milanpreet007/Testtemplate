namespace Finaltest.Views
{
    partial class CharacterGenerationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.SkillsPage = new System.Windows.Forms.TabPage();
            this.CharacterSheetPage = new System.Windows.Forms.TabPage();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.identitytableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Firstnamelabel = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.FirstNameDataLAbel = new System.Windows.Forms.Label();
            this.LastNamedatalabel = new System.Windows.Forms.Label();
            this.GenerateNamebutton = new System.Windows.Forms.Button();
            this.AbilitiestableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.generateAbilitiesbutton = new System.Windows.Forms.Button();
            this.Strengthlabel = new System.Windows.Forms.Label();
            this.Endurancelabel = new System.Windows.Forms.Label();
            this.intellectlabel = new System.Windows.Forms.Label();
            this.Educationlabel = new System.Windows.Forms.Label();
            this.dexteritylabel = new System.Windows.Forms.Label();
            this.SocialStandinglabel = new System.Windows.Forms.Label();
            this.StrengthDatalabel = new System.Windows.Forms.Label();
            this.IntellectDatalabel = new System.Windows.Forms.Label();
            this.Dexteritydatalabel = new System.Windows.Forms.Label();
            this.Educationdatalabel = new System.Windows.Forms.Label();
            this.SocialStandingdatalabel = new System.Windows.Forms.Label();
            this.Endurancedatalabel = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.identitytableLayoutPanel.SuspendLayout();
            this.AbilitiestableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.SkillsPage);
            this.MainTabControl.Controls.Add(this.CharacterSheetPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(784, 429);
            this.MainTabControl.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.identitytableLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(776, 392);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.AbilitiestableLayoutPanel);
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilityPage.Size = new System.Drawing.Size(776, 392);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // SkillsPage
            // 
            this.SkillsPage.Location = new System.Drawing.Point(4, 33);
            this.SkillsPage.Name = "SkillsPage";
            this.SkillsPage.Size = new System.Drawing.Size(776, 392);
            this.SkillsPage.TabIndex = 2;
            this.SkillsPage.Text = "Skills";
            this.SkillsPage.UseVisualStyleBackColor = true;
            // 
            // CharacterSheetPage
            // 
            this.CharacterSheetPage.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheetPage.Name = "CharacterSheetPage";
            this.CharacterSheetPage.Size = new System.Drawing.Size(776, 392);
            this.CharacterSheetPage.TabIndex = 3;
            this.CharacterSheetPage.Text = "Character Sheet";
            this.CharacterSheetPage.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(622, 490);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(136, 63);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(29, 490);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(136, 63);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // identitytableLayoutPanel
            // 
            this.identitytableLayoutPanel.ColumnCount = 4;
            this.identitytableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identitytableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identitytableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identitytableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identitytableLayoutPanel.Controls.Add(this.Firstnamelabel, 0, 0);
            this.identitytableLayoutPanel.Controls.Add(this.GenerateNamebutton, 2, 3);
            this.identitytableLayoutPanel.Controls.Add(this.lastNamelabel, 0, 1);
            this.identitytableLayoutPanel.Controls.Add(this.LastNamedatalabel, 1, 1);
            this.identitytableLayoutPanel.Controls.Add(this.FirstNameDataLAbel, 1, 0);
            this.identitytableLayoutPanel.Location = new System.Drawing.Point(4, 7);
            this.identitytableLayoutPanel.Name = "identitytableLayoutPanel";
            this.identitytableLayoutPanel.RowCount = 4;
            this.identitytableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identitytableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identitytableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identitytableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identitytableLayoutPanel.Size = new System.Drawing.Size(769, 309);
            this.identitytableLayoutPanel.TabIndex = 0;
            // 
            // Firstnamelabel
            // 
            this.Firstnamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Firstnamelabel.Location = new System.Drawing.Point(3, 0);
            this.Firstnamelabel.Name = "Firstnamelabel";
            this.Firstnamelabel.Size = new System.Drawing.Size(186, 77);
            this.Firstnamelabel.TabIndex = 0;
            this.Firstnamelabel.Text = "First Name";
            this.Firstnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNamelabel.Location = new System.Drawing.Point(3, 77);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(186, 77);
            this.lastNamelabel.TabIndex = 1;
            this.lastNamelabel.Text = "Last Name";
            this.lastNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLAbel
            // 
            this.FirstNameDataLAbel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLAbel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLAbel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.identitytableLayoutPanel.SetColumnSpan(this.FirstNameDataLAbel, 3);
            this.FirstNameDataLAbel.Location = new System.Drawing.Point(195, 0);
            this.FirstNameDataLAbel.Name = "FirstNameDataLAbel";
            this.FirstNameDataLAbel.Size = new System.Drawing.Size(571, 77);
            this.FirstNameDataLAbel.TabIndex = 1;
            this.FirstNameDataLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNamedatalabel
            // 
            this.LastNamedatalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNamedatalabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNamedatalabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.identitytableLayoutPanel.SetColumnSpan(this.LastNamedatalabel, 3);
            this.LastNamedatalabel.Location = new System.Drawing.Point(195, 77);
            this.LastNamedatalabel.Name = "LastNamedatalabel";
            this.LastNamedatalabel.Size = new System.Drawing.Size(571, 77);
            this.LastNamedatalabel.TabIndex = 1;
            this.LastNamedatalabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenerateNamebutton
            // 
            this.GenerateNamebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.identitytableLayoutPanel.SetColumnSpan(this.GenerateNamebutton, 2);
            this.GenerateNamebutton.Location = new System.Drawing.Point(387, 234);
            this.GenerateNamebutton.Name = "GenerateNamebutton";
            this.GenerateNamebutton.Size = new System.Drawing.Size(379, 72);
            this.GenerateNamebutton.TabIndex = 1;
            this.GenerateNamebutton.Text = "Generate Name";
            this.GenerateNamebutton.UseVisualStyleBackColor = true;
            this.GenerateNamebutton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // AbilitiestableLayoutPanel
            // 
            this.AbilitiestableLayoutPanel.ColumnCount = 4;
            this.AbilitiestableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.AbilitiestableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AbilitiestableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiestableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiestableLayoutPanel.Controls.Add(this.Endurancedatalabel, 1, 2);
            this.AbilitiestableLayoutPanel.Controls.Add(this.Dexteritydatalabel, 1, 1);
            this.AbilitiestableLayoutPanel.Controls.Add(this.dexteritylabel, 0, 1);
            this.AbilitiestableLayoutPanel.Controls.Add(this.Strengthlabel, 0, 0);
            this.AbilitiestableLayoutPanel.Controls.Add(this.generateAbilitiesbutton, 2, 7);
            this.AbilitiestableLayoutPanel.Controls.Add(this.StrengthDatalabel, 1, 0);
            this.AbilitiestableLayoutPanel.Controls.Add(this.Endurancelabel, 0, 2);
            this.AbilitiestableLayoutPanel.Controls.Add(this.intellectlabel, 0, 3);
            this.AbilitiestableLayoutPanel.Controls.Add(this.Educationlabel, 0, 4);
            this.AbilitiestableLayoutPanel.Controls.Add(this.SocialStandinglabel, 0, 5);
            this.AbilitiestableLayoutPanel.Controls.Add(this.IntellectDatalabel, 1, 3);
            this.AbilitiestableLayoutPanel.Controls.Add(this.Educationdatalabel, 1, 4);
            this.AbilitiestableLayoutPanel.Controls.Add(this.SocialStandingdatalabel, 1, 5);
            this.AbilitiestableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.AbilitiestableLayoutPanel.Name = "AbilitiestableLayoutPanel";
            this.AbilitiestableLayoutPanel.RowCount = 8;
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.Size = new System.Drawing.Size(767, 390);
            this.AbilitiestableLayoutPanel.TabIndex = 0;
            // 
            // generateAbilitiesbutton
            // 
            this.generateAbilitiesbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilitiestableLayoutPanel.SetColumnSpan(this.generateAbilitiesbutton, 2);
            this.generateAbilitiesbutton.Location = new System.Drawing.Point(386, 339);
            this.generateAbilitiesbutton.Name = "generateAbilitiesbutton";
            this.generateAbilitiesbutton.Size = new System.Drawing.Size(378, 48);
            this.generateAbilitiesbutton.TabIndex = 2;
            this.generateAbilitiesbutton.Text = "Generate Abilities";
            this.generateAbilitiesbutton.UseVisualStyleBackColor = true;
            // 
            // Strengthlabel
            // 
            this.Strengthlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Strengthlabel.Location = new System.Drawing.Point(3, 0);
            this.Strengthlabel.Name = "Strengthlabel";
            this.Strengthlabel.Size = new System.Drawing.Size(262, 48);
            this.Strengthlabel.TabIndex = 0;
            this.Strengthlabel.Text = "Strength";
            this.Strengthlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Endurancelabel
            // 
            this.Endurancelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Endurancelabel.Location = new System.Drawing.Point(3, 96);
            this.Endurancelabel.Name = "Endurancelabel";
            this.Endurancelabel.Size = new System.Drawing.Size(262, 48);
            this.Endurancelabel.TabIndex = 0;
            this.Endurancelabel.Text = "Endurance";
            this.Endurancelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intellectlabel
            // 
            this.intellectlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intellectlabel.Location = new System.Drawing.Point(3, 144);
            this.intellectlabel.Name = "intellectlabel";
            this.intellectlabel.Size = new System.Drawing.Size(262, 48);
            this.intellectlabel.TabIndex = 3;
            this.intellectlabel.Text = "Intellect";
            this.intellectlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Educationlabel
            // 
            this.Educationlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Educationlabel.Location = new System.Drawing.Point(3, 192);
            this.Educationlabel.Name = "Educationlabel";
            this.Educationlabel.Size = new System.Drawing.Size(262, 48);
            this.Educationlabel.TabIndex = 4;
            this.Educationlabel.Text = "Education";
            this.Educationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dexteritylabel
            // 
            this.dexteritylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dexteritylabel.Location = new System.Drawing.Point(3, 48);
            this.dexteritylabel.Name = "dexteritylabel";
            this.dexteritylabel.Size = new System.Drawing.Size(262, 48);
            this.dexteritylabel.TabIndex = 5;
            this.dexteritylabel.Text = "Dexterity";
            this.dexteritylabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SocialStandinglabel
            // 
            this.SocialStandinglabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandinglabel.Location = new System.Drawing.Point(3, 240);
            this.SocialStandinglabel.Name = "SocialStandinglabel";
            this.SocialStandinglabel.Size = new System.Drawing.Size(262, 48);
            this.SocialStandinglabel.TabIndex = 6;
            this.SocialStandinglabel.Text = "Social Standing";
            this.SocialStandinglabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthDatalabel
            // 
            this.StrengthDatalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDatalabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDatalabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDatalabel.Location = new System.Drawing.Point(271, 0);
            this.StrengthDatalabel.Name = "StrengthDatalabel";
            this.StrengthDatalabel.Size = new System.Drawing.Size(109, 48);
            this.StrengthDatalabel.TabIndex = 1;
            this.StrengthDatalabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntellectDatalabel
            // 
            this.IntellectDatalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectDatalabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntellectDatalabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntellectDatalabel.Location = new System.Drawing.Point(271, 144);
            this.IntellectDatalabel.Name = "IntellectDatalabel";
            this.IntellectDatalabel.Size = new System.Drawing.Size(109, 48);
            this.IntellectDatalabel.TabIndex = 7;
            this.IntellectDatalabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dexteritydatalabel
            // 
            this.Dexteritydatalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dexteritydatalabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dexteritydatalabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dexteritydatalabel.Location = new System.Drawing.Point(271, 48);
            this.Dexteritydatalabel.Name = "Dexteritydatalabel";
            this.Dexteritydatalabel.Size = new System.Drawing.Size(109, 48);
            this.Dexteritydatalabel.TabIndex = 9;
            this.Dexteritydatalabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Educationdatalabel
            // 
            this.Educationdatalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Educationdatalabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Educationdatalabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Educationdatalabel.Location = new System.Drawing.Point(271, 192);
            this.Educationdatalabel.Name = "Educationdatalabel";
            this.Educationdatalabel.Size = new System.Drawing.Size(109, 48);
            this.Educationdatalabel.TabIndex = 10;
            this.Educationdatalabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SocialStandingdatalabel
            // 
            this.SocialStandingdatalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingdatalabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SocialStandingdatalabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SocialStandingdatalabel.Location = new System.Drawing.Point(271, 240);
            this.SocialStandingdatalabel.Name = "SocialStandingdatalabel";
            this.SocialStandingdatalabel.Size = new System.Drawing.Size(109, 48);
            this.SocialStandingdatalabel.TabIndex = 11;
            this.SocialStandingdatalabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Endurancedatalabel
            // 
            this.Endurancedatalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Endurancedatalabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Endurancedatalabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Endurancedatalabel.Location = new System.Drawing.Point(271, 96);
            this.Endurancedatalabel.Name = "Endurancedatalabel";
            this.Endurancedatalabel.Size = new System.Drawing.Size(109, 48);
            this.Endurancedatalabel.TabIndex = 12;
            this.Endurancedatalabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CharacterGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.MainTabControl);
            this.Name = "CharacterGenerationForm";
            this.Text = "Character Generator";
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.AbilityPage.ResumeLayout(false);
            this.identitytableLayoutPanel.ResumeLayout(false);
            this.AbilitiestableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TabPage SkillsPage;
        private System.Windows.Forms.TabPage CharacterSheetPage;
        private System.Windows.Forms.TableLayoutPanel identitytableLayoutPanel;
        private System.Windows.Forms.Label Firstnamelabel;
        private System.Windows.Forms.Button GenerateNamebutton;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label FirstNameDataLAbel;
        private System.Windows.Forms.Label LastNamedatalabel;
        private System.Windows.Forms.TableLayoutPanel AbilitiestableLayoutPanel;
        private System.Windows.Forms.Label Endurancedatalabel;
        private System.Windows.Forms.Label Dexteritydatalabel;
        private System.Windows.Forms.Label dexteritylabel;
        private System.Windows.Forms.Label Strengthlabel;
        private System.Windows.Forms.Button generateAbilitiesbutton;
        private System.Windows.Forms.Label StrengthDatalabel;
        private System.Windows.Forms.Label Endurancelabel;
        private System.Windows.Forms.Label intellectlabel;
        private System.Windows.Forms.Label Educationlabel;
        private System.Windows.Forms.Label SocialStandinglabel;
        private System.Windows.Forms.Label IntellectDatalabel;
        private System.Windows.Forms.Label Educationdatalabel;
        private System.Windows.Forms.Label SocialStandingdatalabel;
    }
}
