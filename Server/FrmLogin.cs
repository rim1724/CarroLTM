using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Server;

namespace CarroApp
{
    public partial class FrmLogin : Form
    {
        ProcessDatabase database = new ProcessDatabase();
        int checkLogin = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        

       
        private bool checkLoginForm(string name, string pass)
        {
            if (name != "" && pass != "")
            {
                String check = "select* from tblUser where UserName = '" + name + "'" + " and PassWord = '" + pass + "'";
                DataTable table = database.DocBang(check);
                if (table.Rows.Count == 1)
                    return true;
            }

            return false;
        }

        

        private bool checkRegister(string name, string pass)
        {
            if (name != "" && pass != "")
            {
                if (database.DocBang("select UserName,Mark from tblUser where UserName='" + name + "'").Rows.Count>0)
                {
                    if(database.DocBang("select UserName,Mark from tblUser where UserName='" + name + "'").Rows[0]["UserName"].ToString() == "")
                    return true;
                }
            }
          
            return false;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (checkLogin == 1)
            {

                MessageBox.Show("Bạn không thể chơi 1 người");
            }
            if (checkLogin == 2)
            {
                FrmClient frmClient = new FrmClient();
                FrmServer frmServer = new FrmServer();
                frmServer.Show();
                frmClient.Show();
            }

           
        }

        private void btn_login2_Click(object sender, EventArgs e)
        {
            
        }

    }
}
