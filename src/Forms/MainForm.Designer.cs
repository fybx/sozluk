
namespace sozluk
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SplitListBody = new System.Windows.Forms.SplitContainer();
            this.WordList = new System.Windows.Forms.ListView();
            this.clm = new System.Windows.Forms.ColumnHeader();
            this.SplitMenuBarDefinition = new System.Windows.Forms.SplitContainer();
            this.PictureEdit = new System.Windows.Forms.PictureBox();
            this.PictureAdd = new System.Windows.Forms.PictureBox();
            this.LabelCount = new System.Windows.Forms.Label();
            this.PanelSearchBar = new System.Windows.Forms.Panel();
            this.PictureCancel = new System.Windows.Forms.PictureBox();
            this.SplitSearchBarImage = new System.Windows.Forms.SplitContainer();
            this.PictureSearch = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TableDefinitionReferences = new System.Windows.Forms.TableLayoutPanel();
            this.LabelDefinition = new System.Windows.Forms.Label();
            this.PanelReferenceBox = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelReferenceTitle = new System.Windows.Forms.Label();
            this.PanelTitleBox = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelWord = new System.Windows.Forms.Label();
            this.LabelWiki = new System.Windows.Forms.Label();
            this.@__Splitter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SplitListBody)).BeginInit();
            this.SplitListBody.Panel1.SuspendLayout();
            this.SplitListBody.Panel2.SuspendLayout();
            this.SplitListBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitMenuBarDefinition)).BeginInit();
            this.SplitMenuBarDefinition.Panel1.SuspendLayout();
            this.SplitMenuBarDefinition.Panel2.SuspendLayout();
            this.SplitMenuBarDefinition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdd)).BeginInit();
            this.PanelSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitSearchBarImage)).BeginInit();
            this.SplitSearchBarImage.Panel1.SuspendLayout();
            this.SplitSearchBarImage.Panel2.SuspendLayout();
            this.SplitSearchBarImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSearch)).BeginInit();
            this.TableDefinitionReferences.SuspendLayout();
            this.PanelReferenceBox.SuspendLayout();
            this.PanelTitleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitListBody
            // 
            this.SplitListBody.BackColor = System.Drawing.Color.Black;
            this.SplitListBody.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.SplitListBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitListBody.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitListBody.IsSplitterFixed = true;
            this.SplitListBody.Location = new System.Drawing.Point(0, 0);
            this.SplitListBody.Name = "SplitListBody";
            // 
            // SplitListBody.Panel1
            // 
            this.SplitListBody.Panel1.Controls.Add(this.WordList);
            // 
            // SplitListBody.Panel2
            // 
            this.SplitListBody.Panel2.Controls.Add(this.SplitMenuBarDefinition);
            this.SplitListBody.Size = new System.Drawing.Size(944, 501);
            this.SplitListBody.SplitterDistance = 250;
            this.SplitListBody.TabIndex = 0;
            // 
            // WordList
            // 
            this.WordList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.WordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.WordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm});
            this.WordList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordList.ForeColor = System.Drawing.Color.White;
            this.WordList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.WordList.HideSelection = false;
            this.WordList.LabelWrap = false;
            this.WordList.Location = new System.Drawing.Point(0, 0);
            this.WordList.MultiSelect = false;
            this.WordList.Name = "WordList";
            this.WordList.ShowGroups = false;
            this.WordList.Size = new System.Drawing.Size(250, 501);
            this.WordList.TabIndex = 0;
            this.WordList.UseCompatibleStateImageBehavior = false;
            this.WordList.View = System.Windows.Forms.View.Details;
            this.WordList.SelectedIndexChanged += new System.EventHandler(this.WordSelected);
            // 
            // clm
            // 
            this.clm.Text = "";
            this.clm.Width = 250;
            // 
            // SplitMenuBarDefinition
            // 
            this.SplitMenuBarDefinition.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.SplitMenuBarDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitMenuBarDefinition.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitMenuBarDefinition.IsSplitterFixed = true;
            this.SplitMenuBarDefinition.Location = new System.Drawing.Point(0, 0);
            this.SplitMenuBarDefinition.Name = "SplitMenuBarDefinition";
            this.SplitMenuBarDefinition.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitMenuBarDefinition.Panel1
            // 
            this.SplitMenuBarDefinition.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SplitMenuBarDefinition.Panel1.Controls.Add(this.PictureEdit);
            this.SplitMenuBarDefinition.Panel1.Controls.Add(this.PictureAdd);
            this.SplitMenuBarDefinition.Panel1.Controls.Add(this.LabelCount);
            this.SplitMenuBarDefinition.Panel1.Controls.Add(this.PanelSearchBar);
            this.SplitMenuBarDefinition.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // SplitMenuBarDefinition.Panel2
            // 
            this.SplitMenuBarDefinition.Panel2.Controls.Add(this.TableDefinitionReferences);
            this.SplitMenuBarDefinition.Panel2.Controls.Add(this.PanelTitleBox);
            this.SplitMenuBarDefinition.Panel2.Controls.Add(this.@__Splitter);
            this.SplitMenuBarDefinition.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SplitMenuBarDefinition.Size = new System.Drawing.Size(690, 501);
            this.SplitMenuBarDefinition.SplitterDistance = 38;
            this.SplitMenuBarDefinition.TabIndex = 0;
            // 
            // PictureEdit
            // 
            this.PictureEdit.Image = global::sozluk.Properties.Resources.editword_blacktheme;
            this.PictureEdit.Location = new System.Drawing.Point(424, 4);
            this.PictureEdit.Name = "PictureEdit";
            this.PictureEdit.Size = new System.Drawing.Size(30, 30);
            this.PictureEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureEdit.TabIndex = 5;
            this.PictureEdit.TabStop = false;
            this.PictureEdit.Click += new System.EventHandler(this.PictureEdit_Click);
            // 
            // PictureAdd
            // 
            this.PictureAdd.Image = global::sozluk.Properties.Resources.add_blacktheme;
            this.PictureAdd.Location = new System.Drawing.Point(388, 4);
            this.PictureAdd.Name = "PictureAdd";
            this.PictureAdd.Size = new System.Drawing.Size(30, 30);
            this.PictureAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureAdd.TabIndex = 4;
            this.PictureAdd.TabStop = false;
            this.PictureAdd.Click += new System.EventHandler(this.PictureAdd_Click);
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCount.Location = new System.Drawing.Point(551, 12);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(84, 20);
            this.LabelCount.TabIndex = 2;
            this.LabelCount.Text = "LabelCount";
            // 
            // PanelSearchBar
            // 
            this.PanelSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearchBar.Controls.Add(this.PictureCancel);
            this.PanelSearchBar.Controls.Add(this.SplitSearchBarImage);
            this.PanelSearchBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelSearchBar.ForeColor = System.Drawing.Color.DimGray;
            this.PanelSearchBar.Location = new System.Drawing.Point(3, 0);
            this.PanelSearchBar.Name = "PanelSearchBar";
            this.PanelSearchBar.Size = new System.Drawing.Size(379, 38);
            this.PanelSearchBar.TabIndex = 3;
            // 
            // PictureCancel
            // 
            this.PictureCancel.Location = new System.Drawing.Point(347, 6);
            this.PictureCancel.Name = "PictureCancel";
            this.PictureCancel.Size = new System.Drawing.Size(25, 25);
            this.PictureCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureCancel.TabIndex = 3;
            this.PictureCancel.TabStop = false;
            this.PictureCancel.Click += new System.EventHandler(this.PictureCancel_Click);
            // 
            // SplitSearchBarImage
            // 
            this.SplitSearchBarImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SplitSearchBarImage.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitSearchBarImage.IsSplitterFixed = true;
            this.SplitSearchBarImage.Location = new System.Drawing.Point(3, 3);
            this.SplitSearchBarImage.Name = "SplitSearchBarImage";
            // 
            // SplitSearchBarImage.Panel1
            // 
            this.SplitSearchBarImage.Panel1.Controls.Add(this.PictureSearch);
            // 
            // SplitSearchBarImage.Panel2
            // 
            this.SplitSearchBarImage.Panel2.Controls.Add(this.SearchBox);
            this.SplitSearchBarImage.Size = new System.Drawing.Size(340, 30);
            this.SplitSearchBarImage.SplitterDistance = 30;
            this.SplitSearchBarImage.TabIndex = 2;
            // 
            // PictureSearch
            // 
            this.PictureSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureSearch.Location = new System.Drawing.Point(0, 0);
            this.PictureSearch.Name = "PictureSearch";
            this.PictureSearch.Size = new System.Drawing.Size(30, 30);
            this.PictureSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureSearch.TabIndex = 0;
            this.PictureSearch.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.Location = new System.Drawing.Point(5, 3);
            this.SearchBox.MaxLength = 64;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Search for a word...";
            this.SearchBox.Size = new System.Drawing.Size(298, 22);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // TableDefinitionReferences
            // 
            this.TableDefinitionReferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableDefinitionReferences.AutoSize = true;
            this.TableDefinitionReferences.BackColor = System.Drawing.Color.Transparent;
            this.TableDefinitionReferences.ColumnCount = 1;
            this.TableDefinitionReferences.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableDefinitionReferences.Controls.Add(this.LabelDefinition, 0, 0);
            this.TableDefinitionReferences.Controls.Add(this.PanelReferenceBox, 0, 1);
            this.TableDefinitionReferences.Location = new System.Drawing.Point(27, 66);
            this.TableDefinitionReferences.Name = "TableDefinitionReferences";
            this.TableDefinitionReferences.RowCount = 2;
            this.TableDefinitionReferences.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableDefinitionReferences.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TableDefinitionReferences.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableDefinitionReferences.Size = new System.Drawing.Size(630, 381);
            this.TableDefinitionReferences.TabIndex = 5;
            // 
            // LabelDefinition
            // 
            this.LabelDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDefinition.AutoEllipsis = true;
            this.LabelDefinition.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LabelDefinition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDefinition.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.LabelDefinition.Location = new System.Drawing.Point(3, 0);
            this.LabelDefinition.Name = "LabelDefinition";
            this.LabelDefinition.Size = new System.Drawing.Size(624, 251);
            this.LabelDefinition.TabIndex = 1;
            this.LabelDefinition.Text = "<Definition>";
            // 
            // PanelReferenceBox
            // 
            this.PanelReferenceBox.BackColor = System.Drawing.Color.Transparent;
            this.PanelReferenceBox.Controls.Add(this.LabelReferenceTitle);
            this.PanelReferenceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelReferenceBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelReferenceBox.Location = new System.Drawing.Point(3, 254);
            this.PanelReferenceBox.Name = "PanelReferenceBox";
            this.PanelReferenceBox.Size = new System.Drawing.Size(624, 124);
            this.PanelReferenceBox.TabIndex = 2;
            // 
            // LabelReferenceTitle
            // 
            this.LabelReferenceTitle.AutoSize = true;
            this.LabelReferenceTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelReferenceTitle.Location = new System.Drawing.Point(3, 0);
            this.LabelReferenceTitle.Name = "LabelReferenceTitle";
            this.LabelReferenceTitle.Size = new System.Drawing.Size(77, 17);
            this.LabelReferenceTitle.TabIndex = 0;
            this.LabelReferenceTitle.Text = "Read more:";
            // 
            // PanelTitleBox
            // 
            this.PanelTitleBox.Controls.Add(this.LabelWord);
            this.PanelTitleBox.Controls.Add(this.LabelWiki);
            this.PanelTitleBox.Location = new System.Drawing.Point(7, 14);
            this.PanelTitleBox.Name = "PanelTitleBox";
            this.PanelTitleBox.Size = new System.Drawing.Size(650, 27);
            this.PanelTitleBox.TabIndex = 4;
            // 
            // LabelWord
            // 
            this.LabelWord.AutoSize = true;
            this.LabelWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LabelWord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelWord.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.LabelWord.Location = new System.Drawing.Point(3, 0);
            this.LabelWord.Name = "LabelWord";
            this.LabelWord.Size = new System.Drawing.Size(88, 25);
            this.LabelWord.TabIndex = 0;
            this.LabelWord.Text = "<Word>";
            // 
            // LabelWiki
            // 
            this.LabelWiki.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelWiki.AutoSize = true;
            this.LabelWiki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelWiki.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelWiki.ForeColor = System.Drawing.Color.DarkGray;
            this.LabelWiki.Location = new System.Drawing.Point(97, 8);
            this.LabelWiki.Name = "LabelWiki";
            this.LabelWiki.Size = new System.Drawing.Size(107, 17);
            this.LabelWiki.TabIndex = 4;
            this.LabelWiki.Text = "Wikipedia article";
            this.LabelWiki.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelWiki.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelWiki_MouseClick);
            this.LabelWiki.MouseEnter += new System.EventHandler(this.LabelMouseEnter);
            this.LabelWiki.MouseLeave += new System.EventHandler(this.LabelMouseLeave);
            // 
            // __Splitter
            // 
            this.@__Splitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.@__Splitter.AutoSize = true;
            this.@__Splitter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.@__Splitter.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.@__Splitter.Location = new System.Drawing.Point(7, 43);
            this.@__Splitter.Name = "__Splitter";
            this.@__Splitter.Size = new System.Drawing.Size(650, 1);
            this.@__Splitter.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.SplitListBody);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.SplitListBody.Panel1.ResumeLayout(false);
            this.SplitListBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitListBody)).EndInit();
            this.SplitListBody.ResumeLayout(false);
            this.SplitMenuBarDefinition.Panel1.ResumeLayout(false);
            this.SplitMenuBarDefinition.Panel1.PerformLayout();
            this.SplitMenuBarDefinition.Panel2.ResumeLayout(false);
            this.SplitMenuBarDefinition.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitMenuBarDefinition)).EndInit();
            this.SplitMenuBarDefinition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdd)).EndInit();
            this.PanelSearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureCancel)).EndInit();
            this.SplitSearchBarImage.Panel1.ResumeLayout(false);
            this.SplitSearchBarImage.Panel2.ResumeLayout(false);
            this.SplitSearchBarImage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitSearchBarImage)).EndInit();
            this.SplitSearchBarImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureSearch)).EndInit();
            this.TableDefinitionReferences.ResumeLayout(false);
            this.PanelReferenceBox.ResumeLayout(false);
            this.PanelReferenceBox.PerformLayout();
            this.PanelTitleBox.ResumeLayout(false);
            this.PanelTitleBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitListBody;
        private System.Windows.Forms.ListView WordList;
        private System.Windows.Forms.Label LabelWord;
        private System.Windows.Forms.SplitContainer SplitMenuBarDefinition;
        private System.Windows.Forms.SplitContainer SplitSearchBarImage;
        private System.Windows.Forms.PictureBox PictureSearch;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel PanelSearchBar;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.PictureBox PictureCancel;
        private System.Windows.Forms.Panel __Splitter;
        private System.Windows.Forms.ColumnHeader clm;
        private System.Windows.Forms.Label LabelDefinition;
        private System.Windows.Forms.FlowLayoutPanel PanelTitleBox;
        private System.Windows.Forms.TableLayoutPanel TableDefinitionReferences;
        private System.Windows.Forms.FlowLayoutPanel PanelReferenceBox;
        private System.Windows.Forms.Label LabelReferenceTitle;
        private System.Windows.Forms.Label LabelWiki;
        private System.Windows.Forms.PictureBox PictureAdd;
        private System.Windows.Forms.PictureBox PictureEdit;
    }
}

