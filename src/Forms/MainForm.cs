using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sozluk
{
    public partial class MainForm : Form
    {
        private List<Objects.Word> Words;
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
            Model.ReadStorageFile(DictionaryFilePath, out string[] val, out Words);
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

        private void LabelUrl_Click(object sender, EventArgs e) => Model.LaunchUrl(LabelUrl.Text);

        private void LabelWiki_MouseClick(object sender, MouseEventArgs e) => Model.LaunchUrl(Model.GrabWikipediaLink(LabelWord.Text));

        private void PictureCancel_Click(object sender, EventArgs e) => SearchBox.Text = "";

        private void PictureAdd_Click(object sender, EventArgs e)
        {
            using (AddWordForm form = new(Theme, Language))
                if (form.ShowDialog() is DialogResult.OK)
                    if (!Words.Exists(x => x.Name == form.ReturnedWord.Name))
                        AddWord(form.ReturnedWord);
        }
        #endregion

        #region Methods
        private void PopulateWordList()
        {
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
            Text = langCode is "en" ? "Dictionary by ferityigitbalaban" : "Sözlük, ferityigitbalaban";
        }

        private void ApplyTheme(string theme = "black")
        {
            bool t = theme is "black";

            PictureCancel.Image = t ? Properties.Resources.cancelsearch_blacktheme : Properties.Resources.cancelsearch_whitetheme;
            PictureSearch.Image = t ? Properties.Resources.search_blacktheme : Properties.Resources.search_whitetheme;
        }

        private void AddReferences(string[] words)
        {
            PanelReferenceBox.Controls.Add(new Label() { Text = "See also", Font = new System.Drawing.Font("Segoe UI", 10f) });
            for (int i = 0; i < words.Length; i++)
            {
                Label reference = new() { Text = words[i], AutoSize = true };
                reference.Click += WordSelected;
                reference.MouseEnter += LabelMouseEnter;
                reference.MouseLeave += LabelMouseLeave;
                PanelReferenceBox.Controls.Add(reference);
            }
        }

        private void ShowWordDetails(string key)
        {
            if (key is not null or "")
            {
                PanelReferenceBox.Controls.Clear();

                Objects.Word currentWord = Words.Find(x => x.Name == key);
                LabelWord.Text = currentWord.Name;
                LabelWiki.Text = currentWord.WikipediaArticleLink is null ? "" : currentWord.WikipediaArticleLink;
                LabelUrl.Text = currentWord.ArticleLink is null ? "" : currentWord.ArticleLink;
                if (currentWord.References.Length is not 0)
                    AddReferences(currentWord.References.ToArray());
                string[] definitions = currentWord.Definitions.ToArray();
                if (definitions.Length is 1)
                    LabelDefinition.Text = $"1. {definitions[0]}";
                else
                {
                    StringBuilder builder = new();
                    for (int i = 0; i < definitions.Length; i++)
                        builder.AppendFormat("{0}. {1}\n", i + 1, definitions[i]);
                    LabelDefinition.Text = builder.ToString();
                }
            }
        }

        private void AddWord(Objects.Word word)
        {
            Words.Add(word);
            Model.AddEntry(word, DictionaryFilePath);
            PopulateWordList();
        }
        #endregion
    }
}