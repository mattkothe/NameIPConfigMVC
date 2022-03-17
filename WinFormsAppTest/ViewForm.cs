namespace WinFormsAppTest;

public partial class ViewForm : Form
{
    private static readonly object SyncRoot = new();
    private readonly Controller _myController;

    public ViewForm()
    {
        InitializeComponent();

        var myModel = new Model();
        var myView = new View(this);
        _myController = new Controller(myModel, myView);
    }


    private void HandleKey()
    {
        lock (SyncRoot)
        {
            _myController.UserAction(FirstNameTextBox.Text, LastNameTextBox.Text);
        }
    }


    private void LastNameTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        HandleKey();
    }

    private void FirstNameTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        HandleKey();
    }
}