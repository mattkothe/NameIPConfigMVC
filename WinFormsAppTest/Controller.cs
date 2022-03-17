namespace WinFormsAppTest;

internal class Controller
{
    public Model MyModel;
    public View MyView;

    public Controller(Model model, View view)
    {
        MyModel = model;
        MyView = view;
    }

    internal void UserAction(string firstName, string lastName)
    {
        MyModel.FirstName = firstName;
        MyModel.LastName = lastName;

        MyView.Update(MyModel);
    }
}