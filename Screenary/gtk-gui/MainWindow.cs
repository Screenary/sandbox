
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action FileAction1;
	private global::Gtk.Action HelpAction;
	private global::Gtk.Action QuitAction;
	private global::Gtk.Action AboutAction;
	private global::Gtk.Action fileAction;
	private global::Gtk.Action quitAction;
	private global::Gtk.Action helpAction;
	private global::Gtk.Action aboutAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar mainMenuBar;
    
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.FileAction1 = new global::Gtk.Action ("FileAction1", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction1, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.QuitAction = new global::Gtk.Action ("QuitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, null);
		this.QuitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
		w1.Add (this.QuitAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.fileAction = new global::Gtk.Action ("fileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.fileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.fileAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, null);
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
		w1.Add (this.quitAction, null);
		this.helpAction = new global::Gtk.Action ("helpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.helpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.helpAction, null);
		this.aboutAction = new global::Gtk.Action ("aboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.aboutAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Screenary");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='mainMenuBar'><menu name='fileAction' action='fileAction'><menuitem name='quitAction' action='quitAction'/></menu><menu name='helpAction' action='helpAction'><menuitem name='aboutAction' action='aboutAction'/></menu></menubar></ui>");
		this.mainMenuBar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/mainMenuBar")));
		this.mainMenuBar.Name = "mainMenuBar";
		this.vbox1.Add (this.mainMenuBar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.mainMenuBar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 885;
		this.DefaultHeight = 622;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.QuitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.AboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.aboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
	}
}
