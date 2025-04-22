
window.CommonJSFunctions = {

    GetIsNetworkAvailable: function () {
        return window.navigator.onLine;
    },

    back: function () {
        history.go(-1);
    },

    getWindowScreen: function () {
        return {
            height: window.innerHeight,
            width: window.innerWidth
        };
    },

    getDevice: function () {
        const navigatorAgent = navigator.userAgent;
        if (navigatorAgent.match(/mobile/i)) {
            return 'mobile';
        } else if (navigatorAgent.match(/iPad|Android|Touch/i)) {
            return 'tablet';
        }
        return 'desktop';
    },

    focusIn: function (input, focusOut = false) {
        setTimeout(() => {
            var inputEle = document.getElementById(input);
            if (inputEle) {
                if (focusOut) {
                    inputEle.blur();
                } else {
                    inputEle.focus();
                }
            }
        }, 200);
    },

    SetMainPageHeight : function () {
        var mainpage = document.getElementById("main-page");
        if (mainpage) {
            mainpage.style.height = window.innerHeight + "px";
        }
    },

    InitiateResize: function (dotNetHelper) {
        var resizeTimer;
        window.addEventListener("resize", () => {
            clearTimeout(resizeTimer);
            resizeTimer = setTimeout(function () {

                //set main page
                CommonJSFunctions.SetMainPageHeight();
                CommonJSFunctions.CalculateContentHeight();

                //invoke to C#
                if (dotNetHelper) {
                    dotNetHelper.invokeMethodAsync('GlobalResizeCaller', window.innerWidth, window.innerHeight);
                }

            }, 300);
        });
    },

    CalculateContentHeight: function () {
        var mb = document.getElementById("mainbody");
        var mh = document.getElementById("mainheader");
        if (mb) {
            var minusHeight = 0;
            if (mh) {
                minusHeight += mh.clientHeight;
            }
            var vb = document.getElementById("viewbody");
            if (vb) {
                var vh = document.getElementById("viewheader")
                if (vh) {
                    minusHeight += vh.clientHeight;
                }
                vb.style.height = window.innerHeight - (minusHeight) + "px";
            }
        }
    },

    ToggleLoading: function (showloading) {
        var loading = document.getElementById("loading");
        if (loading) {
            if (showloading == true) {
                if (loading.classList.contains("loading-hide")) {
                    loading.classList.remove("loading-hide");
                }
            }
            else
            {
                if (!loading.classList.contains("loading-hide")) {
                    loading.classList.add("loading-hide");
                }
            }
        }
    },

    ShowErrorMessage: function (message) {
        var msgBox = document.getElementById("message");
        if (msgBox) {
            if (msgBox.classList.contains("message-hide")) {
                var messageBox = document.getElementById("msg-text");
                if (messageBox) {
                    messageBox.textContent = message;
                    msgBox.classList.remove("message-hide");
                }
            }
        }
    },

    CloseErrorMessage: function () {
        var msgBox = document.getElementById("message");
        if (msgBox) {
            if (!msgBox.classList.contains("message-hide")) {
                msgBox.classList.add("message-hide");
            }
        }
    },

    Focus: function (inputId) {
        var inputElement = document.getElementById(inputId);
        if (inputElement) {
            inputElement.focus();
        }
    },

    ScrollToElement: function (elementId) {
        var targetElement = document.getElementById(elementId);
        var mainbody = document.getElementById("main-body");
        if (targetElement && mainbody) {
            var targetPosition = targetElement.getBoundingClientRect().top + window.pageYOffset - 200;
            mainbody.scrollTo({
                top: targetPosition,
                behavior: 'smooth'
            });
        }
    }
}
