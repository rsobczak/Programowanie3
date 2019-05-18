using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace KK
{
    public partial class Form1 : Form
    {
        private KK game;

        public Form1()
        {
            InitializeComponent();
        }

        private void kkStartBtn_Click(object sender, EventArgs e)
        {
            if (usrInpA.Text.Trim().Length == 0 || usrInpB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Podaj imiona graczy");
            }
            else
            {
                helloPanel.Visible = false;
                kkStartBtn.Visible = false;
                gamePanel.Visible = true;
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;

                turnA.Text = "O " + usrInpA.Text;
                turnB.Text = "X " + usrInpB.Text;

                game = new KK();

                if (game.whoMoves())
                {
                    turnA.Font = new Font(userLblA.Font, FontStyle.Bold);
                }
                else
                {
                    turnB.Font = new Font(userLblB.Font, FontStyle.Bold);
                }
            }
        }

        private void handlePBClick(int r, int c, PictureBox pb)
        {
            if (game.doTurn(r, c))
            {
                if (game.getSymbolAt(r, c) == 'X')
                {
                    pb.Image = Properties.Resources.krzyzyk;
                }

                if (game.getSymbolAt(r, c) == 'O')
                {
                    pb.Image = Properties.Resources.kolko;
                }

                if (game.isEnd())
                {
                    int result = game.whoWon();
                    String desc = "";

                    if (result == 2)
                    {
                        desc = "REMIS";
                    } else if (result == 0)
                    {
                        desc = "KRZYZYK";
                    } else
                    {
                        desc = "KOLKO";
                    }
                    MessageBox.Show("Koniec gry. Werdykt: " + desc, "Koniec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    restartBtn.Visible = true;
                    gamePanel.Enabled = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("To pole jest w użyciu", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (game.whoMoves())
            {
                turnA.Font = new Font(userLblA.Font, FontStyle.Bold);
                turnB.Font = new Font(userLblA.Font, FontStyle.Regular);
            }
            else
            {
                turnA.Font = new Font(userLblA.Font, FontStyle.Regular);
                turnB.Font = new Font(userLblB.Font, FontStyle.Bold);
            }
        }

        private void box00_Click(object sender, EventArgs e)
        {
            handlePBClick(0, 0, (PictureBox)sender);
        }

        private void box01_Click(object sender, EventArgs e)
        {
            handlePBClick(0, 1, (PictureBox)sender);
        }

        private void box02_Click(object sender, EventArgs e)
        {
            handlePBClick(0, 2, (PictureBox)sender);
        }

        private void box10_Click(object sender, EventArgs e)
        {
            handlePBClick(1, 0, (PictureBox)sender);
        }

        private void box11_Click(object sender, EventArgs e)
        {
            handlePBClick(1, 1, (PictureBox)sender);
        }

        private void box12_Click(object sender, EventArgs e)
        {
            handlePBClick(1, 2, (PictureBox)sender);
        }

        private void box20_Click(object sender, EventArgs e)
        {
            handlePBClick(2, 0, (PictureBox)sender);
        }

        private void box21_Click(object sender, EventArgs e)
        {
            handlePBClick(2, 1, (PictureBox)sender);
        }

        private void box22_Click(object sender, EventArgs e)
        {
            handlePBClick(2, 2, (PictureBox)sender);
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            box00.Image = null;
            box01.Image = null;
            box02.Image = null;
            box10.Image = null;
            box20.Image = null;
            box11.Image = null;
            box21.Image = null;
            box12.Image = null;
            box22.Image = null;

            game = new KK();

            if (game.whoMoves())
            {
                turnA.Font = new Font(userLblA.Font, FontStyle.Bold);
                turnB.Font = new Font(userLblA.Font, FontStyle.Regular);
            }
            else
            {
                turnA.Font = new Font(userLblA.Font, FontStyle.Regular);
                turnB.Font = new Font(userLblB.Font, FontStyle.Bold);
            }

            gamePanel.Enabled = true;
        }
    }
}
