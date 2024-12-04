
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

                //invoke to C#
                if (dotNetHelper) {
                    dotNetHelper.invokeMethodAsync('GlobalResizeCaller', window.innerWidth, window.innerHeight);
                }

            }, 300);
        });
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

window.ChartJSFunctions = {

    DoughnutChart: function (canvasID, bColor = "#BAEB36") {

        var randomColor = [
            "#3e92cc", "#fa8072", "#2ecc71", "#f39c12", "#8e44ad",
            "#3498db", "#c0392b", "#27ae60", "#e74c3c", "#f1c40f",
            "#9b59b6", "#2980b9", "#34495e", "#e67e22", "#1abc9c",
            "#d35400", "#2c3e50", "#bdc3c7", "#7f8c8d", "#ecf0f1"
        ];

        var bordercolor = bColor;

        var borderColorArray = [
            bordercolor,
            bordercolor,
            bordercolor,
            bordercolor,
            bordercolor,
        ];

        var backgroundColorArray = [
            randomColor[0],
            randomColor[1],
            randomColor[2],
            randomColor[3],
            randomColor[4],
        ];

        var lableArray = [
            "Rooms",
            "Customer",
            "Orders",
            "Employee",
            "Sales"
        ];

        var config = {
            type: 'doughnut',
            data: {
                datasets: [{
                    data: [10, 50, 128, 40, 300],
                    backgroundColor: backgroundColorArray,
                    borderColor: borderColorArray,
                    borderWidth: 1
                }],
                labels: lableArray
            },
            options: {
                responsive: true,
                plugins: {
                    legend: {
                        labels: {
                            padding: 20,
                        }, 
                        position: 'bottom'
                    }
                },
                tooltips: {
                    enabled: false,
                },
            }
        };

        var ctx = document.getElementById("chart-area").getContext("2d");
        window.myDougnutChart = new Chart(ctx, config);

    },

    LineChart: function (canvasID, bColor = "#BAEB36") {

        var labels = [ "January", "February", "March", "April", "May", "June", "July"];

        var data = {
            labels: labels,
            datasets: [{
                label: 'Sale Analysis',
                data: [65, 59, 80, 81, 56, 55, 40],
                fill: false,
                borderColor: bColor,
                tension: 0.1
            }]
        };

        var config = {
            type: 'line',
            data: data,
        };

        var ctx = document.getElementById("line-area").getContext("2d");
        window.myLineChart = new Chart(ctx, config);

    }

}
