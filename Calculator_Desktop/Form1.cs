using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Desktop
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
            txtShowType.Text = "Padrão";
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0" && num.Text != ",")
                txtResult.Text = num.Text;
            else
            {
                if (num.Text == ",")
                {
                    if (!txtResult.Text.Contains(","))
                    {
                        txtResult.Text = txtResult.Text + num.Text;
                    }
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void NumberOp(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            if (op == "exp")
            {
                txtHistoric.Text = (enterFirstValue + " " + "^").ToString();
            }
            else
            {
                txtHistoric.Text = (enterFirstValue + " " + op).ToString();
            }
            txtResult.Text = "";
        }

        private void padrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 316;
            txtResult.Width = 280;
            txtHistoric.Width = 280;
            txtShowType.Text = "Padrão";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3,1415926535897932384626433832795";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txtResult.Text);
            sqrt = Math.Sqrt(sqrt);
            txtHistoric.Text = ("√" + "(" + txtResult.Text + ")").ToString();
            txtResult.Text = Convert.ToString(sqrt);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtHistoric.Text = "";

            String f, s;

            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtHistoric.Text = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);

            switch (op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    txtHistoric.Text = (enterFirstValue + " " + op + " " + enterSecondValue + " " + "=").ToString();
                    break;

                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    txtHistoric.Text = (enterFirstValue + " " + op + " " + enterSecondValue + " " + "=").ToString();
                    break;

                case "÷":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    txtHistoric.Text = (enterFirstValue + " " + op + " " + enterSecondValue + " " + "=").ToString();
                    break;

                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    txtHistoric.Text = (enterFirstValue + " " + op + " " + enterSecondValue + " " + "=").ToString();
                    break;

                case "exp":
                    double baseValue = enterFirstValue;
                    double exponent = enterSecondValue;

                    double result = Math.Pow(baseValue, exponent);
                    txtResult.Text = result.ToString();
                    txtHistoric.Text = (enterFirstValue + " " + "^" + " " + enterSecondValue + " = " + result).ToString();
                    break;

                case "mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                    txtHistoric.Text = (enterFirstValue + " " + op + " " + enterSecondValue + " " + "=").ToString();
                    break;

                default:
                    break;
            }
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sinh = Convert.ToDouble(txtResult.Text);
            sinh = Math.Sinh(sinh);
            txtResult.Text = Convert.ToString(sinh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "2,7182818284590452353602874713527";
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(txtResult.Text);
            cosh = Math.Cosh(cosh);
            txtResult.Text = Convert.ToString(cosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txtResult.Text);
            tanh = Math.Tanh(tanh);
            txtResult.Text = Convert.ToString(tanh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(a);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = Convert.ToString(a);
        }

        private void btnlx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtResult.Text);
            lnx = Math.Log(lnx);
            txtResult.Text = Convert.ToString(lnx);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void BtnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 536;
            txtResult.Width = 501;
            txtHistoric.Width = 501;
            txtShowType.Text = "Científica";
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(txtResult.Text);

            if (number < 0)
            {
                txtResult.Text = "Erro";
                txtHistoric.Text = "Não é possível calcular o fatorial de um número negativo.";
                return;
            }

            double result = CalculateFactorial(number);

            txtResult.Text = result.ToString();
            txtHistoric.Text = "fact( " + number + " )";
        }
        private double CalculateFactorial(double n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 316;
            txtResult.Width = 280;
            txtHistoric.Width = 280;
        }
    }
}  
