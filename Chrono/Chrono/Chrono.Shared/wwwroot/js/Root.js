const myVariable = {

    //App's Color
    AppBackgroundColor: "--app-bg-color",
    ContentBackgroundColor: "--content-bg-color",
    CoreColor: "--core-color",
    CoreDarkColor: "--core-color-dark",
    CoreLightColor: "--core-light-color",
    SecondaryCoreColor : "--core-second-color",
    TextColor: "--text-color",
    TextCoreColor : "--core-text-color",
    IconColor: "--icon-color",
    AppBorderColor: "--border-color",

    //NavMenu
    NavMenuBackground: "--nav-bg-color",
    NavSelectBackground: "--nav-selbg-color",
    NavSelectBackground2: "--nav-selbg2-color",
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
        this.setElementStyle(myVariable.CoreLightColor, "#ecf4fc");
        this.setElementStyle(myVariable.SecondaryCoreColor, "#201d2b");
        this.setElementStyle(myVariable.TextColor, "#000000");
        this.setElementStyle(myVariable.TextCoreColor, "#000000");
        this.setElementStyle(myVariable.IconColor, "#000000");
        this.setElementStyle(myVariable.AppBorderColor, "#e7e7e7");

        //NavMenu
        this.setElementStyle(myVariable.NavMenuBackground, "#FAFAFA");
        this.setElementStyle(myVariable.NavSelectBackground, "#7bc7f7");
        this.setElementStyle(myVariable.NavSelectBackground2, "#99d0f1");
        this.setElementStyle(myVariable.NavTextColor, "#716b6b");
        this.setElementStyle(myVariable.NavIndicationColor, "#a2d0eded");


        //Utilities
        this.setElementStyle(myVariable.HeaderTextColor, "#6b6b6b");
        this.setElementStyle(myVariable.HoverColor, "#f1f3f5");
        this.setElementStyle(myVariable.DarkColor, "#212529");
        this.setElementStyle(myVariable.AccentColor, "#4895ef");
    },

    DarkTheme: function () {

        //App's Color
        this.setElementStyle(myVariable.AppBackgroundColor, "#140b23");
        this.setElementStyle(myVariable.ContentBackgroundColor, "#d1d1d1");
        this.setElementStyle(myVariable.CoreColor, "#2bacfd");
        this.setElementStyle(myVariable.CoreDarkColor, "#1a8fd8");
        this.setElementStyle(myVariable.CoreLightColor, "#1c3d60");
        this.setElementStyle(myVariable.SecondaryCoreColor, "#201d2b");
        this.setElementStyle(myVariable.TextColor, "#e5e5e5");
        this.setElementStyle(myVariable.TextCoreColor, "#e5e5e5");
        this.setElementStyle(myVariable.IconColor, "#000000");
        this.setElementStyle(myVariable.AppBorderColor, "#2f2f2f");

        //NavMenu
        this.setElementStyle(myVariable.NavMenuBackground, "#201b33");
        this.setElementStyle(myVariable.NavSelectBackground, "#17374b");
        this.setElementStyle(myVariable.NavSelectBackground2, "#17374b");
        this.setElementStyle(myVariable.NavTextColor, "#e7e7e7");
        this.setElementStyle(myVariable.NavIndicationColor, "#a2d0eded");


        //Utilities
        this.setElementStyle(myVariable.HeaderTextColor, "#cdcdcd");
        this.setElementStyle(myVariable.HoverColor, "#17374b");
        this.setElementStyle(myVariable.DarkColor, "#212529");
        this.setElementStyle(myVariable.AccentColor, "#4895ef");
    },
}