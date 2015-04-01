namespace Prisjakt
{
    partial class MainForm
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
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonUpdatePrices = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelLastUpdated = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.comboBoxArticle = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.groupBoxRemoveArticle = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelArticle = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.groupBoxNewArticle = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelCategoryID = new System.Windows.Forms.Label();
            this.textBoxCategoryID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelRank = new System.Windows.Forms.Label();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelGroup2 = new System.Windows.Forms.Label();
            this.groupBoxRemoveArticle.SuspendLayout();
            this.groupBoxNewArticle.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(300, 12);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(140, 23);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "Export to Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonUpdatePrices
            // 
            this.buttonUpdatePrices.Location = new System.Drawing.Point(300, 209);
            this.buttonUpdatePrices.Name = "buttonUpdatePrices";
            this.buttonUpdatePrices.Size = new System.Drawing.Size(140, 23);
            this.buttonUpdatePrices.TabIndex = 5;
            this.buttonUpdatePrices.Text = "Update articles";
            this.buttonUpdatePrices.UseVisualStyleBackColor = true;
            this.buttonUpdatePrices.Click += new System.EventHandler(this.buttonUpdatePrices_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(300, 238);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(140, 12);
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // labelLastUpdated
            // 
            this.labelLastUpdated.AutoSize = true;
            this.labelLastUpdated.Location = new System.Drawing.Point(297, 170);
            this.labelLastUpdated.Name = "labelLastUpdated";
            this.labelLastUpdated.Size = new System.Drawing.Size(72, 13);
            this.labelLastUpdated.TabIndex = 7;
            this.labelLastUpdated.Text = "Last updated:";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(6, 35);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroups.TabIndex = 10;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // comboBoxArticle
            // 
            this.comboBoxArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArticle.FormattingEnabled = true;
            this.comboBoxArticle.Location = new System.Drawing.Point(6, 75);
            this.comboBoxArticle.Name = "comboBoxArticle";
            this.comboBoxArticle.Size = new System.Drawing.Size(220, 21);
            this.comboBoxArticle.TabIndex = 11;
            this.comboBoxArticle.SelectedIndexChanged += new System.EventHandler(this.comboBoxArticle_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(156, 112);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(6, 36);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(128, 20);
            this.textBoxGroup.TabIndex = 13;
            // 
            // groupBoxRemoveArticle
            // 
            this.groupBoxRemoveArticle.Controls.Add(this.buttonRemove);
            this.groupBoxRemoveArticle.Controls.Add(this.labelArticle);
            this.groupBoxRemoveArticle.Controls.Add(this.labelGroup);
            this.groupBoxRemoveArticle.Controls.Add(this.comboBoxGroups);
            this.groupBoxRemoveArticle.Controls.Add(this.comboBoxArticle);
            this.groupBoxRemoveArticle.Location = new System.Drawing.Point(12, 158);
            this.groupBoxRemoveArticle.Name = "groupBoxRemoveArticle";
            this.groupBoxRemoveArticle.Size = new System.Drawing.Size(232, 100);
            this.groupBoxRemoveArticle.TabIndex = 14;
            this.groupBoxRemoveArticle.TabStop = false;
            this.groupBoxRemoveArticle.Text = "Remove Article";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(156, 35);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(70, 23);
            this.buttonRemove.TabIndex = 27;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelArticle
            // 
            this.labelArticle.AutoSize = true;
            this.labelArticle.Location = new System.Drawing.Point(6, 59);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(36, 13);
            this.labelArticle.TabIndex = 16;
            this.labelArticle.Text = "Article";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(6, 19);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(36, 13);
            this.labelGroup.TabIndex = 15;
            this.labelGroup.Text = "Group";
            // 
            // groupBoxNewArticle
            // 
            this.groupBoxNewArticle.Controls.Add(this.buttonEdit);
            this.groupBoxNewArticle.Controls.Add(this.labelCategoryID);
            this.groupBoxNewArticle.Controls.Add(this.textBoxCategoryID);
            this.groupBoxNewArticle.Controls.Add(this.labelID);
            this.groupBoxNewArticle.Controls.Add(this.textBoxID);
            this.groupBoxNewArticle.Controls.Add(this.labelRank);
            this.groupBoxNewArticle.Controls.Add(this.textBoxRank);
            this.groupBoxNewArticle.Controls.Add(this.labelName);
            this.groupBoxNewArticle.Controls.Add(this.textBoxName);
            this.groupBoxNewArticle.Controls.Add(this.labelGroup2);
            this.groupBoxNewArticle.Controls.Add(this.textBoxGroup);
            this.groupBoxNewArticle.Controls.Add(this.buttonAdd);
            this.groupBoxNewArticle.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNewArticle.Name = "groupBoxNewArticle";
            this.groupBoxNewArticle.Size = new System.Drawing.Size(232, 140);
            this.groupBoxNewArticle.TabIndex = 15;
            this.groupBoxNewArticle.TabStop = false;
            this.groupBoxNewArticle.Text = "New Article";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(80, 112);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(70, 23);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelCategoryID
            // 
            this.labelCategoryID.AutoSize = true;
            this.labelCategoryID.Location = new System.Drawing.Point(6, 98);
            this.labelCategoryID.Name = "labelCategoryID";
            this.labelCategoryID.Size = new System.Drawing.Size(63, 13);
            this.labelCategoryID.TabIndex = 25;
            this.labelCategoryID.Text = "Category ID";
            // 
            // textBoxCategoryID
            // 
            this.textBoxCategoryID.Location = new System.Drawing.Point(6, 114);
            this.textBoxCategoryID.Name = "textBoxCategoryID";
            this.textBoxCategoryID.Size = new System.Drawing.Size(65, 20);
            this.textBoxCategoryID.TabIndex = 24;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(140, 20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(140, 36);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(46, 20);
            this.textBoxID.TabIndex = 22;
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Location = new System.Drawing.Point(192, 20);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(33, 13);
            this.labelRank.TabIndex = 21;
            this.labelRank.Text = "Rank";
            // 
            // textBoxRank
            // 
            this.textBoxRank.Location = new System.Drawing.Point(192, 36);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(33, 20);
            this.textBoxRank.TabIndex = 20;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(219, 20);
            this.textBoxName.TabIndex = 18;
            // 
            // labelGroup2
            // 
            this.labelGroup2.AutoSize = true;
            this.labelGroup2.Location = new System.Drawing.Point(6, 20);
            this.labelGroup2.Name = "labelGroup2";
            this.labelGroup2.Size = new System.Drawing.Size(36, 13);
            this.labelGroup2.TabIndex = 17;
            this.labelGroup2.Text = "Group";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 262);
            this.Controls.Add(this.groupBoxNewArticle);
            this.Controls.Add(this.groupBoxRemoveArticle);
            this.Controls.Add(this.labelLastUpdated);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonUpdatePrices);
            this.Controls.Add(this.buttonExport);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(468, 300);
            this.MinimumSize = new System.Drawing.Size(468, 300);
            this.Name = "MainForm";
            this.Text = "Prisjakt";
            this.groupBoxRemoveArticle.ResumeLayout(false);
            this.groupBoxRemoveArticle.PerformLayout();
            this.groupBoxNewArticle.ResumeLayout(false);
            this.groupBoxNewArticle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonUpdatePrices;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelLastUpdated;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.ComboBox comboBoxArticle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.GroupBox groupBoxRemoveArticle;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.GroupBox groupBoxNewArticle;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelGroup2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelCategoryID;
        private System.Windows.Forms.TextBox textBoxCategoryID;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
    }
}

