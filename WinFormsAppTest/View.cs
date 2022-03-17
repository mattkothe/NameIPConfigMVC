using System.Net;
using System.Net.Sockets;

namespace WinFormsAppTest;

internal class View
{
    public ViewForm MyViewForm;

    public View(ViewForm myForm)
    {
        MyViewForm = myForm;
    }

    private string GetIp()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
            if (ip.AddressFamily == AddressFamily.InterNetwork)
                return ip.ToString();
        return "";
    }

    internal void Update(Model model)
    {
        if (model.FirstName == "" && model.LastName == "")
        {
            MyViewForm.ResultBox.Text = "";
            return;
        }

        var ip = GetIp();

        if (ip != "") ip = " your IP address is " + GetIp();

        MyViewForm.ResultBox.Text =
            "Hello, " + model.FirstName + " " + model.LastName + ip;
    }
}