using GlobalShared.Services.StaticServices;
using GlobalShared.Model;

namespace GlobalShared.Services.MicroServices
{
    public class LanguageService
    {
       
        private string _currentLanguage = LanguageType.EN;

        public Dictionary<string,Language> Languages = new Dictionary<string, Language>()
        {
            {"" ,new Language(){ en = "", mm = ""  }},

            //Menu
            {MenuSection.Order ,new Language(){ en = MenuSection.Order, mm = "မှာယူထားသောစားပွဲများ" }},
            //{MenuSection.TableView ,new Language(){ en = "Table View", mm = "ခုံနေရာဖြင့်ကြည့်ရန်" }},
            {MenuSection.Setup ,new Language(){ en = MenuSection.Setup, mm = "ပြင်ဆင်ရန်" }},
            {MenuSection.Table ,new Language(){ en = MenuSection.Table, mm = "ခုံနေရာ" }},
            {MenuSection.Items ,new Language(){ en = MenuSection.Items, mm = "ဟင်းပွဲများ" }},
            {MenuSection.Category ,new Language(){ en = MenuSection.Category, mm = "အုပ်စု" }},
            {MenuSection.Discount ,new Language(){ en = MenuSection.Discount, mm = "လျော့စျေး" }},
            //{MenuSection.Tax ,new Language(){ en = MenuSection.Tax, mm = "အခွန်"  }},
        };
        public string this[string key]
        {
            get
            {
                if (!Languages.TryGetValue(key, out Language? value)) return key;
                if(_currentLanguage == LanguageType.EN)
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
    }
}
