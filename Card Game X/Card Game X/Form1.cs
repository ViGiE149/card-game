using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Game_X
{
    public partial class Form1 : Form
    {

      
        List<cardInfor> myCards = new List<cardInfor>();


        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.x;
            computerCard.BackColor = Color.FromArgb(120, Color.Black);
            playerCard.BackColor = Color.FromArgb(120, Color.Black);


            myCards.Add(new cardInfor
            {
                cardValue = 1,
                path = Properties.Resources.As
            });

            myCards.Add(new cardInfor
            {
                cardValue = 2,
                path = Properties.Resources._2s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 3,
                path = Properties.Resources._3s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 4,
                path = Properties.Resources._4s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 5,
                path = Properties.Resources._5s
            });

            myCards.Add(new cardInfor
            {
                cardValue = 6,
                path = Properties.Resources._6s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 7,
                path = Properties.Resources._7s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 8,
                path = Properties.Resources._8s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 9,
                path = Properties.Resources._9s
            });

            myCards.Add(new cardInfor
            {
                cardValue = 10,
                path = Properties.Resources._10s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 11,
                path = Properties.Resources.Js
            });


            myCards.Add(new cardInfor
            {
                cardValue = 12,
                path = Properties.Resources.Qs
            });
            myCards.Add(new cardInfor
            {
                cardValue = 13,
                path = Properties.Resources.Ks
            });


            /////////////////////////////////////////////////////////
            ////////////////////diamond
            myCards.Add(new cardInfor
            {
                cardValue = 1,
                path = Properties.Resources.A
            });


            myCards.Add(new cardInfor
            {
                cardValue = 2,
                path = Properties.Resources._2
            });


            myCards.Add(new cardInfor
            {
                cardValue = 3,
                path = Properties.Resources._3
            });



            myCards.Add(new cardInfor
            {
                cardValue = 4,
                path = Properties.Resources._4
            });

            myCards.Add(new cardInfor
            {
                cardValue = 5,
                path = Properties.Resources._5
            });


            myCards.Add(new cardInfor
            {
                cardValue = 6,
                path = Properties.Resources._6
            });


            myCards.Add(new cardInfor
            {
                cardValue =7,
                path = Properties.Resources._7
            });


            myCards.Add(new cardInfor
            {
                cardValue = 8,
                path = Properties.Resources._8
            });

            myCards.Add(new cardInfor
            {
                cardValue = 9,
                path = Properties.Resources._9
            });


            myCards.Add(new cardInfor
            {
                cardValue = 10,
                path = Properties.Resources._10
            });


            myCards.Add(new cardInfor
            {
                cardValue = 11,
                path = Properties.Resources.J
            });


            myCards.Add(new cardInfor
            {
                cardValue = 12,
                path = Properties.Resources.Q
            });

            myCards.Add(new cardInfor
            {
                cardValue = 13,
                path = Properties.Resources.K
            });
            ////////////////////////////////////////////////////////
            ///////////////////////clubs

            myCards.Add(new cardInfor
            {
                cardValue = 1,
                path = Properties.Resources.Ac
            });


            myCards.Add(new cardInfor
            {
                cardValue = 2,
                path = Properties.Resources._2c
            });


            myCards.Add(new cardInfor
            {
                cardValue = 3,
                path = Properties.Resources._3c
            });

            myCards.Add(new cardInfor
            {
                cardValue = 4,
                path = Properties.Resources._4c
            });


            myCards.Add(new cardInfor
            {
                cardValue =5,
                path = Properties.Resources._5c
            });

            myCards.Add(new cardInfor
            {
                cardValue = 6,
                path = Properties.Resources._6h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 7,
                path = Properties.Resources._7c
            });


            myCards.Add(new cardInfor
            {
                cardValue = 8,
                path = Properties.Resources._8c
            });

            myCards.Add(new cardInfor
            {
                cardValue = 9,
                path = Properties.Resources._9c
            });


            myCards.Add(new cardInfor
            {
                cardValue = 10,
                path = Properties.Resources._10c
            });


            myCards.Add(new cardInfor
            {
                cardValue = 11,
                path = Properties.Resources.Jc
            });

            myCards.Add(new cardInfor
            {
                cardValue = 12,
                path = Properties.Resources.Qc
            });

            myCards.Add(new cardInfor
            {
                cardValue = 13,
                path = Properties.Resources.Kc
            });


            ////////////////////////////////////////////////////
            ///////hearts
            myCards.Add(new cardInfor
            {
                cardValue = 1,
                path = Properties.Resources.Ah
            });


            myCards.Add(new cardInfor
            {
                cardValue = 2,
                path = Properties.Resources._2h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 3,
                path = Properties.Resources._3h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 4,
                path = Properties.Resources._4h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 5,
                path = Properties.Resources._5h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 6,
                path = Properties.Resources._6h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 7,
                path = Properties.Resources._7h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 8,
                path = Properties.Resources._8h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 9,
                path = Properties.Resources._9h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 10,
                path = Properties.Resources._10h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 11,
                path = Properties.Resources.Jh
            });

            myCards.Add(new cardInfor
            {
                cardValue = 12,
                path = Properties.Resources.Qh
            });

            myCards.Add(new cardInfor
            {
                cardValue = 13,
                path = Properties.Resources.Kh
            });    



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dishBtn_Click(object sender, EventArgs e)
        {


            Random random = new Random();


            statusP.Text = "";
            statusC.Text = "";



            int randomizerC = random.Next(0, myCards.Count);
            int randomizerP = random.Next(0, myCards.Count);

            if (!roundCount.Text.Equals("26"))
            {
                roundCount.Text = Convert.ToString(Convert.ToInt32(roundCount.Text) + 1);
                computerCard.Image = (Image)myCards[randomizerC].path;
                playerCard.Image = (Image)myCards[randomizerP].path;

         

                if (myCards[randomizerP].cardValue > myCards[randomizerC].cardValue)
                {

                    playerScore.Text = Convert.ToString(Convert.ToInt32(playerScore.Text) + 1);
                    statusP.Text ="WIN🎊🎉";

                }
               
                if (myCards[randomizerP].cardValue < myCards[randomizerC].cardValue)
                {
                    computerScore.Text = Convert.ToString(Convert.ToInt32(computerScore.Text) + 1);
                    statusC.Text = "WIN🎊🎉";
                }

                 if (myCards[randomizerP].cardValue == myCards[randomizerC].cardValue)
                {
                    tiesCount.Text = Convert.ToString(Convert.ToInt32(tiesCount.Text) + 1);
                    statusC.Text = "TIE😒";
                    statusP.Text = "TIE😒";
                }


                myCards.RemoveAt(randomizerC);
                //MessageBox.Show(Convert.ToString(randomizerP));

                if (!Convert.ToString(randomizerP).Equals("0"))
                {
                    myCards.RemoveAt(randomizerP - 1);
                    //MessageBox.Show(Convert.ToString(myCards[randomizerP-1]));
                    cardsLeft.Text = Convert.ToString(Convert.ToInt32(myCards.Count));
                }
                else
                {
                    myCards.RemoveAt(randomizerP);
                    //MessageBox.Show(Convert.ToString(myCards[randomizerP-1]));
                    cardsLeft.Text = Convert.ToString(Convert.ToInt32(myCards.Count));

                }

            }
            else
            {
                MessageBox.Show("there are no more cards to dish start a new game!");
                roundCount.Text ="26";
            }





        }

        private void computerCard_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help\nthis a 2 player card game agaist the computer\n" + "two cards  will be dished at a time and winner id determined by the card with the \n" + "larger value" + "from one to" + " 13" +
                "with \nJack equal to 11\nQueen equal to 12\nking equal to 13");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void playerCard_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
        }
        private void cardsLeft_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("About\n thsi game was create by ........ no the ........");
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerScore.Text = "0";
            computerScore.Text = "0";
            statusP.Text = "";
            statusC.Text = "";
            roundCount.Text = "0";
            tiesCount.Text = "0";
            cardsLeft.Text = "-----";

            myCards.Clear();

            myCards.Add(new cardInfor
            {
                cardValue = 1,
                path = Properties.Resources.As 
            });

            myCards.Add(new cardInfor
            {
                cardValue = 2,
                path = Properties.Resources._2s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 3,
                path = Properties.Resources._3s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 4,
                path = Properties.Resources._4s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 5,
                path = Properties.Resources._5s
            });

            myCards.Add(new cardInfor
            {
                cardValue = 6,
                path = Properties.Resources._6s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 7,
                path = Properties.Resources._7s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 8,
                path = Properties.Resources._8s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 9,
                path = Properties.Resources._9s
            });

            myCards.Add(new cardInfor
            {
                cardValue = 10,
                path = Properties.Resources._10s
            });


            myCards.Add(new cardInfor
            {
                cardValue = 11,
                path = Properties.Resources.Js
            });


            myCards.Add(new cardInfor
            {
                cardValue = 12,
                path = Properties.Resources.Qs
            });
            myCards.Add(new cardInfor
            {
                cardValue = 13,
                path = Properties.Resources.Ks
            });


            /////////////////////////////////////////////////////////
            ////////////////////diamond
            myCards.Add(new cardInfor
            {
                cardValue = 1,
                path = Properties.Resources.A
            });


            myCards.Add(new cardInfor
            {
                cardValue = 2,
                path = Properties.Resources._2
            });


            myCards.Add(new cardInfor
            {
                cardValue = 3,
                path = Properties.Resources._3
            });



            myCards.Add(new cardInfor
            {
                cardValue = 4,
                path = Properties.Resources._4
            });

            myCards.Add(new cardInfor
            {
                cardValue = 5,
                path = Properties.Resources._5
            });


            myCards.Add(new cardInfor
            {
                cardValue = 6,
                path = Properties.Resources._6
            });


            myCards.Add(new cardInfor
            {
                cardValue = 7,
                path = Properties.Resources._7
            });


            myCards.Add(new cardInfor
            {
                cardValue = 8,
                path = Properties.Resources._8
            });

            myCards.Add(new cardInfor
            {
                cardValue = 9,
                path = Properties.Resources._9
            });


            myCards.Add(new cardInfor
            {
                cardValue = 10,
                path = Properties.Resources._10
            });


            myCards.Add(new cardInfor
            {
                cardValue = 11,
                path = Properties.Resources.J
            });


            myCards.Add(new cardInfor
            {
                cardValue = 12,
                path = Properties.Resources.Q
            });

            myCards.Add(new cardInfor
            {
                cardValue = 13,
                path = Properties.Resources.K
            });
            ////////////////////////////////////////////////////////
            ///////////////////////clubs

            myCards.Add(new cardInfor
            {
                cardValue = 1,
                path = Properties.Resources.Ac
            });


            myCards.Add(new cardInfor
            {
                cardValue = 2,
                path = Properties.Resources._2c
            });


            myCards.Add(new cardInfor
            {
                cardValue = 3,
                path = Properties.Resources._3c
            });

            myCards.Add(new cardInfor
            {
                cardValue = 4,
                path = Properties.Resources._4c
            });


            myCards.Add(new cardInfor
            {
                cardValue = 5,
                path = Properties.Resources._5c
            });

            myCards.Add(new cardInfor
            {
                cardValue = 6,
                path = Properties.Resources._6h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 7,
                path = Properties.Resources._7c
            });


            myCards.Add(new cardInfor
            {
                cardValue = 8,
                path = Properties.Resources._8c
            });

            myCards.Add(new cardInfor
            {
                cardValue = 9,
                path = Properties.Resources._9c
            });


            myCards.Add(new cardInfor
            {
                cardValue = 10,
                path = Properties.Resources._10c
            });


            myCards.Add(new cardInfor
            {
                cardValue = 11,
                path = Properties.Resources.Jc
            });

            myCards.Add(new cardInfor
            {
                cardValue = 12,
                path = Properties.Resources.Qc
            });

            myCards.Add(new cardInfor
            {
                cardValue = 13,
                path = Properties.Resources.Kc
            });


            ////////////////////////////////////////////////////
            ///////hearts
            myCards.Add(new cardInfor
            {
                cardValue = 1,
                path = Properties.Resources.Ah
            });


            myCards.Add(new cardInfor
            {
                cardValue = 2,
                path = Properties.Resources._2h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 3,
                path = Properties.Resources._3h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 4,
                path = Properties.Resources._4h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 5,
                path = Properties.Resources._5h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 6,
                path = Properties.Resources._6h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 7,
                path = Properties.Resources._7h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 8,
                path = Properties.Resources._8h
            });

            myCards.Add(new cardInfor
            {
                cardValue = 9,
                path = Properties.Resources._9h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 10,
                path = Properties.Resources._10h
            });


            myCards.Add(new cardInfor
            {
                cardValue = 11,
                path = Properties.Resources.Jh
            });

            myCards.Add(new cardInfor
            {
                cardValue = 12,
                path = Properties.Resources.Qh
            });

            myCards.Add(new cardInfor
            {
                cardValue = 13,
                path = Properties.Resources.Kh
            });









        }
    }
}

class cardInfor
{
   public string cardd { get; set; }
   public int cardValue { get; set; }

    public Image  path { get; set; }

}

