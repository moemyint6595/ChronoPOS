using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shared.Services.LanguageService;

namespace Shared.Services
{
    public class LanguageService
    {
       
        private string _currentLanguage = string.Empty;

        public Dictionary<string,Language> Languages = new Dictionary<string, Language>()
        {
            {"name" ,new Language(){ en = "Name", mm = "Name"  }},
        };
        public string this[string key]
        {
            get
            {
                if (!Languages.TryGetValue(key, out Language? value)) return "";
                if(_currentLanguage == "en")
                {
                    return value.en;
                }
                return value.mm;
            }
        }

        public void SetLanguage(string language)
        {
            _currentLanguage = language;
        }

        public class Language
        {
            public string en { get; set; } = string.Empty;
            public string mm { get; set; } = string.Empty;
        }
    }
}
