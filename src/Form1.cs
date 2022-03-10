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
            txtInfo.Text = "■見積もりツール\r\n\r\nAとBに数値を入力して計算ボタンを押してください。";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(txtA.Text);
                double b = Double.Parse(txtB.Text);
                double c = a * b / 2.0;
                txtResult.Text = c.ToString();
            } catch {
                txtResult.Text = "(入力エラー)";
            }
        }
    }
}