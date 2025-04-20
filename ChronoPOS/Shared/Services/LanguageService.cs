namespace Shared.Services
{
    public class LanguageService
    {
       
        private string _currentLanguage = string.Empty;

        public Dictionary<string,Language> Languages = new Dictionary<string, Language>()
        {
            //Dashboard
            {"active-r-info" ,new Language(){ en = "This indicates currently active rooms with ongoing sections.", mm = "This indicates currently active rooms with ongoing sections."  }},
            {"active-v-info" ,new Language(){ en = "This indicates currently active vocalists in rooms.", mm = "This indicates currently active vocalists in rooms."  }},

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
