using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle15
{
    public partial class Puzzle : Form
    {
        public Puzzle()
        {
            InitializeComponent();
            InitializePuzzle();
        }

        private void InitializePuzzle()
        {
            this.BackColor = Color.SlateBlue;
            this.Text = "Puzzle 15";
        }

        private void InitializeButtons()
        {
            Button button;
            for (int i = 1; i < 16; i++)
            {
                button = new (Button);
            }
        }
    }
}
