namespace Number_generator
{
    public partial class RandomNumberGenerator : Form
    {
        private int minValue;
        private int maxValue;
        public RandomNumberGenerator()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //save
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(fileName, true))
                    {
                        writer.WriteLine(textBox3.Text);
                    }
                    MessageBox.Show("Числото е записано успешно във файл: " + fileName);
                }
            }
            else
            {
                MessageBox.Show("Няма генерирани числа за запис.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //random

            if (int.TryParse(textBox1.Text, out minValue) && int.TryParse(textBox3.Text, out maxValue))
            {
                if (minValue <= maxValue)
                {
                    
                    Random random = new Random();
                    int randomNumber = random.Next(minValue, maxValue + 1);
                    textBox2.Text = randomNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Минималната стойност трябва да бъде по-малка или равна на максималната стойност.");
                }


            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}