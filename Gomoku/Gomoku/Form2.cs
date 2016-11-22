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

            //Magic happens here ;)
            _Buttons = new Button[324];

            for (int index = 0; index < 324; index++)
            {
                createButton(x, y, index);

                if (x < 17)
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

            // Horizontal-Check
            if ((_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 1].BackColor == Color.Red && _Buttons[Index_ - 2].BackColor == Color.Red && _Buttons[Index_ - 3].BackColor == Color.Red && _Buttons[Index_ - 4].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ + 1].BackColor == Color.Red && _Buttons[Index_ + 2].BackColor == Color.Red && _Buttons[Index_ + 3].BackColor == Color.Red && _Buttons[Index_ + 4].BackColor == Color.Red))
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            if ((_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_-1].BackColor == Color.Blue && _Buttons[Index_ - 2].BackColor == Color.Blue && _Buttons[Index_ - 3].BackColor == Color.Blue && _Buttons[Index_ - 4].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ + 1].BackColor == Color.Blue && _Buttons[Index_ + 2].BackColor == Color.Blue && _Buttons[Index_ + 3].BackColor == Color.Blue && _Buttons[Index_ + 4].BackColor == Color.Blue))
            {
                MessageBox.Show("Spieler 2 hat gewonnen!","Gewonnen!");
                this.Close();
            }

            // Vertikal-Check
            if ((_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 18].BackColor == Color.Red && _Buttons[Index_ - 36].BackColor == Color.Red && _Buttons[Index_ - 54].BackColor == Color.Red && _Buttons[Index_ - 72].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ + 18].BackColor == Color.Red && _Buttons[Index_ + 36].BackColor == Color.Red && _Buttons[Index_ + 54].BackColor == Color.Red && _Buttons[Index_ + 72].BackColor == Color.Red))
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            if ((_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 18].BackColor == Color.Blue && _Buttons[Index_ - 36].BackColor == Color.Blue && _Buttons[Index_ - 54].BackColor == Color.Blue && _Buttons[Index_ - 72].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ + 18].BackColor == Color.Blue && _Buttons[Index_ + 36].BackColor == Color.Blue && _Buttons[Index_ + 54].BackColor == Color.Blue && _Buttons[Index_ + 72].BackColor == Color.Blue))
            {
                MessageBox.Show("Spieler 2 hat gewonnen!", "Gewonnen!");
                this.Close();
            }

            // Quer-Check
            //Rechts
            if ((_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 17].BackColor == Color.Red && _Buttons[Index_ - 34].BackColor == Color.Red && _Buttons[Index_ - 51].BackColor == Color.Red && _Buttons[Index_ - 68].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ + 17].BackColor == Color.Red && _Buttons[Index_ + 34].BackColor == Color.Red && _Buttons[Index_ + 51].BackColor == Color.Red && _Buttons[Index_ + 68].BackColor == Color.Red))
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            if ((_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 17].BackColor == Color.Blue && _Buttons[Index_ - 34].BackColor == Color.Blue && _Buttons[Index_ - 51].BackColor == Color.Blue && _Buttons[Index_ - 68].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ + 17].BackColor == Color.Blue && _Buttons[Index_ + 34].BackColor == Color.Blue && _Buttons[Index_ + 51].BackColor == Color.Blue && _Buttons[Index_ + 68].BackColor == Color.Blue))
            {
                MessageBox.Show("Spieler 2 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            //Links
            if ((_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ - 19].BackColor == Color.Red && _Buttons[Index_ - 38].BackColor == Color.Red && _Buttons[Index_ - 57].BackColor == Color.Red && _Buttons[Index_ - 76].BackColor == Color.Red) || (_Buttons[Index_].BackColor == Color.Red && _Buttons[Index_ + 19].BackColor == Color.Red && _Buttons[Index_ + 38].BackColor == Color.Red && _Buttons[Index_ + 57].BackColor == Color.Red && _Buttons[Index_ + 76].BackColor == Color.Red))
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Gewonnen!");
                this.Close();
            }
            if ((_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ - 19].BackColor == Color.Blue && _Buttons[Index_ - 38].BackColor == Color.Blue && _Buttons[Index_ - 57].BackColor == Color.Blue && _Buttons[Index_ - 76].BackColor == Color.Blue) || (_Buttons[Index_].BackColor == Color.Blue && _Buttons[Index_ + 19].BackColor == Color.Blue && _Buttons[Index_ + 38].BackColor == Color.Blue && _Buttons[Index_ + 57].BackColor == Color.Blue && _Buttons[Index_ + 76].BackColor == Color.Blue))
            {
                MessageBox.Show("Spieler 2 hat gewonnen!", "Gewonnen!");
                this.Close();
            }

        }

    }
}
