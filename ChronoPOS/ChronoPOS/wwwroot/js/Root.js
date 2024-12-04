const myVariable = {

    //Utilities
    AppBackgroundColor: "--app-bg-color",
    ContentBackgroundColor: "--content-bg-color",
    CoreColor: "--core-color",
    SecondaryCoreColor : "--core-second-color",
    TextColor: "--text-color",
    TextCoreColor : "--core-text-color",
    IconColor: "--icon-color",

    //NavMenu
    NavMenuBackground: "--nav-bg-color",
    NavTextColor: "--nav-text-color",

}

window.RootJsFunctions = {

    ChangeTheam: function (theme) {
        try {
            if (typeof this[theme] == "function") {
                this[theme]();
            } else {
                this.ChangeTheam("Theme1");
            }
        } catch (ex) {
            this.Theme1();
        }
    },

    setStyle: function (propertyName, value) {
        document.documentElement.style.setProperty(propertyName, value);
    },

    Theme1: function () {

        //Utilities
        this.setStyle(myVariable.AppBackgroundColor, "#1b1c18");
        this.setStyle(myVariable.ContentBackgroundColor, "#232429");
        //this.setElementStyle(myVariable.CoreColor, "#F2890C");
        this.setStyle(myVariable.CoreColor, "#BAEB36");
        this.setStyle(myVariable.SecondaryCoreColor, "#31391b;");
        this.setStyle(myVariable.TextColor, "#FFFFFF");
        this.setStyle(myVariable.TextCoreColor, "#FFFFFF");
        this.setStyle(myVariable.IconColor, "#000000");

        //NavMenu
        this.setStyle(myVariable.NavMenuBackground, "#21231e");
        this.setStyle(myVariable.NavTextColor, "#a7a5a5");

    },

    Theme2: function () {

        //Utilities
        this.setStyle(myVariable.AppBackgroundColor, "#25221b");
        this.setStyle(myVariable.ContentBackgroundColor, "#232429");
        this.setStyle(myVariable.CoreColor, "#ffb600");
        this.setStyle(myVariable.SecondaryCoreColor, "#000000");
        this.setStyle(myVariable.TextColor, "#FFFFFF");
        this.setStyle(myVariable.TextCoreColor, "#FFFFFF");
        this.setStyle(myVariable.IconColor, "#000000");

        //NavMenu
        this.setStyle(myVariable.NavMenuBackground, "#2a2822");
        this.setStyle(myVariable.NavTextColor, "#a7a5a5");
    },

    Theme3: function () {

        //Utilities
        this.setStyle(myVariable.AppBackgroundColor, "#19171c");
        this.setStyle(myVariable.ContentBackgroundColor, "#232429");
        this.setStyle(myVariable.CoreColor, "#9655ff");
        this.setStyle(myVariable.SecondaryCoreColor, "#000000");
        this.setStyle(myVariable.TextColor, "#FFFFFF");
        this.setStyle(myVariable.TextCoreColor, "#FFFFFF");
        this.setStyle(myVariable.IconColor, "#000000");

        //NavMenu
        this.setStyle(myVariable.NavMenuBackground, "#25232a");
        this.setStyle(myVariable.NavTextColor, "#a7a5a5");
    },

    Theme4: function () {

        //Utilities
        this.setStyle(myVariable.AppBackgroundColor, "#2d2022");
        this.setStyle(myVariable.ContentBackgroundColor, "#232429");
        this.setStyle(myVariable.CoreColor, "#ff495f");
        this.setStyle(myVariable.SecondaryCoreColor, "#000000");
        this.setStyle(myVariable.TextColor, "#FFFFFF");
        this.setStyle(myVariable.TextCoreColor, "#FFFFFF");
        this.setStyle(myVariable.IconColor, "#000000");

        //NavMenu
        this.setStyle(myVariable.NavMenuBackground, "#352a2b");
        this.setStyle(myVariable.NavTextColor, "#a7a5a5");
    },

    //Theme5: function () {

    //    //Utilities
    //    this.setStyle(myVariable.AppBackgroundColor, "#1c2522");
    //    this.setStyle(myVariable.ContentBackgroundColor, "#232429");
    //    this.setStyle(myVariable.CoreColor, "#28ffbe");
    //    this.setStyle(myVariable.SecondaryCoreColor, "#000000");
    //    this.setStyle(myVariable.TextColor, "#FFFFFF");
    //    this.setStyle(myVariable.TextCoreColor, "#FFFFFF");
    //    this.setStyle(myVariable.IconColor, "#000000");

    //    //NavMenu
    //    this.setStyle(myVariable.NavMenuBackground, "#242d2a");
    //    this.setStyle(myVariable.NavTextColor, "#a7a5a5");
    //},

}