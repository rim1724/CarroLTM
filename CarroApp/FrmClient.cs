using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace CarroApp
{
    public partial class FrmClient : Form, Iclick
    {
        ProcessDatabase database = new ProcessDatabase();
        ChessManager chess;
        byte[] dl = new byte[1024];
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public FrmClient()
        {
            InitializeComponent();
            chess = new ChessManager(this, pn_chess, 0);
            chess.drawBoard();
            // đọc thông tin từ SQL
            dg_1.DataSource = database.DocBang("select UserName,Mark from tblUser order by Mark desc");
            lbl_name1.Text = Cons.player1;
            lbl_mark1.Text = database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player1 + "'").Rows[0]["Mark"].ToString();
            lbl_name2.Text = Cons.player2;
            lbl_mark2.Text = database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player2 + "'").Rows[0]["Mark"].ToString();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            receiverServer();
       
        }
        private void receiverServer()
        {
            Cons.checkConnect = 1;
            int kt;
            byte[] dl = new byte[1024];
            string dlnhan;

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            try
            {
                server.Connect(ipe);

            }
            catch (SocketException ec)
            {
                Console.WriteLine(ec.ToString());
                return;
            }
            kt = server.Receive(dl);
            dlnhan = Encoding.ASCII.GetString(dl, 0, kt);
            lbl_status.Text = dlnhan;
            new Thread(() =>
            {

                while (true)
                {
                    int kt1 = server.Receive(dl);
                    string dlnhan1 = Encoding.ASCII.GetString(dl, 0, kt1);
                    if (dlnhan1 == "1")
                    {
                        if (InvokeRequired)
                        {
                            this.Invoke(new Action(() => cdc()));
                            return;
                        }

                    }
                    else if (dlnhan1 == "2")
                    {
                        if (InvokeRequired)
                        {
                            this.Invoke(new Action(() => cdc2()));
                            return;
                        }
                    }
                    else
                    {
                        // MessageBox.Show(dlnhan + "");
                        String[] s = dlnhan1.Split(',');
                        Button btn = chess.matrix[int.Parse(s[0])][int.Parse(s[1])];
                        if (btn.BackgroundImage != null)
                        {
                            return;
                        }
                        int x = int.Parse(s[2]);
                      //  MessageBox.Show(x + "");
                        // if (x == 1)
                        //    btn.BackgroundImage = Image.FromFile((Application.StartupPath + "\\Resources\\x.png"));

                        //  if (x == 0)
                        btn.BackgroundImage = Image.FromFile((Application.StartupPath + "\\Resources\\o.png"));
                        pn_chess.Enabled = true;
                        if (InvokeRequired)
                        {
                            this.Invoke(new Action(() => tick()));

                        }
                    }
                }
            })
            { IsBackground = true }.Start();
        }

        private void cdc2()
        {
            pn_chess.Enabled = false;
        }

        private void cdc()
        {
            chess.drawBoard();
            receiverServer();
        }

        void Iclick.click(String x)
        {
            dl = new byte[1024];
            dl = Encoding.ASCII.GetBytes(x);
            server.Send(dl, dl.Length, SocketFlags.None);
            pn_chess.Enabled = false;
            // MessageBox.Show(x+"");
            tm_client.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tick()
        {
            lbl_time_client.Text = "60";
            tm_client.Start();
        }
        // update thông tin
        public void update()
        {
            dg_1.DataSource = database.DocBang("select UserName,Mark from tblUser");
            lbl_mark1.Text = database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player1 + "'").Rows[0]["Mark"].ToString();
            lbl_mark2.Text = database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player2 + "'").Rows[0]["Mark"].ToString();
        }

        public void reLoad()
        {
           
             chess.drawBoard();
            receiverServer();
            String stt = "1";
            dl = Encoding.ASCII.GetBytes(stt);
            server.Send(dl, dl.Length, SocketFlags.None);


        }

        public void lockPanel()
        {
            pn_chess.Enabled = false;
            String stt = "2";
            dl = Encoding.ASCII.GetBytes(stt);
            server.Send(dl, dl.Length, SocketFlags.None);
        }

        private void lbl_name1_Click(object sender, EventArgs e)
        {
            chess.drawBoard();
        }

        private void tm_client_Tick(object sender, EventArgs e)
        {
           int countServer = Convert.ToInt16(lbl_time_client.Text.ToString());
            if (countServer >= 0) countServer--;
            lbl_time_client.Text = countServer.ToString();
            if (countServer == 0) {
                MessageBox.Show("Bạn đã thua");
                tm_client.Stop();
                pn_chess.Enabled = false;
            }
        }

    }
}
