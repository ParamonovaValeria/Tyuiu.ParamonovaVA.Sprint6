using Tyuiu.ParamonovaVA.Sprint6.Task2.V18.Lib;

namespace Tyuiu.ParamonovaVA.Sprint6.Task2.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonRun_PVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PVA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_PVA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_PVA.Titles.Add(" ");

                this.chartFunction_PVA.ChartAreas[0].AxisX.Title = " X";
                this.chartFunction_PVA.ChartAreas[0].AxisY.Title = " Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_PVA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_PVA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_PVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы РППб-24-1 Парамонова Валерия Алексеевна", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRun_MouseEnter(object sender, EventArgs e)
        {
            buttonRun_PVA.BackColor = Color.Red;
        }

        private void buttonRun_MouseLeave(object sender, EventArgs e)
        {
            buttonRun_PVA.BackColor = Color.Green;
        }

        private void textBoxStart_PVA_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }

        private void buttonRun_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRun_PVA.BackColor = Color.Blue;
        }
    }
}