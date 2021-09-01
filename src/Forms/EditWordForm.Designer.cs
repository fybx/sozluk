
namespace sozluk
{
    partial class EditWordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWordForm));
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtWordName = new System.Windows.Forms.TextBox();
            this.TxtArticleLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDefinition = new System.Windows.Forms.TextBox();
            this.ListDefinitions = new System.Windows.Forms.ListBox();
            this.BtnRemoveDefinition = new System.Windows.Forms.Button();
            this.BtnAddDefinition = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtReference = new System.Windows.Forms.TextBox();
            this.ListReferences = new System.Windows.Forms.ListBox();
            this.BtnRemoveReference = new System.Windows.Forms.Button();
            this.BtnAddReference = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Black;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(334, 481);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(81, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "&Save word";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Black;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(421, 481);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // TxtWordName
            // 
            this.TxtWordName.BackColor = System.Drawing.Color.Black;
            this.TxtWordName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWordName.Enabled = false;
            this.TxtWordName.ForeColor = System.Drawing.Color.White;
            this.TxtWordName.Location = new System.Drawing.Point(84, 15);
            this.TxtWordName.Name = "TxtWordName";
            this.TxtWordName.PlaceholderText = "Word name here";
            this.TxtWordName.Size = new System.Drawing.Size(394, 23);
            this.TxtWordName.TabIndex = 2;
            // 
            // TxtArticleLink
            // 
            this.TxtArticleLink.BackColor = System.Drawing.Color.Black;
            this.TxtArticleLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtArticleLink.ForeColor = System.Drawing.Color.White;
            this.TxtArticleLink.Location = new System.Drawing.Point(84, 44);
            this.TxtArticleLink.Name = "TxtArticleLink";
            this.TxtArticleLink.PlaceholderText = "Article link here";
            this.TxtArticleLink.Size = new System.Drawing.Size(394, 23);
            this.TxtArticleLink.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Word name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Article link:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtArticleLink);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtWordName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 75);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDefinition);
            this.groupBox2.Controls.Add(this.ListDefinitions);
            this.groupBox2.Controls.Add(this.BtnRemoveDefinition);
            this.groupBox2.Controls.Add(this.BtnAddDefinition);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 193);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // TxtDefinition
            // 
            this.TxtDefinition.BackColor = System.Drawing.Color.Black;
            this.TxtDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDefinition.ForeColor = System.Drawing.Color.White;
            this.TxtDefinition.Location = new System.Drawing.Point(10, 18);
            this.TxtDefinition.Multiline = true;
            this.TxtDefinition.Name = "TxtDefinition";
            this.TxtDefinition.PlaceholderText = "Enter definition here";
            this.TxtDefinition.Size = new System.Drawing.Size(468, 23);
            this.TxtDefinition.TabIndex = 11;
            // 
            // ListDefinitions
            // 
            this.ListDefinitions.BackColor = System.Drawing.Color.Black;
            this.ListDefinitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListDefinitions.ForeColor = System.Drawing.Color.White;
            this.ListDefinitions.ItemHeight = 15;
            this.ListDefinitions.Location = new System.Drawing.Point(10, 47);
            this.ListDefinitions.Name = "ListDefinitions";
            this.ListDefinitions.Size = new System.Drawing.Size(468, 107);
            this.ListDefinitions.TabIndex = 10;
            // 
            // BtnRemoveDefinition
            // 
            this.BtnRemoveDefinition.BackColor = System.Drawing.Color.Black;
            this.BtnRemoveDefinition.Enabled = false;
            this.BtnRemoveDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveDefinition.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemoveDefinition.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveDefinition.Location = new System.Drawing.Point(403, 160);
            this.BtnRemoveDefinition.Name = "BtnRemoveDefinition";
            this.BtnRemoveDefinition.Size = new System.Drawing.Size(75, 25);
            this.BtnRemoveDefinition.TabIndex = 9;
            this.BtnRemoveDefinition.Text = "Remove";
            this.BtnRemoveDefinition.UseVisualStyleBackColor = true;
            this.BtnRemoveDefinition.Click += new System.EventHandler(this.BtnRemoveDefinition_Click);
            // 
            // BtnAddDefinition
            // 
            this.BtnAddDefinition.BackColor = System.Drawing.Color.Black;
            this.BtnAddDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddDefinition.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddDefinition.ForeColor = System.Drawing.Color.White;
            this.BtnAddDefinition.Location = new System.Drawing.Point(322, 160);
            this.BtnAddDefinition.Name = "BtnAddDefinition";
            this.BtnAddDefinition.Size = new System.Drawing.Size(75, 25);
            this.BtnAddDefinition.TabIndex = 8;
            this.BtnAddDefinition.Text = "Add entry";
            this.BtnAddDefinition.UseVisualStyleBackColor = true;
            this.BtnAddDefinition.Click += new System.EventHandler(this.BtnAddDefinition_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtReference);
            this.groupBox3.Controls.Add(this.ListReferences);
            this.groupBox3.Controls.Add(this.BtnRemoveReference);
            this.groupBox3.Controls.Add(this.BtnAddReference);
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 198);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // TxtReference
            // 
            this.TxtReference.BackColor = System.Drawing.Color.Black;
            this.TxtReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReference.ForeColor = System.Drawing.Color.White;
            this.TxtReference.Location = new System.Drawing.Point(10, 22);
            this.TxtReference.Multiline = true;
            this.TxtReference.Name = "TxtReference";
            this.TxtReference.PlaceholderText = "Enter reference here";
            this.TxtReference.Size = new System.Drawing.Size(209, 23);
            this.TxtReference.TabIndex = 15;
            // 
            // ListReferences
            // 
            this.ListReferences.BackColor = System.Drawing.Color.Black;
            this.ListReferences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListReferences.ForeColor = System.Drawing.Color.White;
            this.ListReferences.ItemHeight = 15;
            this.ListReferences.Location = new System.Drawing.Point(10, 51);
            this.ListReferences.Name = "ListReferences";
            this.ListReferences.Size = new System.Drawing.Size(209, 107);
            this.ListReferences.TabIndex = 14;
            // 
            // BtnRemoveReference
            // 
            this.BtnRemoveReference.BackColor = System.Drawing.Color.Black;
            this.BtnRemoveReference.Enabled = false;
            this.BtnRemoveReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveReference.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemoveReference.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveReference.Location = new System.Drawing.Point(144, 164);
            this.BtnRemoveReference.Name = "BtnRemoveReference";
            this.BtnRemoveReference.Size = new System.Drawing.Size(75, 25);
            this.BtnRemoveReference.TabIndex = 13;
            this.BtnRemoveReference.Text = "Remove";
            this.BtnRemoveReference.UseVisualStyleBackColor = false;
            this.BtnRemoveReference.Click += new System.EventHandler(this.BtnRemoveReference_Click);
            // 
            // BtnAddReference
            // 
            this.BtnAddReference.BackColor = System.Drawing.Color.Black;
            this.BtnAddReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddReference.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddReference.ForeColor = System.Drawing.Color.White;
            this.BtnAddReference.Location = new System.Drawing.Point(45, 164);
            this.BtnAddReference.Name = "BtnAddReference";
            this.BtnAddReference.Size = new System.Drawing.Size(93, 25);
            this.BtnAddReference.TabIndex = 12;
            this.BtnAddReference.Text = "Add reference";
            this.BtnAddReference.UseVisualStyleBackColor = false;
            this.BtnAddReference.Click += new System.EventHandler(this.BtnAddReference_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(250, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 187);
            this.label3.TabIndex = 17;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // EditWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(508, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditWordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editing entry: {wordName}";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtWordName;
        private System.Windows.Forms.TextBox TxtArticleLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDefinition;
        private System.Windows.Forms.ListBox ListDefinitions;
        private System.Windows.Forms.Button BtnRemoveDefinition;
        private System.Windows.Forms.Button BtnAddDefinition;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtReference;
        private System.Windows.Forms.ListBox ListReferences;
        private System.Windows.Forms.Button BtnRemoveReference;
        private System.Windows.Forms.Button BtnAddReference;
        private System.Windows.Forms.Label label3;
    }
}