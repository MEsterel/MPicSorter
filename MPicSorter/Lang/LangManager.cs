using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace MPicSorter.Lang
{
    public static class LangManager
    {
        private const string _langNamespace = "MPicSorter.Lang";

        private static Assembly _thisAssembly = Assembly.GetExecutingAssembly();

        /// <summary>
        /// Key : lang tag; Value: lang file name.
        /// </summary>
        private static Dictionary<string, string> LangFileNames = new Dictionary<string, string>();

        private static ResourceManager myManager;

        private static TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        static LangManager()
        {
            // Use reflection to load all of the classes in the Commands namespace:
            var q = from t in _thisAssembly.GetManifestResourceNames()
                    where t.Contains("Lang-")
                    select t;
            var langFileNames = q.ToList();

            foreach (var langFileName in langFileNames)
            {
                string key = langFileName.Split('-')[1].Split('.')[0];
                string correctLangFileName = langFileName.Substring(0, langFileName.Count() - 10);

                myManager = new ResourceManager(correctLangFileName, _thisAssembly);
                string value = myManager.GetString("LangName");
                myManager.ReleaseAllResources();

                LangNames.Add(key, value);
                LangFileNames.Add(key, correctLangFileName);
            }

            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            myManager = new ResourceManager(LangFileNames[currentCulture.TwoLetterISOLanguageName], _thisAssembly);
        }

        /// <summary>
        /// Key : lang tag; Value: lang name.
        /// </summary>
        public static Dictionary<string, string> LangNames { get; private set; } = new Dictionary<string, string>();

        public static string GetMonthFromInt(int num)
        {
            switch (num)
            {
                case 1:
                    return GetString("january");

                case 2:
                    return GetString("february");

                case 3:
                    return GetString("march");

                case 4:
                    return GetString("april");

                case 5:
                    return GetString("may");

                case 6:
                    return GetString("june");

                case 7:
                    return GetString("july");

                case 8:
                    return GetString("august");

                case 9:
                    return GetString("september");

                case 10:
                    return GetString("october");

                case 11:
                    return GetString("november");

                case 12:
                    return GetString("december");

                default:
                    throw new Exception("Requested month not existing.");
            }
        }

        /// <summary>
        /// Returns a localized version of a string, according to current culture.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetString(string value)
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;

            if (Properties.Settings.Default.language != currentCulture.TwoLetterISOLanguageName)
            {
                if (LangNames.Keys.FirstOrDefault(x => x == currentCulture.TwoLetterISOLanguageName) == null)
                {
                    throw new Exception("Requested culture not available.");
                }

                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.language);
                currentCulture = Thread.CurrentThread.CurrentCulture;

                if (myManager != null) myManager.ReleaseAllResources();
                myManager = new ResourceManager(LangFileNames[currentCulture.TwoLetterISOLanguageName], _thisAssembly);
            }

            return myManager.GetString(value);
        }

        public static string ToTitleCase(string text)
        {
            return textInfo.ToTitleCase(text);
        }
    }
}