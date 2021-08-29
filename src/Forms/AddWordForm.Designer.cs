
namespace sozluk
{
    partial class AddWordForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtWordName = new System.Windows.Forms.TextBox();
            this.TxtArticleLink = new System.Windows.Forms.TextBox();
            this.BtnAddDefinition = new System.Windows.Forms.Button();
            this.BtnRemoveDefinition = new System.Windows.Forms.Button();
            this.ListDefinitions = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Black;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(274, 174);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Black;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(355, 174);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtWordName
            // 
            this.TxtWordName.BackColor = System.Drawing.Color.Black;
            this.TxtWordName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWordName.ForeColor = System.Drawing.Color.White;
            this.TxtWordName.Location = new System.Drawing.Point(12, 12);
            this.TxtWordName.Name = "TxtWordName";
            this.TxtWordName.PlaceholderText = "Word name here";
            this.TxtWordName.Size = new System.Drawing.Size(418, 23);
            this.TxtWordName.TabIndex = 2;
            // 
            // TxtArticleLink
            // 
            this.TxtArticleLink.BackColor = System.Drawing.Color.Black;
            this.TxtArticleLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtArticleLink.ForeColor = System.Drawing.Color.White;
            this.TxtArticleLink.Location = new System.Drawing.Point(12, 41);
            this.TxtArticleLink.Name = "TxtArticleLink";
            this.TxtArticleLink.PlaceholderText = "Article link here";
            this.TxtArticleLink.Size = new System.Drawing.Size(418, 23);
            this.TxtArticleLink.TabIndex = 3;
            // 
            // BtnAddDefinition
            // 
            this.BtnAddDefinition.BackColor = System.Drawing.Color.Black;
            this.BtnAddDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddDefinition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddDefinition.ForeColor = System.Drawing.Color.White;
            this.BtnAddDefinition.Location = new System.Drawing.Point(400, 71);
            this.BtnAddDefinition.Name = "BtnAddDefinition";
            this.BtnAddDefinition.Size = new System.Drawing.Size(30, 30);
            this.BtnAddDefinition.TabIndex = 4;
            this.BtnAddDefinition.Text = "+";
            this.BtnAddDefinition.UseVisualStyleBackColor = false;
            this.BtnAddDefinition.Click += new System.EventHandler(this.BtnAddDefinition_Click);
            // 
            // BtnRemoveDefinition
            // 
            this.BtnRemoveDefinition.BackColor = System.Drawing.Color.Black;
            this.BtnRemoveDefinition.Enabled = false;
            this.BtnRemoveDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveDefinition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRemoveDefinition.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveDefinition.Location = new System.Drawing.Point(400, 138);
            this.BtnRemoveDefinition.Name = "BtnRemoveDefinition";
            this.BtnRemoveDefinition.Size = new System.Drawing.Size(30, 30);
            this.BtnRemoveDefinition.TabIndex = 5;
            this.BtnRemoveDefinition.Text = "-";
            this.BtnRemoveDefinition.UseVisualStyleBackColor = false;
            this.BtnRemoveDefinition.Click += new System.EventHandler(this.BtnRemoveDefinition_Click);
            // 
            // ListDefinitions
            // 
            this.ListDefinitions.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListDefinitions.BackColor = System.Drawing.Color.Black;
            this.ListDefinitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListDefinitions.ForeColor = System.Drawing.Color.White;
            this.ListDefinitions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListDefinitions.HideSelection = false;
            this.ListDefinitions.LabelEdit = true;
            this.ListDefinitions.Location = new System.Drawing.Point(12, 71);
            this.ListDefinitions.MultiSelect = false;
            this.ListDefinitions.Name = "ListDefinitions";
            this.ListDefinitions.ShowGroups = false;
            this.ListDefinitions.Size = new System.Drawing.Size(382, 97);
            this.ListDefinitions.TabIndex = 6;
            this.ListDefinitions.UseCompatibleStateImageBehavior = false;
            this.ListDefinitions.View = System.Windows.Forms.View.Details;
            this.ListDefinitions.SelectedIndexChanged += new System.EventHandler(this.ListDefinitions_SelectedIndexChanged);
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(445, 209);
            this.Controls.Add(this.ListDefinitions);
            this.Controls.Add(this.BtnRemoveDefinition);
            this.Controls.Add(this.BtnAddDefinition);
            this.Controls.Add(this.TxtArticleLink);
            this.Controls.Add(this.TxtWordName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add word";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtWordName;
        private System.Windows.Forms.TextBox TxtArticleLink;
        private System.Windows.Forms.Button BtnAddDefinition;
        private System.Windows.Forms.Button BtnRemoveDefinition;
        private System.Windows.Forms.ListView ListDefinitions;
    }
}