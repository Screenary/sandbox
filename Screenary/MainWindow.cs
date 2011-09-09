using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnQuitActionActivated (object sender, System.EventArgs e)
	{
		Application.Quit ();
	}

	protected void OnAboutActionActivated (object sender, System.EventArgs e)
	{
		AboutDialog dialog = new AboutDialog();
		dialog.Run ();
	}

	protected void OnBtnTestClicked (object sender, System.EventArgs e)
	{

	}
}
