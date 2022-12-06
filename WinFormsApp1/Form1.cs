namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int m, n;
        public int[,] arr;

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        richTextBox1.AppendText($"{arr[i,j]} ");
                    }
                    richTextBox1.AppendText("\n");
                }
            }
            catch
            {
                MessageBox.Show("Ну ты и дибил");
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                m = Convert.ToInt32(textBoxM.Text);
                n = Convert.ToInt32(textBoxN.Text);
                arr = new int[m, n];
                dataGridView1.RowCount = n;
                dataGridView1.ColumnCount = m;
            }
            catch
            {
                MessageBox.Show("Ну ты и дибил");
            }
        }
    }
}