using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sozluk
{
    public partial class MainForm : Form
    {
        private SortedDictionary<string, string[]> Words;
        internal static string[] Settings;
        internal static string DictionaryFilePath = AppDomain.CurrentDomain.BaseDirectory + "dictionary.txt";
        internal readonly static string AppSettingFilePath = AppDomain.CurrentDomain.BaseDirectory + "dictionary.settings";

        public MainForm()
        {
            InitializeComponent();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Model.ReadSettingFile(AppSettingFilePath, out Settings))
                Close();
            ApplySettings();
            Model.ReadStorageFile(DictionaryFilePath, out string[] val, out Words);
            PopulateWordList();
            ShowWordDetails(Words.First().Key);
            PictureCancel.Visible = false;
        }

        private void PopulateWordList()
        {
            foreach (var item in Words)
            {
                WordList.Items.Add(item.Key);
            }

            WordList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            WordList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            SplitListBody.SplitterDistance = WordList.Columns[0].Width + SystemInformation.VerticalScrollBarWidth;

            LabelCount.Text = $"Loaded: {Words.Count} words";
        }

        private async void ShowWordDetails(string key)
        {
            if (key is not null or "")
            {
                PanelReferenceBox.Controls.Clear();
                LabelWord.Text = key;
                LabelUrl.Text = "";
                string[] definitions = Words[key];
                if (Words[key].Length is 1)
                    LabelDefinition.Text =  $"1. {Words[key][0]}";
                else
                {
                    var builder = new StringBuilder();
                    for (int i = 0; i < definitions.Length; i++)
                    {
                        if (definitions[i].StartsWith("<ref=") && definitions[i].EndsWith(">"))
                            WriteReference(definitions[i].Replace("<ref=", "").Replace(">", ""));
                        else if (!Model.IsUrl(definitions[i]))
                            builder.AppendFormat("{0}. {1}\n", i + 1, definitions[i]);
                        else
                            WriteUrl(definitions[i]);
                    }
                    LabelDefinition.Text = builder.ToString();
                }
                await Model.GrabWikipediaLink(key);
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
            string[] items = Words.Keys.Where(x => x.StartsWith(SearchBox.Text.Replace(" ", string.Empty).ToLower())).ToArray();
            WordList.Items.Clear();
            foreach (var item in items)
            {
                WordList.Items.Add(item);
            }

            PictureCancel.Visible = !string.IsNullOrWhiteSpace(SearchBox.Text?.Replace(" ", string.Empty));
        }

        private void PictureCancel_Click(object sender, EventArgs e) => SearchBox.Text = "";

        private void WriteUrl(string url) => LabelUrl.Text = url;

        private void WriteReference(string word)
        {
            PanelReferenceBox.Controls.Add(new Label() { Text = "See also", Font = new System.Drawing.Font("Segoe UI", 10f)});
            Label reference = new() { Text = word };
            reference.Click += WordSelected;
            reference.MouseEnter += LabelMouseEnter;
            reference.MouseLeave += LabelMouseLeave;
            PanelReferenceBox.Controls.Add(reference);
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

        private void LabelUrl_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("explorer", Model.ParseUrl(LabelUrl.Text));
    }
}