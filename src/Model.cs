using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

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
            "# WARNING: ALWAYS LEAVE LAST LINE EMPTY\n" +
            "# Application appends new entries but doesn't check for newline.\n" +
            "#\n" +
            "# Adding article URLs: Only one URL link can be added per word.\n" +
            "# Place your URL link in quotes as you would enter definitions. Application uses a Regex condition to find and match URL links.\n" +
            "# Link will be shown near word label if found.\n" +
            "#\n" +
            "# Default dictionary file (this) is named dictionary.txt" +
            "# Dictionary file used by application can be changed by editing dictionary.settings";

        #region Storage/Dictionary File
        /// <summary>
        /// Creates a dictonary file and saves to disk. Only to be called when it's first launch.
        /// </summary>
        internal static void CreateStorageFile()
        {
            string[] lines = new string[]
            {
                StorageFileComment,
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
        internal static void ReadStorageFile(string filePath, out string[] keyValueLanguage, out List<Objects.Word> dictionary) 
        {
            keyValueLanguage = new string[2];
            dictionary = new List<Objects.Word>();

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
                        dictionary.Add(new Objects.Word(lines[i]));
                    }
                }
            }
            catch (Exception e)
            {
                ShowErrorMessage($"An {e.GetType().Name} error has occured while reading dictionary file. Please check error log for more details. \"{WriteErrorLog(e)}\"");
            }
        }

        internal static void AddEntry(Objects.Word word, string filePath) => File.AppendAllText(filePath, File.ReadAllText(filePath).Last() == Environment.NewLine.Last() ? $"{word}" : $"\n{word}");

        internal static void RemoveEntry(string word, string filePath) => File.WriteAllLines(filePath, File.ReadLines(filePath).Where(x => !x.StartsWith($"\"{word}\"")).ToList());
        
        internal static void EditEntry(Objects.Word oldEntry, Objects.Word newEntry, string filePath)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            int lineToEdit = lines.FindIndex(x => x.StartsWith($"\"{oldEntry.Name}\""));
            lines[lineToEdit] = newEntry.ToString();
            File.WriteAllLines(filePath, lines);
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
            "# choose a different search algorithm to make application better suit your needs.",
            "# available methods are \"findcontaining\" and \"findstarting\" the default is \"findstarting\"",
            "searchmethod: findstarting",
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
                settings = File.ReadAllLines(filePath).AsEnumerable().Where(x => !x.Contains("#")).ToArray();
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
                File.WriteAllLines(filePath, settings);
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
        /// Trys to get Wikipedia article link from specified word name
        /// </summary>
        /// <param name="wordName">Specify a word to find article of</param>
        /// <returns>Returns the link</returns>
        internal static string GrabWikipediaLink(string wordName)
        {
            if (CheckForInternetConnection() is true)
            {
                UriBuilder builder = new()
                {
                    Scheme = "https://",
                    Host = "en.wikipedia.org",
                    Path = "/w/api.php",
                    Query = $"action=opensearch&search={wordName}&limit=1&profile=normal&redirects=return&format=xml"
                };
                Uri request = new(builder.ToString());

                using (HttpClient c = new())
                    try { return XElement.Parse(c.GetStringAsync(request).Result).Descendants().ElementAt(4).Value; } catch (Exception) { return null; }
            }
            return null;
        }

        internal static void AddLinkToDictionary(Objects.Word word, string link)
        {
            Objects.Word nW = new(word);
            nW.WikipediaArticleLink = link;
            EditEntry(word, nW, MainForm.DictionaryFilePath);
        }

        internal static void LaunchUrl(string url)
        {
            url = url.StartsWith("http") is false ? "http://" + url : url;
            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    Process.Start(new ProcessStartInfo(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\explorer.exe", url.Replace("&", "^&")) { CreateNoWindow = true });
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    Process.Start("xdg-open", url);
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    Process.Start("open", url);
            }
            catch (Exception e) 
            {
                ShowErrorMessage($"An {e.GetType().Name} error has occured while launching url! Please check error log for more details. \"{WriteErrorLog(e)}\"");
            }
        }

        private static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                    using (var stream = client.OpenRead("https://www.google.com"))
                        return true;
            }
            catch
            {
                return false;
            }
        }
    }
}