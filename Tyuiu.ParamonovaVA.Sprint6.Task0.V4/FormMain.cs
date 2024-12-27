using Tyuiu.ParamonovaVA.Sprint6.Task0.V4.Lib;

namespace Tyuiu.ParamonovaVA.Sprint6.Task0.V4
{
   public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX.Text)));
            }
            catch
            {
                MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) ;
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttoninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы РППб-24-1 Парамонова Валерия Алексеевна");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
