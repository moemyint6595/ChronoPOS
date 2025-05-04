const myVariable = {

    //App's Color
    AppBackgroundColor: "--app-bg-color",
    ContentBackgroundColor: "--content-bg-color",
    CoreColor: "--core-color",
    CoreDarkColor: "--core-color-dark",
    CoreLightColor: "--core-light-dark",
    SecondaryCoreColor : "--core-second-color",
    TextColor: "--text-color",
    TextCoreColor : "--core-text-color",
    IconColor: "--icon-color",

    //NavMenu
    NavMenuBackground: "--nav-bg-color",
    NavSelectBackground: "--nav-selbg-color",
    NavTextColor: "--nav-text-color",
    NavIndicationColor: "--nav-ind-color",


    //Utilities
    HeaderTextColor: "--mh-text-color",
    HoverColor: "--hover-color",
    DarkColor: "--dark-color",
    AccentColor: "--accent-color",

}

window.RootJsFunctions = {

    ChangeTheme: function (theme) {
        try {
            if (typeof this[theme] == "function") {
                this[theme]();
            } else {
                this.MainTheme();
            }
        } catch (ex) {
            this.MainTheme();
        }
    },

    setElementStyle: function (propertyName, value) {
        document.documentElement.style.setProperty(propertyName, value);
    },

    MainTheme: function () {

       //App's Color
        this.setElementStyle(myVariable.AppBackgroundColor, "#F5F5F5");
        this.setElementStyle(myVariable.ContentBackgroundColor, "#d1d1d1");
        this.setElementStyle(myVariable.CoreColor, "#2bacfd");
        this.setElementStyle(myVariable.CoreDarkColor, "#1a8fd8");
        this.setElementStyle(myVariable.CoreLightColor, "#d4e9ff");
        this.setElementStyle(myVariable.SecondaryCoreColor, "#201d2b");
        this.setElementStyle(myVariable.TextColor, "#000000");
        this.setElementStyle(myVariable.TextCoreColor, "#000000");
        this.setElementStyle(myVariable.IconColor, "#000000");

        //NavMenu
        this.setElementStyle(myVariable.NavMenuBackground, "#FAFAFA");
        this.setElementStyle(myVariable.NavSelectBackground, "#e7efff");
        this.setElementStyle(myVariable.NavTextColor, "#000000");
        this.setElementStyle(myVariable.NavIndicationColor, "#a2d0eded");


        //Utilities
        this.setElementStyle(myVariable.HeaderTextColor, "#6b6b6b");
        this.setElementStyle(myVariable.HoverColor, "#f1f3f5");
        this.setElementStyle(myVariable.DarkColor, "#212529");
        this.setElementStyle(myVariable.AccentColor, "#4895ef");
    },
}