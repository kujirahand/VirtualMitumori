namespace VirtualMitumori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInfo.Text = "�����ς���c�[��\r\n\r\nA��B�ɐ��l����͂��Čv�Z�{�^���������Ă��������B";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                b = Math.Floor(b / 1.3);
                double c = (a * b * 2.1) + 150;
                c = Math.Floor(c / 10) * 10;
                txtResult.Text = c.ToString();
            } catch {
                txtResult.Text = "(���̓G���[)";
            }
        }
    }
}