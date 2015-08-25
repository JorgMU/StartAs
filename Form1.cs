using System;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace StartAs
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string usr = "";
      string un = "";
      string dom = "";
      string cmd = "";
      string opt = "";

      string[] args = Environment.GetCommandLineArgs();

      if (args.Length == 2)
      {
        ShowUse();
        Environment.Exit(-1);
      }

      if (args.Length >= 2)
      {
        //args[0] is this program itself
        usr = args[1]; //should be domain\user
        cmd = args[2]; //should be the command to run

        //if (ParseUser(usr, ref un, ref dom))
        //  usrTB.Text = dom + @"\" + un;
        //else

        usrTB.Text = usr;
        cmdTB.Text = cmd;
      }

      if (args.Length > 3)
      {
        string full = Environment.CommandLine;
        int index = full.IndexOf(cmd) + cmd.Length + 1;
        opt = full.Substring(index);
        optTB.Text = opt;
      }

      this.Show();
      System.Threading.Thread.Sleep(250);
      if (cmdTB.Text == "") cmdTB.Focus();
      else if (optTB.Text == "") optTB.Focus();
      else if (usrTB.Text == "") usrTB.Focus();
      else if (passTB.Text == "") passTB.Focus();
    }

    private void StartProcessAs(string User, string Domain, SecureString Pass, string Command, string Options)
    {

      ProcessStartInfo psi = null;

      try {
        psi = new ProcessStartInfo(Command, Options)
        {
          UseShellExecute = false,
          UserName = User,
          Domain = Domain,
          Password = Pass,
        };
      }
      catch (SystemException se)
      {
        ShowError(se);
      }
      if (psi == null) return;

      Process p = new Process();
      p.StartInfo = psi;
      bool worked = false;

      try { worked = p.Start(); }
      catch (SystemException se) { ShowError(se); }

      if (worked) Environment.Exit(0);
    }

    private void ShowError(SystemException se)
    {
      string msg = se.Message;
      if (se.InnerException != null)
        msg += "\r\n" + se.InnerException.Message;
      MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void ShowUse()
    {
      string msg = @"This program attempts to launch a program as the speecified user.
If you pass options on the command line it must be in the form:

StartAs.exe domain\user programToRun Options1 Options2 OptionsN
";
      MessageBox.Show(msg, "StartAs.exe - jorgie@missouri.edu - 2015");
    }

    private void startButton_Click(object sender, EventArgs e)
    {
      string cmd = cmdTB.Text;
      string opt = optTB.Text;
      string usr = usrTB.Text;
      string pass = passTB.Text;
      string un = "";
      string dom = "";

      if (ParseUser(usr, ref un, ref dom))
      {
        SecureString ss = new SecureString();
        foreach (char c in pass.ToCharArray()) ss.AppendChar(c);
        StartProcessAs(un, dom, ss, cmd, opt);
      }

    }

    private bool ParseUser(string Username, ref string User, ref string Domain)
    {
      int i = Username.IndexOf(@"\");
      if (i < 0)
      {
        MessageBox.Show(@"The username must be in the form: domain\user", "Error in Username");
        return false;
      }

      User = Username.Substring(i + 1);
      Domain = Username.Substring(0, i);

      if (User == "" || Domain == "")
      {
        return false;
      }
      return true;
    }
  }
}
