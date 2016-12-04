using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Button[] _Buttons;
        public int playCounter = 1;
        public Form2()
        {
            InitializeComponent();
            initializeField();
        }

        private void initializeField()
        {
            this.SuspendLayout();

            int x = 0;
            int y = 0;

            //Generate Buttons
            _Buttons = new Button[441];

            for (int index = 0; index < 441; index++) //324
            {
                createButton(x, y, index);

                if (x < 20)
                {
                    x++;
                }
                else
                {
                    x = 0;
                    y++;
                }
            }
            this.ResumeLayout();
        }
        
        //Button Properties/Info/Position etc. 
        private void createButton(int X_, int Y_, int Index_)
        {
            this._Buttons[Index_] = new System.Windows.Forms.Button();
            this._Buttons[Index_].Location = new System.Drawing.Point(X_ * 30, Y_ * 30);
            this._Buttons[Index_].Name = "button" + Index_.ToString();
            this._Buttons[Index_].Size = new System.Drawing.Size(30, 30);
            this._Buttons[Index_].TabIndex = 0;
            this._Buttons[Index_].UseVisualStyleBackColor = true;
            _Buttons[Index_].Click += (sender1, ex) => this.OnButtonClick(Index_);

            this.Controls.Add(this._Buttons[Index_]);
        }

        public void OnButtonClick(int Index_)
        {
            //Player Determination / Colors
            playCounter += 1;
            if (playCounter % 2 == 0)
            {
                _Buttons[Index_].BackColor = Color.Red;
                _Buttons[Index_].Enabled = false;
                this.Text = "Gomoku - Spiel (Spieler 2 ist am Zug.)";
            } else {
                _Buttons[Index_].BackColor = Color.Blue;
                _Buttons[Index_].Enabled = false;
                this.Text = "Gomoku - Spiel (Spieler 1 ist am Zug.)";
            }
            
            /* Game Logic :Start: */
            // Horizontal-Check
            //Player 1
            if (/*Scenario 1*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 1].BackColor == Color.Red && _Buttons[Index_ - 2].BackColor == Color.Red && _Buttons[Index_ - 3].BackColor == Color.Red && _Buttons[Index_ - 4].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ + 1].BackColor == Color.Red && _Buttons[Index_ + 2].BackColor == Color.Red && _Buttons[Index_ + 3].BackColor == Color.Red && _Buttons[Index_ + 4].BackColor == Color.Red) ||
                /*Scenario 2*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ + 1].BackColor == Color.Red && _Buttons[Index_ - 1].BackColor == Color.Red && _Buttons[Index_ - 2].BackColor == Color.Red && _Buttons[Index_ - 3].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 1].BackColor == Color.Red && _Buttons[Index_ + 1].BackColor == Color.Red && _Buttons[Index_ + 2].BackColor == Color.Red && _Buttons[Index_ + 3].BackColor == Color.Red) ||
                /*Scenario 3*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 1].BackColor == Color.Red && _Buttons[Index_ - 2].BackColor == Color.Red && _Buttons[Index_ + 1].BackColor == Color.Red && _Buttons[Index_ + 2].BackColor == Color.Red))
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            //Player 2
            if (/*Scenario 1*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_- 1].BackColor == Color.Blue && _Buttons[Index_ - 2].BackColor == Color.Blue && _Buttons[Index_ - 3].BackColor == Color.Blue && _Buttons[Index_ - 4].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ + 1].BackColor == Color.Blue && _Buttons[Index_ + 2].BackColor == Color.Blue && _Buttons[Index_ + 3].BackColor == Color.Blue && _Buttons[Index_ + 4].BackColor == Color.Blue) ||
                /*Scenario 2*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ + 1].BackColor == Color.Blue && _Buttons[Index_ - 1].BackColor == Color.Blue && _Buttons[Index_ - 2].BackColor == Color.Blue && _Buttons[Index_ - 3].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 1].BackColor == Color.Blue && _Buttons[Index_ + 1].BackColor == Color.Blue && _Buttons[Index_ + 2].BackColor == Color.Blue && _Buttons[Index_ + 3].BackColor == Color.Blue) ||
                /*Scenario 3*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 1].BackColor == Color.Blue && _Buttons[Index_ - 2].BackColor == Color.Blue && _Buttons[Index_ + 1].BackColor == Color.Blue && _Buttons[Index_ + 2].BackColor == Color.Blue))
            {
                MessageBox.Show("Spieler 2 hat gewonnen!","Gewonnen!");
                this.Close();
            }

            // Vertical-Check
            // Player 1
            if (/*Scenario 1*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 21].BackColor == Color.Red && _Buttons[Index_ - 42].BackColor == Color.Red && _Buttons[Index_ - 63].BackColor == Color.Red && _Buttons[Index_ - 84].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ + 21].BackColor == Color.Red && _Buttons[Index_ + 42].BackColor == Color.Red && _Buttons[Index_ + 63].BackColor == Color.Red && _Buttons[Index_ + 84].BackColor == Color.Red) ||
                /*Scenario 2*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 21].BackColor == Color.Red && _Buttons[Index_ + 21].BackColor == Color.Red && _Buttons[Index_ + 42].BackColor == Color.Red && _Buttons[Index_ + 63].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 21].BackColor == Color.Red && _Buttons[Index_ - 42].BackColor == Color.Red && _Buttons[Index_ - 63].BackColor == Color.Red && _Buttons[Index_ + 21].BackColor == Color.Red) ||
                /*Scenario 3*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 21].BackColor == Color.Red && _Buttons[Index_ - 42].BackColor == Color.Red && _Buttons[Index_ + 21].BackColor == Color.Red && _Buttons[Index_ + 42].BackColor == Color.Red))
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            //Player 2
            if (/*Scenario 1*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 21].BackColor == Color.Blue && _Buttons[Index_ - 42].BackColor == Color.Blue && _Buttons[Index_ - 63].BackColor == Color.Blue && _Buttons[Index_ - 84].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ + 21].BackColor == Color.Blue && _Buttons[Index_ + 42].BackColor == Color.Blue && _Buttons[Index_ + 63].BackColor == Color.Blue && _Buttons[Index_ + 84].BackColor == Color.Blue) ||
                /*Scenario 2*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 21].BackColor == Color.Blue && _Buttons[Index_ + 21].BackColor == Color.Blue && _Buttons[Index_ + 42].BackColor == Color.Blue && _Buttons[Index_ + 63].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 21].BackColor == Color.Blue && _Buttons[Index_ - 42].BackColor == Color.Red && _Buttons[Index_ - 63].BackColor == Color.Blue && _Buttons[Index_ + 21].BackColor == Color.Blue) ||
                /*Scenario 3*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 21].BackColor == Color.Blue && _Buttons[Index_ - 42].BackColor == Color.Blue && _Buttons[Index_ + 21].BackColor == Color.Blue && _Buttons[Index_ + 42].BackColor == Color.Blue))
            {
                MessageBox.Show("Spieler 2 hat gewonnen!", "Gewonnen!");
                this.Close();
            }

            // Crosswise-Check
            //Right
            //Player 1
            if (/*Scenario 1*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 20].BackColor == Color.Red && _Buttons[Index_ - 40].BackColor == Color.Red && _Buttons[Index_ - 60].BackColor == Color.Red && _Buttons[Index_ - 80].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ + 20].BackColor == Color.Red && _Buttons[Index_ + 40].BackColor == Color.Red && _Buttons[Index_ + 60].BackColor == Color.Red && _Buttons[Index_ + 80].BackColor == Color.Red) ||
                /*Scenario 2*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 20].BackColor == Color.Red && _Buttons[Index_ - 40].BackColor == Color.Red && _Buttons[Index_ - 60].BackColor == Color.Red && _Buttons[Index_ + 20].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 20].BackColor == Color.Red && _Buttons[Index_ + 20].BackColor == Color.Red && _Buttons[Index_ + 40].BackColor == Color.Red && _Buttons[Index_ + 60].BackColor == Color.Red) ||
                /*Scenario 3*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 20].BackColor == Color.Red && _Buttons[Index_ - 40].BackColor == Color.Red && _Buttons[Index_ + 20].BackColor == Color.Red && _Buttons[Index_ + 40].BackColor == Color.Red))
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            //Player 2
            if (/*Scenario 1*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 20].BackColor == Color.Blue && _Buttons[Index_ - 40].BackColor == Color.Blue && _Buttons[Index_ - 60].BackColor == Color.Blue && _Buttons[Index_ - 80].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ + 20].BackColor == Color.Blue && _Buttons[Index_ + 40].BackColor == Color.Blue && _Buttons[Index_ + 60].BackColor == Color.Blue && _Buttons[Index_ + 80].BackColor == Color.Blue) ||
                /*Scenario 2*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 20].BackColor == Color.Blue && _Buttons[Index_ - 40].BackColor == Color.Blue && _Buttons[Index_ - 60].BackColor == Color.Blue && _Buttons[Index_ + 20].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 20].BackColor == Color.Blue && _Buttons[Index_ + 20].BackColor == Color.Blue && _Buttons[Index_ + 40].BackColor == Color.Blue && _Buttons[Index_ + 60].BackColor == Color.Blue) ||
                /*Scenario 3*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 20].BackColor == Color.Blue && _Buttons[Index_ - 40].BackColor == Color.Blue && _Buttons[Index_ + 20].BackColor == Color.Blue && _Buttons[Index_ + 40].BackColor == Color.Blue))
            {
                MessageBox.Show("Spieler 2 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            //Left
            //Player 1
            if (/*Scenario 1*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 22].BackColor == Color.Red && _Buttons[Index_ - 44].BackColor == Color.Red && _Buttons[Index_ - 66].BackColor == Color.Red && _Buttons[Index_ - 88].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ + 22].BackColor == Color.Red && _Buttons[Index_ + 44].BackColor == Color.Red && _Buttons[Index_ + 66].BackColor == Color.Red && _Buttons[Index_ + 88].BackColor == Color.Red) ||
                /*Scenario 2*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 22].BackColor == Color.Red && _Buttons[Index_ - 44].BackColor == Color.Red && _Buttons[Index_ - 66].BackColor == Color.Red && _Buttons[Index_ + 22].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 22].BackColor == Color.Red && _Buttons[Index_ + 22].BackColor == Color.Red && _Buttons[Index_ + 44].BackColor == Color.Red && _Buttons[Index_ + 66].BackColor == Color.Red) ||
                /*Scenario 3*/(_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 22].BackColor == Color.Red && _Buttons[Index_ - 44].BackColor == Color.Red && _Buttons[Index_ + 22].BackColor == Color.Red && _Buttons[Index_ + 44].BackColor == Color.Red))
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            //Player 2
            if (/*Scenario 1*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 22].BackColor == Color.Blue && _Buttons[Index_ - 44].BackColor == Color.Blue && _Buttons[Index_ - 66].BackColor == Color.Blue && _Buttons[Index_ - 88].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ + 22].BackColor == Color.Blue && _Buttons[Index_ + 44].BackColor == Color.Blue && _Buttons[Index_ + 66].BackColor == Color.Blue && _Buttons[Index_ + 88].BackColor == Color.Blue) ||
                /*Scenario 2*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 22].BackColor == Color.Blue && _Buttons[Index_ - 44].BackColor == Color.Blue && _Buttons[Index_ - 66].BackColor == Color.Blue && _Buttons[Index_ + 22].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 22].BackColor == Color.Blue && _Buttons[Index_ + 22].BackColor == Color.Blue && _Buttons[Index_ + 44].BackColor == Color.Blue && _Buttons[Index_ + 66].BackColor == Color.Blue) ||
                /*Scenario 3*/(_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 22].BackColor == Color.Blue && _Buttons[Index_ - 44].BackColor == Color.Blue && _Buttons[Index_ + 22].BackColor == Color.Blue && _Buttons[Index_ + 44].BackColor == Color.Blue))
            {
                MessageBox.Show("Spieler 2 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            /* Game Logic :End: */
        }

    }
}
