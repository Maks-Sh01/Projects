using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameComplexMaksymShatalov
{


    public partial class FormTicTacToe : MaterialForm
    {
        bool xTurn = true;
        private int turnCount = 0;
        private bool player1Turn = true;
        bool gameOver = false;
        public FormTicTacToe()
        {
            InitializeComponent();
        }

       
        private void FormTicTacToe_Load(object sender, EventArgs e)
        {

        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;
            senderB.Text = "X";
            if(xTurn)
            {
                senderB.Text = "X";
                senderB.ForeColor = Color.Red;

            }
            else
            {
                senderB.Text = "O";
                senderB.ForeColor = Color.Blue;
            }
            xTurn = !xTurn;
            turnCount++;
            senderB.Enabled = false;
            CheckWin(senderB);
            if (!gameOver)
            {
                if (xTurn)
                {
                    lblTurn.Text = "Хід X";
                }
                else
                {
                    lblTurn.Text = "Хід O";
                }
            }
        }
        void CheckWin(Button pressedButton)
        {
            bool thereIsAWinner = false;
            if (b1.Text == b2.Text && b2.Text == b3.Text && b2.Enabled == false)
            {
                lblWin.Text = "Перемогли " + pressedButton.Text;
                gameOver = true;

                lblTurn.Text = "Гру закінчено";
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                xTurn = false;
                thereIsAWinner = true;
                DialogResult dialogResult = MessageBox.Show("Хочете зіграти ще раз ?", "Хрестики нолики", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            if (b4.Text == b5.Text && b5.Text == b6.Text && b5.Enabled == false)
            {
                lblWin.Text = "Перемогли " + pressedButton.Text;
                gameOver = true;
                lblTurn.Text = "Гру закінчено";
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                xTurn = false;
                thereIsAWinner = true;
                DialogResult dialogResult = MessageBox.Show("Хочете зіграти ще раз ?", "Хрестики нолики", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (b7.Text == b8.Text && b8.Text == b9.Text && b9.Enabled == false)
            {
                lblWin.Text = "Перемогли " + pressedButton.Text;
                gameOver = true;
                lblTurn.Text = "Гру закінчено";
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;
                xTurn = false;
                thereIsAWinner = true;
                DialogResult dialogResult = MessageBox.Show("Хочете зіграти ще раз ?", "Хрестики нолики", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (b1.Text == b4.Text && b4.Text == b7.Text && b7.Enabled == false)
            {
                lblWin.Text = "Перемогли " + pressedButton.Text;
                gameOver = true;
                lblTurn.Text = "Гру закінчено";
                b5.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                xTurn = false;
                thereIsAWinner = true;
                DialogResult dialogResult = MessageBox.Show("Хочете зіграти ще раз ?", "Хрестики нолики", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (b2.Text == b5.Text && b5.Text == b8.Text && b8.Enabled == false)
            {
                lblWin.Text = "Перемогли " + pressedButton.Text;
                gameOver = true;
                lblTurn.Text = "Гру закінчено";
                b1.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b6.Enabled = false;
                b9.Enabled = false;
                xTurn = false;
                thereIsAWinner = true;
                DialogResult dialogResult = MessageBox.Show("Хочете зіграти ще раз ?", "Хрестики нолики", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            if (b3.Text == b6.Text && b6.Text == b9.Text && b9.Enabled == false)
            {
                lblWin.Text = "Перемогли " + pressedButton.Text;
                gameOver = true;
                lblTurn.Text = "Гру закінчено";
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                xTurn = false;
                thereIsAWinner = true;
                DialogResult dialogResult = MessageBox.Show("Хочете зіграти ще раз ?", "Хрестики нолики", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (b1.Text == b5.Text && b5.Text == b9.Text && b9.Enabled == false)
            {
                lblWin.Text = "Перемогли " + pressedButton.Text;
                gameOver = true;
                lblTurn.Text = "Гру закінчено";
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                xTurn = false;
                thereIsAWinner = true;
                DialogResult dialogResult = MessageBox.Show("Хочете зіграти ще раз ?", "Хрестики нолики", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            if (b3.Text == b5.Text && b5.Text == b7.Text && b7.Enabled == false)
            {
                lblWin.Text = "Перемогли " + pressedButton.Text;
                gameOver = true;
                b1.Enabled = false;
                b2.Enabled = false;
                b4.Enabled = false;
                b6.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                lblTurn.Text = "Гру закінчено";
                xTurn = false;
                thereIsAWinner = true;
                DialogResult dialogResult = MessageBox.Show("Хочете зіграти ще раз ?", "Хрестики нолики", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            if (turnCount == 9)
            {
                MessageBox.Show("Нічия", "Гра", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gameOver = true;
                lblWin.Text = "Нічия";
                lblTurn.Text = "Гру закінчено";
                DialogResult dialogResult = MessageBox.Show("Хочете зіграти ще раз ?", "Хрестики нолики", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NewGame();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }




        }
     


        void NewGame()
        {
            player1Turn = true;
            turnCount = 0;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            lblTurn.Text = "";
            lblWin.Text = "";
            gameOver = false;
        }
       

        private void btnback_Click(object sender, EventArgs e)
        {
            FormTicTacToe.ActiveForm.Visible = false;
        }

     
        private void новаГраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
