namespace Practica_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);

            if (num % 2 == 0) MessageBox.Show("El NÚMERO ES PAR");
            else
            {
                if (num % 3 == 0) MessageBox.Show("El NÚMERO ES IMPAR Y ES DIVISIBLE POR TRES");
                else MessageBox.Show("EL NÚMERO ES IMPAR Y NO ES DIVISIBLE POR TRES");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}