using CarroApp;
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
using System.Drawing.Drawing2D;
using System.Threading;


namespace Server
{
    public partial class FrmServer : Form, Iclick
    {
        ProcessDatabase database = new CarroApp.ProcessDatabase();
        byte[] dl = new byte[1024];
        int kt;
        ChessManagerServer chess;
        Socket client1;
        Socket sk;
        int countServer = 60;
        IPEndPoint ipe;

        public FrmServer()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            chess = new ChessManagerServer(this, pn_chess2, 1);
            chess.drawBoard();
            // đọc thông tin từ SQL
            dg_2.DataSource = database.DocBang("select UserName,Mark from tblUser order by Mark desc");
            lbl_name2.Text = Cons.player2;
            lbl_mark2.Text = database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player2 + "'").Rows[0]["Mark"].ToString();

            lbl_name1.Text = Cons.player1;
            lbl_mark1.Text = database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player1 + "'").Rows[0]["Mark"].ToString();
             sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
             ipe = new IPEndPoint(IPAddress.Any, 9000);
            sk.Bind(ipe);
            initServer();
        }

        private void initServer()
        {
            new Thread(() =>
            {
               
                sk.Listen(10);
                //   Console.WriteLine("Connecting...");
                client1 = sk.Accept();

                String stt = "Connected";
                dl = Encoding.ASCII.GetBytes(stt);
                client1.Send(dl, dl.Length, SocketFlags.None);


                while (true)
                {
                    byte[] dl = new byte[1024];
                    int kt = client1.Receive(dl);



                    string dlnhan = Encoding.ASCII.GetString(dl, 0, kt);
                    if (dlnhan == "1")
                    {
                        if (InvokeRequired)
                        {
                            this.Invoke(new Action(() => cdc()));
                            return;
                        }

                    }
                    else if (dlnhan == "2")
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
                        String[] s = dlnhan.Split(',');
                        Button btn = chess.matrix[int.Parse(s[0])][int.Parse(s[1])];
                        if (btn.BackgroundImage != null)
                        {
                            return;
                        }
                        int x = int.Parse(s[2]);
                         // MessageBox.Show(x+"");
                        //  if (x==1)
                        btn.BackgroundImage = Image.FromFile((Application.StartupPath + "\\Resources\\x.png"));


                        pn_chess2.Enabled = true;
                        if (InvokeRequired)
                        {
                            this.Invoke(new Action(() => tick()));
                            
                        }

                        //    tm_server.Start();
                        //  if(x==0)
                        //     btn.BackgroundImage = Image.FromFile((Application.StartupPath + "\\Resources\\o.png"));
                    }
                }
            })
            { IsBackground = true }.Start();

        }

        private void tick()
        {
            lbl_time_sever.Text = "60";
            tm_server.Start();
        }

        private void cdc2()
        {
            pn_chess2.Enabled = false;
        }

        private void cdc()
        {
            chess.drawBoard();
            initServer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void click(string x)
        {
            dl = new byte[1024];
            dl = Encoding.ASCII.GetBytes(x);
            client1.Send(dl, dl.Length, SocketFlags.None);
            pn_chess2.Enabled = false;
            tm_server.Stop();
        }
        // update lại thông tin
        public void update()
        {
            dg_2.DataSource = database.DocBang("select UserName,Mark from tblUser");
            lbl_mark2.Text = database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player2 + "'").Rows[0]["Mark"].ToString();
            lbl_mark1.Text = database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player1 + "'").Rows[0]["Mark"].ToString();
        }

        public void reLoad()
        {

             chess.drawBoard();
            initServer();
            String stt = "1";
            dl = Encoding.ASCII.GetBytes(stt);
            client1.Send(dl, dl.Length, SocketFlags.None);

        }

        private void lbl_name2_Click(object sender, EventArgs e)
        {
            chess.drawBoard();
        }

        public void lockPanel()
        {
            pn_chess2.Enabled = false;
            String stt = "2";
            dl = Encoding.ASCII.GetBytes(stt);
            client1.Send(dl, dl.Length, SocketFlags.None);

        }

        private void tm_server_Tick(object sender, EventArgs e)
        {
            countServer = Convert.ToInt16(lbl_time_sever.Text.ToString());
            if (countServer >= 0) countServer--;
            lbl_time_sever.Text = countServer.ToString();
            if (countServer == 0)
            {
                MessageBox.Show("Bạn đã thua");
                tm_server.Stop();
                pn_chess2.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tm_server.Start();
        }

    }
}
