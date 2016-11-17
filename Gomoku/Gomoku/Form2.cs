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
            _Buttons[Index_].Click += (sender1, ex) => this.ColorAdding(Index_);

            this.Controls.Add(this._Buttons[Index_]);

        }

        public void ColorAdding(int Index_)
        {
            playCounter += 1;
            if (playCounter % 2 == 0)
            {
                _Buttons[Index_].BackColor = Color.Red;
                _Buttons[Index_].Enabled = false;
                this.Text = "Gomoku - Spiel (Spieler 2 ist am Zug.)";
            } else
            {
                _Buttons[Index_].BackColor = Color.Blue;
                _Buttons[Index_].Enabled = false;
                this.Text = "Gomoku - Spiel (Spieler 1 ist am Zug.)";
            }
        }

    }
}
