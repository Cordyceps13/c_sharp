using CustomControls.RJControls;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Campos
        Double resultado = 0;
        private string operacao = string.Empty;
        private string primNum, secNum;
        private bool insercaoValores = false;
        private Point _mouseLocation;
        public Form1()
        {
            InitializeComponent();
        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseLocation = e.Location;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    this.Location.X + e.X - _mouseLocation.X,
                    this.Location.Y + e.Y - _mouseLocation.Y
                );
            }
        }

        private void BtnNumClick(object sender, EventArgs e)
        {
            if (Display1.Text == "0" || insercaoValores)
                Display1.Text = string.Empty;

            insercaoValores = false;

            //if (resultado != 0)
            //{
            //    Display1.Text = string.Empty;
            //}

            RJButton btn = (RJButton)sender;
            if (btn.Text == ",")
            {
                if (!Display1.Text.Contains(","))
                    Display1.Text += btn.Text;

            }
            else
                Display1.Text += btn.Text;
        }

        private void BtnOperacaoClick(object sender, EventArgs e)
        {
            if (resultado != 0)
                BtnIgual.PerformClick();
            else
                resultado = Double.Parse(Display1.Text);

            RJButton btn = (RJButton)sender;
            operacao = btn.Text;
            insercaoValores = true;

            if (Display1.Text != "0")
            {
                Display2.Text = primNum = $"{resultado} {operacao}";
                Display1.Text = string.Empty;
            }
        }

        private void BtnIgualClick(object sender, EventArgs e)
        {
            secNum = Display1.Text;
            Display2.Text = $"{Display2.Text} {Display1.Text} =";

            if (Display1.Text != string.Empty)
            {
                if (Display1.Text == "0")
                {
                    Display2.Text = string.Empty;
                }
                switch (operacao)
                {
                    case "+":
                        Display1.Text = (resultado + Double.Parse(Display1.Text)).ToString();
                        RtBoxDisplay.AppendText($"{primNum} {secNum} = {Display1.Text}\n");
                        break;
                    case "−":
                        Display1.Text = (resultado - Double.Parse(Display1.Text)).ToString();
                        RtBoxDisplay.AppendText($"{primNum} {secNum} = {Display1.Text}\n");
                        break;
                    case "×":
                        Display1.Text = (resultado * Double.Parse(Display1.Text)).ToString();
                        RtBoxDisplay.AppendText($"{primNum} {secNum} = {Display1.Text}\n");
                        break;
                    case "÷":
                        Display1.Text = (resultado / Double.Parse(Display1.Text)).ToString();
                        RtBoxDisplay.AppendText($"{primNum} {secNum} = {Display1.Text}\n");
                        break;
                    default:
                        Display2.Text = $"{Display1.Text} = ";
                        break;
                }
                resultado = Double.Parse(Display1.Text);
                operacao = string.Empty;
                //RtBoxDisplay.AppendText($"{Display1.Text} = {secNum}\n");
            }
            else
            {
                RtBoxDisplay = null;
            }
        }

        private void historicoClick(object sender, EventArgs e)
        {
            PainelInferior.Height = (PainelInferior.Height == 1) ? PainelInferior.Height = 345 : 1;
            if (RtBoxDisplay.Text == string.Empty)
            {
                RtBoxDisplay.Text = "Ainda não existe histórico\n";
            }
        }

        private void BtnLimparHistClick(object sender, EventArgs e)
        {
            RtBoxDisplay.Clear();
            if (RtBoxDisplay.Text == string.Empty)
            {
                RtBoxDisplay.Text = "Ainda não existe histórico\n";
            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            if (Display1.Text.Length >= 0)
            {
                Display1.Text = Display1.Text.Remove(Display1.Text.Length - 1, 1);
            }
            if (Display1.Text == string.Empty)
            {
                Display1.Text = "0";
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            Display1.Text = "0";
            Display2.Text = string.Empty;
            resultado = 0;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            Display1.Text = "0";
        }

        private void BtnOperacaoSpec(object sender, EventArgs e)
        {
            RJButton btn = (RJButton)sender;
            operacao = btn.Text;

            switch (operacao)
            {
                case "²√𝑥":
                    Display2.Text = $"√{Display1.Text}";
                    Display1.Text = Convert.ToString(Math.Sqrt(Double.Parse(Display1.Text)));
                    break;
                case "𝑥²":
                    Display2.Text = $"{Display1.Text}²";
                    Display1.Text = Convert.ToString(Convert.ToDouble(Display1.Text) * Convert.ToDouble(Display1.Text));
                    break;
                case "¹/𝑥":
                    Display2.Text = $"¹/({Display1.Text})";
                    Display1.Text = Convert.ToString(1.0 / Convert.ToDouble(Display1.Text));
                    break;
                case "%":
                    Display2.Text = $"%({Display1.Text})";
                    Display1.Text = Convert.ToString(Convert.ToDouble(Display1.Text) * 0.1);
                    break;
                case "+/-":
                    Display1.Text = Convert.ToString(-1 * Convert.ToDouble(Display1.Text));
                    break;
                default:
                    break;
            }
            RtBoxDisplay.AppendText($"{Display2.Text} = {Display1.Text}\n");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }
}
