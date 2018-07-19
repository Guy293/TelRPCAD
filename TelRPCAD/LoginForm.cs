using System.Windows.Forms;

namespace TelRPCAD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            MaximizeBox = false;
        }

        CAD cad = new CAD();

        private void LogInBtn_Click(object sender, System.EventArgs e)
        {
            cad.Show();
        }
    }
}
