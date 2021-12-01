using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


//Group Project Abdul Mian Syed Ahmed
namespace LoginUi
{
    public partial class Login : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,   
            int nWidthEllipse, 
            int nHeightEllipse 
        );


        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 70, 70));
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;


            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text= "Username";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.White;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "Demo!" && txtPass.Text == "1234")
            {
                this.Hide();
                var Loading = new Loading();
                Loading.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password Please Try Again");
                txtUser.Text = "Username";
                txtPass.Text = "Password";
            }



            // The database is connected to the program and works but not on other computers cause of file path, Professor is aware of this issue
            /* SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Abdul\Documents\ISM 240\LoginUi\Login.mdf;Integrated Security=True");
             string query = "Select * from LoginInfo Where UserName = '" + txtUser.Text.Trim() + "' and PassWord = '" + txtPass.Text.Trim() + "'  ";
             SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
             DataTable dtbl = new DataTable();
             sda.Fill(dtbl);


                 if (dtbl.Rows.Count == 1)
                 {
                     this.Hide();
                     var Loading = new Loading();
                     Loading.Show();

                 }
                 else
                 {
                     MessageBox.Show("Incorrect Username or Password");
                     txtUser.Text = "Username";
                     txtPass.Text = "Password";
                 }
                */

            
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Create = new Create();
            Create.Show();
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity = Opacity + .13;
        }

        
    }
}
