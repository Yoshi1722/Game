using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcje_Click(object sender, EventArgs e)
        {
            Form2 fk = new Form2();

            Color foreColor = button2.ForeColor;
            fk.Kolor2 = foreColor;
            Color foreColor1 = button1.ForeColor;
            fk.Kolor2 = foreColor1;
            if (fk.ShowDialog() == DialogResult.OK)
            {
                button2.ForeColor = fk.Kolor1;
                button1.ForeColor = fk.Kolor2;
                
            }
        }

       
    }
}