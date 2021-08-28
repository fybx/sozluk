using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozluk
{
    internal static class Model
    {
        private const string StorageFileComment = "# dictionary application // ferityigitbalaban 2021\n" +
            "# dictionary file\n" +
            "#\n" +
            "# WARNING: DO NOT USE \'#\' in WORD ENTRIES!\n" +
            "# Any line containing \'#\' will be treated as a comment and will be ignored.\n" +
            "#\n" +
            "# Referencing different words in definitions: Define a word as usual, enter as many definitions as you like\n" +
            "# Add \"<ref=word_here>\" block to definitions, change \'word_here\' with your word\n" +
            "# Application will automatically handle this entry and show a link to referenced word\n" +
            "#\n" +
            "# Adding article URLs: Only one URL link can be added per word.\n" +
            "# Place your URL link in quotes as you would enter definitions. Application uses a Regex condition to find and match URL links.\n" +
            "# Link will be shown near word label if found.\n" +
            "#\n" +
            "# Next line starting with $ sign specifies words\' and definitions\' language";

        #region Storage/Dictionary File
        /// <summary>
        /// Creates a dictonary file and saves to disk. Only to be called when it's first launch.
        /// </summary>
        internal static void CreateStorageFile()
        {
            string[] lines = new string[]
            {
                "# dictionary application // ferityigitbalaban 2021",
                "# dictionary file",
                "#",
                "# WARNING: DO NOT USE '#' in WORD ENTRIES!",
                "# Any line containing '#' will be treated as a comment and will be ignored.",
                "#",
                "# Next line starting with $ sign specifies words' and definitions' language",
                "$ key to value: en => tr",
                "#",
                "# Referencing different words in definitions: Define a word as usual, enter as many definitions as you like",
                "# Add \"<ref=word_here>\" block to definitions, change 'word_here' with your word",
                "# Application will automatically handle this entry and show a link to referenced word",
                "#",
                "# Adding article URLs: Only one URL link can be added per word.",
                "# Place your URL link in quotes as you would enter definitions. Application uses a Regex condition to find and match URL links.",
                "# Link will be shown near word label if found.",
                "#",
                "# Default dictionary file (this) is named dictionary.txt",
                "# Dictionary file used by application can be changed by editing dictionary.settings",
                "#",
                "\"your library is empty\": \"Add words using this application or manually by editing dictionary.txt file in base directory.\" \"You can also use a different dictionary file. To use another file, edit dictionary.settings file in base directory.\"",
                "\"fastidious\": \"müşkülpesent\""
            };
            File.WriteAllLines(MainForm.DictionaryFilePath, lines);
        }

        /// <summary>
        /// Opens and reads word storage file, outputs words in a SortedDictionary collection.
        /// </summary>
        /// <param name="filePath">Path to dictionary file</param>
        /// <param name="entries">Entries built from dictionary file</param>
        /// <returns>Returns <c>true</c> if successfully executed.</returns>
        internal static void ReadStorageFile(string filePath, out string[] keyValueLanguage, out SortedDictionary<string, string[]> entries) // TODO: improve performance
        {
            keyValueLanguage = new string[2];
            entries = new SortedDictionary<string, string[]>();

            if (!File.Exists(filePath))
                CreateStorageFile();

            try
            {
                string[] lines = File.ReadAllLines(filePath).Where(x => !x.Contains("#")).ToArray();
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("$ key to value: "))
                        keyValueLanguage = lines[i].Replace("$ key to value: ", string.Empty).Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                    else
                    {
                        string[] keyAndValue = Tokenize(lines[i]);
                        entries.Add(keyAndValue[0], keyAndValue.Skip(1).ToArray());
                    }
                }
            }
            catch (Exception e)
            {
                ShowErrorMessage($"An {e.GetType().Name} error has occured while reading dictionary file. Please check error log for more details. \"{WriteErrorLog(e)}\"");
            }
        }

        /// <summary>
        /// Saves supplied SortedDictionary to dictionary file at supplied path.
        /// </summary>
        /// <param name="filePath">Path to dictionary file.</param>
        /// <param name="entries">Dictionary file to save</param>
        /// <returns>Returns <c>true</c> if successfully executed.</returns>
        internal static bool SaveStorageFile(string filePath, SortedDictionary<string, string> entries)
        {
            try
            {
                // build string lines from SortedDictionary in <"key": { "value0", "value1", "value2" }> format, quotes included in string
                string[] lines = new string[entries.Count + 1];
                for (int i = 0; i < lines.Length; i++)
                {
                    string value = "";
                    for (int j = 0; j < entries.ElementAt(i).Value.Length; j++)
                    {
                        value += $"\"{entries.ElementAt(i).Value[j]}\"";
                    }
                    lines[i] = string.Format("\"{0}\": \"{1}\"", entries.ElementAt(i), value);
                }
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception e)
            {
                ShowErrorMessage($"An {e.GetType().Name} error has occured while saving dictionary file. Please check error log for more details. \"{WriteErrorLog(e)}\"");
                return false;
            }
            return true;
        }
        #endregion

        #region Settings File
        /// <summary>
        /// Creates a settings array and saves to disk using SaveSettingFile() method. Only to be called when it's first launch or user resets the settings.
        /// </summary>
        internal static void CreateSettingFile()
        {
            string[] settings = new string[]
            {
            "# dictionary settings // ferityigitbalaban 2021",
            "# comment line",
            "theme: black",
            "# enter full path to use a different file for dictionary. default is base directory, enter base to use the default file.",
            "dicpath: base",
            "lang: en",
            "#please do not change keys (left side of colon)"
            };

            SaveSettingFile(MainForm.AppSettingFilePath, settings);
        }

        /// <summary>
        /// Opens and reads a settings file and outputs a settings array
        /// </summary>
        /// <param name="filePath">File path to settings file</param>
        /// <param name="settings">Settings stored in array</param>
        /// <returns></returns>
        internal static bool ReadSettingFile(string filePath, out string[] settings)
        {
            if (!File.Exists(filePath))
                CreateSettingFile();

            settings = null;
            try
            {
                settings = File.ReadAllLines(filePath).ToList().Where(x => !x.Contains("#")).ToArray();
            }
            catch (Exception e)
            {
                ShowErrorMessage($"An {e.GetType().Name} error has occured while reading application settings file. Please check error log for more details. \"{WriteErrorLog(e)}\"");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Saves settings array to disk
        /// </summary>
        /// <param name="filePath">File path to settings file</param>
        /// <param name="settings">Settings stored in array</param>
        internal static void SaveSettingFile(string filePath, string[] settings)
        {
            try
            {
                File.WriteAllLines(MainForm.AppSettingFilePath, settings);
            }
            catch (Exception e)
            {
                ShowErrorMessage($"An {e.GetType().Name} error has occured while saving application settings file. Please check error log for more details. \"{WriteErrorLog(e)}\"");
            }
        }
        #endregion

        #region Error Handling
        /// <summary>
        /// Shows a MessageBox with supplied message and terminates program.
        /// </summary>
        /// <param name="message">Message to show in MessageBox body</param>
        internal static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message is not null && message.Replace(" ", "") is not "" ? message : "No message supplied", "Error");
            Environment.Exit(1);
        }

        /// <summary>
        /// Extracts useful parts of supplied exception, parses a paragraph and writes to a file.
        /// </summary>
        /// <param name="e">Exception</param>
        /// <returns>Returns path of saved log file.</returns>
        internal static string WriteErrorLog(Exception e)
        {
            string logpath = AppDomain.CurrentDomain.BaseDirectory + "errorlog_" + DateTime.Now.ToString("d-HH.mm.fff") + ".txt";

            string[] logtext = new string[]
            {
            "Message: " + e.Message,
            "Source: " + e.Source,
            "\nStack trace: " + e.StackTrace,
            "TargetSite.Name: " + e.TargetSite.Name,
            };

            File.WriteAllLinesAsync(logpath, logtext);
            return logpath;
        }
        #endregion

        /// <summary>
        /// Selects words seperated by colons in string, treats bodies wrapped in quotes as whole word. 
        /// Example: <code>Tokenize("setting_key": "setting:value") => array { "setting_key", "setting:value" }</code>  
        /// </summary>
        /// <param name="text">Text to tokenize</param>
        /// <returns></returns>
        internal static string[] Tokenize(string text, char wrapper = '"', char delimiter = ':')
        {
            return text.Split(wrapper)
            .Select((element, index) => index % 2 == 0
            ? element.Split(delimiter, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            : new string[] { element.Trim() })
            .SelectMany(element => element).Where(x => x.Replace(" ", "") is not "").ToArray();
        }

        /// <summary>
        /// This regular expression matches all variants of URLs
        /// </summary>
        internal readonly static Regex UrlRegex = new(@"([\w+]+\:\/\/)?([\w\d-]+\.)[\w-]+[\.\:]\w+([\/\?\=\&\#.]?[\w-]+)\/?", RegexOptions.Compiled | RegexOptions.CultureInvariant);
        
        /// <summary>
        /// Returns true if specified string contains an URL, otherwise false
        /// </summary>
        /// <param name="text">Specify a text</param>
        /// <returns></returns>
        internal static bool IsUrl(string text) => UrlRegex.IsMatch(text);

        /// <summary>
        /// Adds "www" and "https" if specified string doesn't contain them
        /// </summary>
        /// <param name="url">Specify an URL</param>
        /// <returns></returns>
        internal static string ParseUrl(string url)
        {
            if (!url.Contains("www"))
                url = "www." + url;
            if (!url.Contains("https"))
                url = @"https://" + url;
            return url;
        }

        /// <summary>
        /// Trys to get Wikipedia article link from specified word name
        /// </summary>
        /// <param name="wordName">Specify a word to find article of</param>
        /// <returns>Returns the link</returns>
        internal static async Task<string> GrabWikipediaLink(string wordName)
        {
            UriBuilder builder = new()
            {
                Scheme = "https://",
                Host = "en.wikipedia.org",
                Path = "/w/api.php",
                Query = $"action=opensearch&search={wordName}&limit=1&profile=normal&redirects=return"
            };
            Uri request = new(builder.ToString());

            using (HttpClient c = new())
                try { return UrlRegex.Match(await c.GetStringAsync(request)).ToString(); } catch (Exception) { return null; }
        }
    }
}