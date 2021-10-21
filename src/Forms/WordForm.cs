using System;
using System.Windows.Forms;

namespace sozluk
{
    public partial class WordForm : Form
    {
        public Objects.Word ReturnedWord = null; // MainForm will access this field to retrieve entry from user
        
        private string Theme { get; }

        private string Language { get; }

        /// <summary>
        /// Create an instance of WordForm for adding a word to dictionary
        /// </summary>
        /// <param name="theme">Application-wide theme code</param>
        /// <param name="langCode">Application-wide language code</param>
        public WordForm(string theme, string langCode)
        {
            InitializeComponent();
            Theme = theme;
            Language = langCode;
            Text = "Add a word to dictionary";
            BtnAdd.Text = "Add word";
            label3.Text = Properties.Resources.WordForm_AddHelper;
        }

        /// <summary>
        /// Create an instance of WordForm for editing an existing word entry
        /// </summary>
        /// <param name="word">Word object to be edited</param>
        /// <param name="theme">Application-wide theme code</param>
        /// <param name="langCode">Application-wide language code</param>
        public WordForm(Objects.Word word, string theme, string langCode)
        {
            InitializeComponent();
            Theme = theme;
            Language = langCode;
            Text = string.Format("Editing word: {0}", word.Name);
            BtnAdd.Text = "Save word";
            label3.Text = Properties.Resources.WordForn_EditHelper;
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

        private void AddWord()
        {
            string wordNameInput = TxtWordName.Text.Trim();

            if (!string.IsNullOrWhiteSpace(wordNameInput) && ListDefinitions.Items.Count is not 0)
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
            else
                MessageBox.Show("Word name box and definitions list cannot be empty.", "Warning!");
        }

        private void SaveContents()
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
            else
                MessageBox.Show("Word name box and definitions list cannot be empty.", "Warning!");
        }
        #endregion

        #region Events
        private void BtnFinalize_Click(object sender, EventArgs e)
        {
            switch (BtnAdd.Text[0])
            {
                case 'A':
                    AddWord();
                    break;
                case 'E':
                    SaveContents();
                    break;
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

        private void BtnAddArticle_Click(object sender, EventArgs e)
        {
            string articleInput = TxtArticle.Text.Trim();
            if (!string.IsNullOrWhiteSpace(articleInput))
            {
                ListArticles.Items.Add(articleInput);
                TxtArticle.Clear();
                BtnRemoveArticle.Enabled = true;
            }
        }

        private void BtnRemoveArticle_Click(object sender, EventArgs e)
        {
            if (ListArticles.SelectedIndex is not -1)
                ListArticles.Items.RemoveAt(ListArticles.SelectedIndex);

            if (ListArticles.Items.Count is 0)
                BtnRemoveReference.Enabled = false;
        }
        #endregion
    }
}