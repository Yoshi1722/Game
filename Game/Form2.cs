using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        public Color Kolor1
        {
            get
            {
                return button1.ForeColor;
            }

            set
            {
                button1.ForeColor = value;
            }

        }
        public Color Kolor2
        {
            get
            {
                return button2.ForeColor;
            }

            set
            {
                button2.ForeColor = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ColorDialog bc = new ColorDialog();
            bc.Color = Kolor2;
            if (bc.ShowDialog() == DialogResult.OK)
            {
                Kolor2 = bc.Color;
            }
        }
    }
}
