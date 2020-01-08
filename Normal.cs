using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneIndividual
{
    public partial class Normal : Form
    {
        bool boolVal = true;
        string strMove = "";
        private int[] boardArray = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        int intCounterX = 0;
        int intCounterO = 0;
        private Player playerX, playerO;

        public Normal()
        {
            InitializeComponent();
             playerX = new Player("test");
             playerO = new Player("test2");
        }

        string Turn(string m, int arrayValue)
        {
            if (boolVal == true)
            {
                strMove = "X";
                boardArray[arrayValue] = 0;
                boolVal = false;
            }
            else
            {
                strMove = "O";
                boardArray[arrayValue] = 1;
                boolVal = true;
            }

            return strMove;
        }

        string BoardClear()
        {
            boardArray = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            strMove = "";
            boolVal = true;
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";

            return strMove;
        }

        private void whichSymbol(int possibleWinner)
        {
            if (possibleWinner == 0)
            {
                playerX.UpdateWins();
                playerX.UpdateTime(intCounterX);
                playerO.UpdateLosses();
                DialogResult message = MessageBox.Show(playerX.Name + " won in " + intCounterX + " seconds. \n" + "You have won " + playerX.Wins + " times. \n" + "You have had a draw game " + playerX.Draws + " times. \n" + "You have lost " + playerX.Losses + " times. \n" + "Your fastest game was " + playerX.Fastest + " seconds. \n" + "Play Again?", "Winner!", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    BoardClear();
                }
                else
                    Application.Exit();
            }
            else
            {
                playerO.UpdateWins();
                playerO.UpdateTime(intCounterO);
                playerX.UpdateLosses();
                DialogResult message = MessageBox.Show(playerO.Name + " won in " + intCounterO + " seconds. \n" + "You have won " + playerO.Wins + " times. \n" + "You have had a draw game " + playerO.Draws + " times. \n" + "You have lost " + playerO.Losses + " times. \n" + "Your fastest game was " + playerO.Fastest + " seconds. \n" + "Play Again?", "Winner!", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    BoardClear();
                }

                else
                    Application.Exit();
            }
        }

        private int checkForWin()
        {
            // Checks for horizontal win
            int possibleWinner = -1;
            for (int i = 0; i <= 6; i += 3)
            {
                possibleWinner = boardArray[i];
                if (possibleWinner != -1 && boardArray[i + 1] == possibleWinner && boardArray[i + 2] == possibleWinner)
                {
                    whichSymbol(possibleWinner);
                    return possibleWinner;
                }
            }
            possibleWinner = -1;

            // Checks for vertical win
            for (int i = 0; i < 3; i += 1)
            {
                possibleWinner = boardArray[i];
                if (possibleWinner != -1 && boardArray[i + 3] == possibleWinner && boardArray[i + 6] == possibleWinner)
                {
                    whichSymbol(possibleWinner);
                    return boardArray[i];
                }
            }
            possibleWinner = -1;

            // Checks for diagonal win from top left to bottom right
            possibleWinner = boardArray[0];
            if (possibleWinner != -1 && boardArray[4] == possibleWinner && boardArray[8] == possibleWinner)
            {
                whichSymbol(possibleWinner);
                return boardArray[0];
            }
            possibleWinner = -1;

            // Checks for diagonal win from bottom left to top right
            possibleWinner = boardArray[2];
            if (possibleWinner != -1 && boardArray[4] == possibleWinner && boardArray[6] == possibleWinner)
            {
                whichSymbol(possibleWinner);
                return boardArray[2];
            }
            possibleWinner = -1;

            // Checks if the array is full
            bool boolFilled = true;
            foreach (int i in boardArray)
            {
                if (i == -1)
                {
                    boolFilled = false;
                }
            }

            // Happens if the whole array is filled, whichever counter has a lower value determines the winner, displays a message box to show how long it took the winner and their current stats, and gives players the option to play again or stop
            if (boolFilled)
            {
                if (intCounterX < intCounterO)
                {
                    playerX.UpdateWins();
                    playerX.UpdateDraws();
                    playerX.UpdateTime(intCounterX);
                    playerO.UpdateDraws();
                    playerO.UpdateLosses();
                    DialogResult message = MessageBox.Show("It was a draw, but " + playerX.Name + "made their moves faster. It took them " + intCounterX + " seconds. \n" + "You have won " + playerX.Wins + " times. \n" + "You have had a draw game " + playerO.Draws + " times. \n" + "You have lost " + playerX.Losses + " times. \n" + "Your fastest game was " + playerX.Fastest + " seconds. \n" + "Play Again?", "Draw!", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        BoardClear();
                    }
                    else
                        Application.Exit();
                }
                else
                {
                    playerO.UpdateWins();
                    playerO.UpdateDraws();
                    playerO.UpdateTime(intCounterO);
                    playerX.UpdateDraws();
                    playerX.UpdateLosses();
                    DialogResult message = MessageBox.Show("It was a draw, but " + playerO.Name + " made their moves faster. It took them " + intCounterO + " seconds. \n" + "You have won " + playerO.Wins + " times. \n" + "You have had a draw game " + playerO.Draws + " times. \n" + "You have lost " + playerO.Losses + " times. \n" + "Your fastest game was " + playerO.Fastest + " seconds. \n" + "Play Again?", "Draw!", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        BoardClear();
                    }
                    else
                        Application.Exit();
                }
            }

            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turn(strMove, 0);
            button1.Text = strMove;
            button1.Enabled = false;
            checkForWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turn(strMove, 0);
            button2.Text = strMove;
            button2.Enabled = false;
            checkForWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Turn(strMove, 0);
            button3.Text = strMove;
            button3.Enabled = false;
            checkForWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Turn(strMove, 0);
            button4.Text = strMove;
            button4.Enabled = false;
            checkForWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Turn(strMove, 0);
            button5.Text = strMove;
            button5.Enabled = false;
            checkForWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Turn(strMove, 0);
            button6.Text = strMove;
            button6.Enabled = false;
            checkForWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Turn(strMove, 0);
            button7.Text = strMove;
            button7.Enabled = false;
            checkForWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Turn(strMove, 0);
            button8.Text = strMove;
            button8.Enabled = false;
            checkForWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Turn(strMove, 0);
            button9.Text = strMove;
            button9.Enabled = false;
            checkForWin();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (boolVal == true)
                intCounterX++;
            else
                intCounterO++;
        }

    }
}
