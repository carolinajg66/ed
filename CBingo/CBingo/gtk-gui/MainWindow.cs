
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vboxMain;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button buttonGoForward;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vboxMain = new global::Gtk.VBox ();
		this.vboxMain.Name = "vboxMain";
		this.vboxMain.Spacing = 6;
		// Container child vboxMain.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonGoForward = new global::Gtk.Button ();
		this.buttonGoForward.CanFocus = true;
		this.buttonGoForward.Name = "buttonGoForward";
		this.buttonGoForward.UseStock = true;
		this.buttonGoForward.UseUnderline = true;
		this.buttonGoForward.Label = "gtk-go-forward";
		this.hbox1.Add (this.buttonGoForward);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonGoForward]));
		w1.Position = 2;
		w1.Expand = false;
		w1.Fill = false;
		this.vboxMain.Add (this.hbox1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxMain [this.hbox1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		this.Add (this.vboxMain);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
