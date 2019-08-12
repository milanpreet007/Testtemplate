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
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.identitytableLayoutPanel.SuspendLayout();
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
            this.identitytableLayoutPanel.Controls.Add(this.FirstNameDataLAbel, 1, 0);
            this.identitytableLayoutPanel.Controls.Add(this.LastNamedatalabel, 1, 1);
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
            this.identitytableLayoutPanel.ResumeLayout(false);
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
    }
}
