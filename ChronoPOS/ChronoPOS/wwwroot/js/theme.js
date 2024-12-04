let draggedCircle = null;
let clonedCircle = null;
let draggedData = null; // Store the 'data' attribute of the dragged circle

var ThemeHelper;

// Function to handle mouse down on a circle
function handleMouseDown(e) {
    draggedCircle = e.target;
    draggedData = draggedCircle.getAttribute('data'); // Get data attribute
    // Create a new cloned circle to follow the mouse
    clonedCircle = draggedCircle.cloneNode();
    clonedCircle.style.position = 'absolute';
    clonedCircle.style.opacity = '0.7';
    clonedCircle.style.zIndex = "1000";

    document.body.appendChild(clonedCircle);

    // Update position of cloned circle
    moveClonedCircle(e);
}

// Function to update the position of the cloned circle
function moveClonedCircle(e) {
    if (clonedCircle) {
        clonedCircle.style.left = `${e.pageX - 25}px`;
        clonedCircle.style.top = `${e.pageY - 25}px`;
    }
}

// Function to handle mouse up, completing the drag/drop
function handleMouseUp(e) {
    if (clonedCircle) {
        clonedCircle.remove();
        clonedCircle = null;
    }

    if (draggedCircle) {
        switch (draggedData) {
            case "Theme1":
                console.log("Theme 1 selected");
                RootJsFunctions.Theme1();
                break;
            case "Theme2":
                RootJsFunctions.Theme2();
                console.log("Theme 2 selected");
                break;
            case "Theme3":
                RootJsFunctions.Theme3();
                console.log("Theme 3 selected");
                break;
            case "Theme4":
                RootJsFunctions.Theme4();
                console.log("Theme 4 selected");
                break;
            default:
                RootJsFunctions.Theme5();
                console.log("Theme 5 selected");
        }
        if (ThemeHelper) {
            ThemeHelper.invokeMethodAsync('ThemeChangeCaller', draggedCircle.getAttribute('data-id'));
        }
        draggedCircle = null;
        draggedData = null;
    }
}

function InitializeThemes() {
    // Event listeners for mouse events
    document.querySelectorAll('.apptheme-circle').forEach(circle => {
        circle.addEventListener('mousedown', handleMouseDown);
    });
}


// Listen to mouse move on the entire document
document.addEventListener('mousemove', moveClonedCircle);
document.addEventListener('mouseup', handleMouseUp);

function SetThemeChangeHelper(dotNetThemObj)
{
    ThemeHelper = dotNetThemObj;
}