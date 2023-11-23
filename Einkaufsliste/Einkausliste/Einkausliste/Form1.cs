namespace Einkausliste
{
    public partial class Form1 : Form
    {
        double totalPrice = 0;
        List<object[]> liste = new List<object[]>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int amount = Convert.ToInt32(comboBox1.SelectedItem);
            double price = Convert.ToDouble(textBoxprice.Text);
            string name = textBoxname.Text;

            liste.Add(new object[] { name, amount, price });

            richTextBox1.Text = "Produkt name\t\t\tMenge\t\t\tPreis\t\t\t\t\tTotal\n\n";


            // shows the result 
            for (int i = 0; i < liste.Count; i++)
            {
                printZero(i);
            }
            Checked.Items.Add(liste);
        }
        void printZero(int zero)
        {
            showPrice((string)liste[zero][0], (int)liste[zero][1], (double)liste[zero][2]);
        }
        void showPrice(string nameProduct, int amount, double price)
        {

            double total = Math.Round(amount * price, 2);

            totalPrice = totalPrice + total;


            richTextBox1.Text += nameProduct + "\t\t" + amount + "\t\t\t\t\t" + price + "€" + "\t\t\t\t\t" + total + "€\n";

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Checked.Items.Clear();
                foreach (var item in liste)
                {
                    Checked.Items.Add(item, true);
                }
            }
            else
            {
                foreach (var item in liste)
                {
                    Checked.Items.Add(item, false);
                }
            }
        }
    }
}