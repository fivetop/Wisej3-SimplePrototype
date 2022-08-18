function dockTwins() {

    // dock window 1 to the left using half of the workspace
    App.Desktop.getWindows()[0].setLayoutProperties({ left: 0, right: "100%", top: 0, bottom: 0 });

    // dock window 2 to the right using half of the workspace
    //App.Desktop.getWindows()[1].setLayoutProperties({ left: "50%", right: 0, top: 0, bottom: 0 });
}


this.dock2 = function ()
{
	var win1 = App.Desktop.getWindows()[0];
	win1.setLayoutProperties({ left: 0, right: "100%", top: 0, bottom: "100%" });
}
//# sourceURL=MyDesktop.Dock.js

/**
 * dockWindows
 *
 * Maximizes and docks all windows horizontally.
 */
this.dockWindows = function () {

	var windows = this.getWindows();
	var left = 0;
	var right = 0;
	var w = windows[0];
	w.maximize();
	left = 0;
	right = 0;
	w.setLayoutProperties({ left: left + "%", right: right + "%", top: 0, bottom: 0 });
	w.getContentElement().setStyles({ border: "1px solid gray" });
}