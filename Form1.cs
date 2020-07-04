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
            InitializePuzzleBlocks();
        }

        private void InitializePuzzle()
        {
            this.BackColor = Color.DarkSlateBlue;
            this.Text = "Puzzle 15";
            this.ClientSize = new Size(500, 500);
        }

        private void InitializePuzzleBlocks()
        {
            int blockCount = 1;
            PuzzleBlock block;
            for (int row = 1; row < 5; row++)
            {
                for (int col = 1; col < 5; col++)
                {
                    block = new PuzzleBlock();
                    block.Top = row * 84;
                    block.Left = col * 84;
                    block.Text = blockCount.ToString();

                    block.Click += new EventHandler(Block_Click);

                    if (blockCount == 16)
                    {
                        block.Name = "Emptyblock";
                        block.Text = string.Empty;
                        block.BackColor = Color.SlateGray;
                    }
                    this.Controls.Add(block);
                    blockCount++;
                }

            }
        }

        private void Block_Click (object sender, EventArgs e)
        {
            Button block = (Button)sender;
            if (IsAdjanced(block))
            {
                SwapBlocks(block);
            }
        }

        private void SwapBlocks(Button block)
        {
            Button emptyBlock = (Button)this.Controls["EmptyBlock"];
            Point oldLocation = block.Location;
            block.Location = emptyBlock.Location;
            emptyBlock.Location = oldLocation;
        }

        private bool IsAdjanced (Button block)
        {
            double a;
            double b;
            double c;
            Button emptyBlock = (Button)this.Controls["EmptyBlock"];
            a = Math.Abs(emptyBlock.Top - block.Top);
            b = Math.Abs(emptyBlock.Left - block.Left);
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            if (c < 85)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
