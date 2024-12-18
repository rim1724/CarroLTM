using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarroApp;
using System.Windows.Forms;
using System.Drawing;

namespace Server
{
    class ChessManagerServer
    {
        public List<List<ButtonCs>> matrix;
        private Panel panel;
        private Iclick iclick;
        private List<Player> player;
        private int curentPlayer;


        private ProcessDatabase database = new ProcessDatabase();

        private Boolean checkClick = true;


        public Panel Panel { get => panel; set => panel = value; }
        public int CurentPlayer { get => curentPlayer; set => curentPlayer = value; }
        internal List<Player> Player { get => player; set => player = value; }
        private Iclick Iclick1 { get => iclick; set => iclick = value; }



        public ChessManagerServer(Iclick i, Panel panel, int curentPlayer)
        {
            this.Panel = panel;
            this.iclick = i;
            this.player = new List<Player>()
            {
                new Player("client",Image.FromFile((Application.StartupPath+"\\Resources\\x.png"))),
            new Player("Server", Image.FromFile((Application.StartupPath + "\\Resources\\o.png")))
        };
            this.curentPlayer = curentPlayer;
        }



        public void drawBoard()
        {
            panel.Enabled = true;
            panel.Controls.Clear();

            matrix = new List<List<ButtonCs>>();
            ButtonCs btnOld = new ButtonCs()
            {
                Width = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < Cons.BWIDTH; i++)
            {
                matrix.Add(new List<ButtonCs>());
                for (int j = 0; j < Cons.BHEIGHT; j++)
                {
                    ButtonCs btn = new ButtonCs()
                    {
                        x = i,
                        y = j,
                        Width = Cons.WIDTH,
                        Height = Cons.HEIGHT,
                        Location = new Point(btnOld.Location.X + btnOld.Width, btnOld.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    btn.Click += btn_click;
                    Panel.Controls.Add(btn);
                    matrix[i].Add(btn);
                    btnOld = btn;
                }
                btnOld.Location = new Point(0, btnOld.Location.Y + Cons.HEIGHT);
                btnOld.Width = 0;
                btnOld.Height = 0;
            }

        }

        private void btn_click(object sender, EventArgs e)
        {
            if (Cons.checkConnect == 1)
            {
                ButtonCs btn = sender as ButtonCs;

                if (btn.BackgroundImage != null)
                {
                    return;
                }
                btn.BackgroundImage = player[curentPlayer].Image;
                Image imageCurrent = btn.BackgroundImage;


                //   curentPlayer = curentPlayer == 1? 1: 0;
                //  MessageBox.Show(btn.Location.X + "," + btn.Location.Y);
                iclick.click(getpossition(btn));
                if (isEndGame(btn))
                {
                    String playerName = "";
                    if (btn.BackgroundImage == player[0].Image)
                    {
                        playerName = Cons.player1;
                        Cons.markPlayer1 += 10;
                        database.CapNhatDuLieu("update tblUser set Mark=" + Cons.markPlayer1 + " where UserName='" + Cons.player1 + "'");
                        iclick.update();
                    }
                    if (btn.BackgroundImage == player[1].Image)
                    {
                        playerName = Cons.player2;
                        Cons.markPlayer2 += 10;
                        database.CapNhatDuLieu("update tblUser set Mark=" + Cons.markPlayer2 + " where UserName='" + Cons.player2 + "'");
                        iclick.update();
                    }
                    // MessageBox.Show(isEndHorizontal(btn)+""+btn.x+";"+btn.y+";"+matrix[btn.x][btn.y].BackgroundImage);
                    endGame(playerName);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn connect vui lòng kiểm tra lại kết nối");
            }


        }

        private void endGame(String playName)
        {
            if (MessageBox.Show(playName + "   Thắng", "Thông báo",
         MessageBoxButtons.OK) == DialogResult.OK)
            {

                iclick.lockPanel();

            }

        }

        private bool isEndGame(ButtonCs btn)
        {
            return
                isEndHorizontal(btn) || isEndVertical(btn) ||
            isEndGameP(btn) || isEndGameS(btn);
        }

        private Boolean isEndHorizontal(ButtonCs btn)
        {
            int countLeft = 0;

            for (int i = btn.y; i >= 0; i--)
            {
                if (matrix[btn.x][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }
            int countRight = 0;
            for (int i = btn.y + 1; i < CarroApp.Cons.BWIDTH; i++)
            {
                if (matrix[btn.x][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }

            return countLeft + countRight == 5;
        }
        private bool isEndVertical(CarroApp.ButtonCs btn)
        {
            int countLeft = 0;

            for (int i = btn.x; i >= 0; i--)
            {
                if (matrix[i][btn.y].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }
            int countRight = 0;
            for (int i = btn.x + 1; i < Cons.BHEIGHT; i++)
            {
                if (matrix[i][btn.y].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }

            return countLeft + countRight == 5;
        }
        private bool isEndGameP(ButtonCs btn)
        {
            int countLeft = 0;

            for (int i = 0; i <= btn.x; i++)
            {
                if (btn.x - i < 0 || btn.y - i < 0) break;
                if (matrix[btn.x - i][btn.y - i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }
            int countRight = 0;
            for (int i = 1; i < Cons.BWIDTH - btn.x; i++)
            {
                if (btn.x + i >= Cons.BWIDTH || btn.y + i >= Cons.BHEIGHT) break;
                if (matrix[btn.x + i][btn.y + i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }

            return countLeft + countRight == 5;
        }
        private bool isEndGameS(ButtonCs btn)
        {
            // len h tang v giam
            int countLeft = 0;

            for (int i = 0; i <= btn.x; i++)
            {
                if (btn.y + i > Cons.BWIDTH || btn.x - i < 0) break;
                if (matrix[btn.x - i][btn.y + i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }

            // xuong h giam v tang
            int countRight = 0;
            for (int i = 1; i < Cons.BWIDTH - btn.x; i++)
            {
                if (btn.x + i >= Cons.BWIDTH || btn.y - i <= 0) break;
                if (matrix[btn.x + i][btn.y - i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }

            return countLeft + countRight == 5;
        }

        public String getpossition(ButtonCs btn)
        {
            int i = btn.x;
            int j = btn.y;

            return i + "," + j + "," + curentPlayer;
        }
    }
    public interface Iclick
    {
        void click(String x);
        void lockPanel();
        void reLoad();
        void update();
    }
}

