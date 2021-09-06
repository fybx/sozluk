using System;
using System.Windows.Forms;

namespace sozluk
{
    public partial class EditWordForm : Form
    {
        public Objects.Word ReturnedWord = null; // MainForm will access this field to retrieve entry from user
        
        private string Theme { get; }

        private string Language { get; }

        public EditWordForm(Objects.Word word, string theme, string langCode)
        {
            InitializeComponent();
            Theme = theme;
            Language = langCode;
            Text = $"Editing entry: {word.Name}";
            TxtWordName.Text = word.Name;
            ListArticles.Items.AddRange(word.ArticleLinks);
            ListDefinitions.Items.AddRange(word.Definitions);
            ListReferences.Items.AddRange(word.References);
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
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string wordNameInput = TxtWordName.Text.Trim();

            if (ListDefinitions.Items.Count is not 0)
            {
                Objects.Word word = new(wordNameInput);
                word.WikipediaArticleLink = Model.GrabWikipediaLink(wordNameInput);
                word.Definitions = new string[ListDefinitions.Items.Count];
                ListDefinitions.Items.CopyTo(word.Definitions, 0);
                if (ListReferences.Items.Count is not 0)
                {
                    word.References = new string[ListReferences.Items.Count];
                    ListReferences.Items.CopyTo(word.References, 0);
                }
                if (ListArticles.Items.Count is not 0)
                {
                    word.ArticleLinks = new string[ListArticles.Items.Count];
                    ListArticles.Items.CopyTo(word.ArticleLinks, 0);
                }

                ReturnedWord = word;
                DialogResult = DialogResult.OK;
            }
        }

        private void BtnAddDefinition_Click(object sender, EventArgs e)
        {
            string definitionInput = TxtDefinition.Text.Trim();
            if (!string.IsNullOrWhiteSpace(definitionInput))
            {
                ListDefinitions.Items.Add(definitionInput);
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
            string referenceInput = TxtReference.Text.Trim();
            if (!string.IsNullOrWhiteSpace(referenceInput))
            {
                ListReferences.Items.Add(referenceInput);
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