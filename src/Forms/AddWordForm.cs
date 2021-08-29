using System;
using System.Windows.Forms;

namespace sozluk
{
    public partial class AddWordForm : Form
    {
        public Objects.Word ReturnedWord = null; // MainForm will access this field to retrieve entry from user
        
        private string Theme { get; }

        private string Language { get; }

        public AddWordForm(string theme, string langCode)
        {
            InitializeComponent();
            Theme = theme;
            Language = langCode;
        }

        #region Methods
        private void ApplyTheme()
        {
            throw new NotImplementedException();
        }

        private void ApplyLanguage()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string wordNameInput = TxtWordName.Text.Trim();
            string articleLinkIn = TxtArticleLink.Text.Trim();

            if (!string.IsNullOrWhiteSpace(wordNameInput) && ListDefinitions.Items.Count is not 0)
            {
                Objects.Word word = new(TxtWordName.Text);
                word.ArticleLink = string.IsNullOrWhiteSpace(articleLinkIn) ? null : articleLinkIn;
                word.WikipediaArticleLink = Model.GrabWikipediaLink(TxtWordName.Text);
                word.Definitions = new string[ListDefinitions.Items.Count];
                ListDefinitions.Items.CopyTo(word.Definitions, 0);
                if (ListReferences.Items.Count is not 0)
                {
                    word.References = new string[ListReferences.Items.Count];
                    ListReferences.Items.CopyTo(word.References, 0);
                }

                ReturnedWord = word;
                DialogResult = DialogResult.OK;
            }
        }

        private void BtnAddDefinition_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtDefinition.Text))
            {
                ListDefinitions.Items.Add(TxtDefinition.Text);
                TxtDefinition.Clear();
                BtnRemoveDefinition.Enabled = true;
            }
        }

        private void BtnRemoveDefinition_Click(object sender, EventArgs e)
        {
            if (ListDefinitions.SelectedIndex is not -1)
                ListDefinitions.Items.RemoveAt(ListDefinitions.SelectedIndex);

            if (ListDefinitions.Items.Count is 0)
                BtnRemoveDefinition.Enabled = false;
        }

        private void BtnAddReference_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtReference.Text))
            {
                ListReferences.Items.Add(TxtReference.Text);
                TxtReference.Clear();
                BtnRemoveReference.Enabled = true;
            }
        }

        private void BtnRemoveReference_Click(object sender, EventArgs e)
        {
            if (ListReferences.SelectedIndex is not -1)
                ListReferences.Items.RemoveAt(ListReferences.SelectedIndex);

            if (ListDefinitions.Items.Count is 0)
                BtnRemoveReference.Enabled = false;
        }
        #endregion
    }
}
