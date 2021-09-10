using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace sozluk
{
    public partial class MainForm : Form
    {
        private List<Objects.Word> Words;
        private Objects.Word CurrentWord;
        private string Theme;
        private string Language;

        internal static string[] Settings;
        internal static string DictionaryFilePath = AppDomain.CurrentDomain.BaseDirectory + "dictionary.txt";
        internal readonly static string AppSettingFilePath = AppDomain.CurrentDomain.BaseDirectory + "dictionary.settings";

        public MainForm() => InitializeComponent();

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Model.ReadSettingFile(AppSettingFilePath, out Settings))
                Close();
            ApplySettings();
            Model.ReadStorageFile(DictionaryFilePath, out _, out Words);
            PopulateWordList();
            ShowWordDetails(Words.First().Name);
            PictureCancel.Visible = false;
        }

        private void WordSelected(object sender, EventArgs e)
        {
            if (sender == WordList)
            {
                if (WordList.SelectedItems is not null && WordList.SelectedItems.Count > 0 && WordList.SelectedItems[0] is not null)
                    ShowWordDetails(WordList.SelectedItems[0].Text);
            }
            else
            {
                Label lbl = (Label)sender;
                ShowWordDetails(lbl.Text);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //if (WindowState is FormWindowState.Maximized)
            //    splitContainer.SplitterDistance = WordList.Columns[0].Width = 300;
            //else if (WindowState is FormWindowState.Normal)
            //    splitContainer.SplitterDistance = WordList.Columns[0].Width = 250;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Objects.Word[] items = Words.Where(x => x.Name.StartsWith(SearchBox.Text.Replace(" ", string.Empty).ToLower())).ToArray();
            WordList.Items.Clear();
            foreach (var item in items)
                WordList.Items.Add(item.Name);

            PictureCancel.Visible = !string.IsNullOrWhiteSpace(SearchBox.Text?.Replace(" ", string.Empty));
        }

        private void LabelMouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = System.Drawing.Color.Cyan;
        }

        private void LabelMouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = System.Drawing.Color.DarkGray;
        }

        private void LabelWiki_MouseClick(object sender, MouseEventArgs e) => Model.LaunchUrl(CurrentWord.WikipediaArticleLink);

        private void PictureCancel_Click(object sender, EventArgs e) => SearchBox.Text = "";

        private void PictureAdd_Click(object sender, EventArgs e)
        {
            using (AddWordForm form = new(Theme, Language))
                if (form.ShowDialog() is DialogResult.OK && !Words.Exists(x => x.Name == form.ReturnedWord.Name))
                    AddWord(form.ReturnedWord);
        }

        private void PictureEdit_Click(object sender, EventArgs e)
        {
            using (EditWordForm form = new(CurrentWord, Theme, Language))
                if (form.ShowDialog() is DialogResult.OK)
                    EditWord(form.ReturnedWord);
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
            Controls.LinkLabel label = (Controls.LinkLabel)sender;
            if (label.LabelType is sozluk.Controls.LinkLabelType.WordReference)
                ShowWordDetails(label.Link);
            else
                Model.LaunchUrl(label.Link);
        }
        #endregion

        #region Methods
        private void PopulateWordList()
        {
            var orderQuery = from word in Words orderby word.Name ascending select word;
            Words = orderQuery.ToList();

            if (WordList.Items.Count is not 0)
                WordList.Items.Clear();

            foreach (var item in Words)
            {
                WordList.Items.Add(item.Name);
            }

            WordList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            WordList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            SplitListBody.SplitterDistance = WordList.Columns[0].Width + SystemInformation.VerticalScrollBarWidth;

            LabelCount.Text = $"Loaded: {Words.Count} words";
        }

        private void ApplySettings()
        {
            foreach (var item in Settings)
            {
                string key = Model.Tokenize(item)[0];
                string value = Model.Tokenize(item)[1];

                switch (key)
                {
                    case "lang":
                        ApplyLanguage(value);
                        break;
                    case "dicpath":
                        DictionaryFilePath = value is "base" ? AppDomain.CurrentDomain.BaseDirectory + "dictionary.txt" : value;
                        break;
                    case "theme":
                        ApplyTheme(value);
                        break;
                    default:
                        Model.ShowErrorMessage($"Dictionary application settings file contains a invalid setting key '{key}'! Please remove this entry to fix this issue.");
                        break;
                }
            }
        }

        private void ApplyLanguage(string langCode = "en")
        {
            Language = langCode;
            Text = langCode is "en" ? "Dictionary by ferityigitbalaban" : "Sözlük, ferityigitbalaban";
        }

        private void ApplyTheme(string theme = "black")
        {
            Theme = theme;
            bool t = theme is "black";

            PictureCancel.Image = t ? Properties.Resources.cancelsearch_blacktheme : Properties.Resources.cancelsearch_whitetheme;
            PictureSearch.Image = t ? Properties.Resources.search_blacktheme : Properties.Resources.search_whitetheme;
        }

        private void AddReferences(string[] words, string[] articles)
        {
            if (words.Length is not 0 || articles.Length is not 0)
                PanelReferenceBox.Controls.Add(new Label() { Text = "Read more", Font = new System.Drawing.Font("Segoe UI", 10f) });

            for (int i = 0; i < words.Length; i++)
            {
                Controls.LinkLabel reference = new(Theme, words[i], words[i], sozluk.Controls.LinkLabelType.WordReference, 5);
                reference.Click += LinkLabel_Click;
                PanelReferenceBox.Controls.Add(reference);
            }
            for (int i = 0; i < articles.Length; i++)
            {
                Controls.LinkLabel link = new(Theme, articles[i], articles[i], sozluk.Controls.LinkLabelType.Article, 5);
                link.Click += LinkLabel_Click;
                PanelReferenceBox.Controls.Add(link);
            }
        }

        private void ShowWordDetails(string key)
        {
            if (key is not null or "")
            {
                PanelReferenceBox.Controls.Clear();

                CurrentWord = Words.Find(x => x.Name == key);
                LabelWord.Text = CurrentWord.Name;
                   
                AddReferences(CurrentWord.References, CurrentWord.ArticleLinks);
                string[] definitions = CurrentWord.Definitions.ToArray();
                if (definitions.Length is 1)
                    LabelDefinition.Text = $"1. {definitions[0]}";
                else
                {
                    StringBuilder builder = new();
                    for (int i = 0; i < definitions.Length; i++)
                        builder.AppendFormat("{0}. {1}\n", i + 1, definitions[i]);
                    LabelDefinition.Text = builder.ToString();
                }

                Thread t = new(new ParameterizedThreadStart(GetWikiLink));
                t.Start(CurrentWord);
            }
        }

        private static void GetWikiLink(object wordObj)
        {
            Objects.Word word = (Objects.Word)wordObj;
            Objects.Word before = word;
            if (string.IsNullOrEmpty(word.WikipediaArticleLink))
            {
                word.WikipediaArticleLink = Model.GrabWikipediaLink(word.Name);
                Model.EditEntry(before, word, DictionaryFilePath);
            }
        }

        private void AddWord(Objects.Word word)
        {
            Words.Add(word);
            Model.AddEntry(word, DictionaryFilePath);
            PopulateWordList();
            ShowWordDetails(word.Name);
        }

        private void EditWord(Objects.Word word)
        {
            Words.Remove(CurrentWord);
            Words.Add(word);
            Model.EditEntry(CurrentWord, word, DictionaryFilePath);
            PopulateWordList();
            ShowWordDetails(word.Name);
        }
        #endregion
    }
}