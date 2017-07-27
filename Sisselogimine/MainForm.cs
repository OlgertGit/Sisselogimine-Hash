using System;
using System.Windows.Forms;
using SisseLogimine.Klassid;

namespace SisseLogimine
{
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        btn_Sisene.Click += Btn_Sisene_Click;
        btn_Registreeru.Click += Btn_Registreeru_Click;
        btn_Exit.Click += Btn_Exit_Click;
    }

    private void Btn_Exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void Btn_Registreeru_Click(object sender, EventArgs e)
    {
        var loginC = new LoginClass();
        loginC.Registreerimine(tb_Login.Text, tb_Passwd.Text);
        tb_Login.Clear();
        tb_Passwd.Clear();
    }

    private void Btn_Sisene_Click(object sender, EventArgs e)
    {
        var loginC = new LoginClass();
        loginC.SisseLogimine(tb_Login.Text, tb_Passwd.Text);
        tb_Login.Clear();
        tb_Passwd.Clear();
    }
}
}
