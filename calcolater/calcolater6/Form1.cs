using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolater6
{
    public partial class Form1 : Form
    {
        double enterFirstValue, entersecondValue;
        string op;
        bool firestInput_AfterFunction = false;
        string[] eqution = new string[3];
        public Form1()
        {
            InitializeComponent();
        }

        void printToscren(string x)
        {
            if (firestInput_AfterFunction)
            {
                txtResalt.Text = "";
                
                firestInput_AfterFunction = false;
            }
            txtResalt.Text += x;
           // txtdesblay.Text += x;
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtResalt.Text == "0")
                txtResalt.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResalt.Text.Contains("."))
                        //txtResalt.Text = txtResalt.Text + num.Text;
                        printToscren(num.Text);
                }
                else
                {
                    //txtResalt.Text = txtResalt.Text + num.Text;
                    printToscren(num.Text);
                }

            }
        }

        private void butEqols_Click(object sender, EventArgs e)
        {
            entersecondValue = Convert.ToDouble(txtResalt.Text);
            txtdesblay.Text = " ";
            switch (op)
            {
                case "+":
                    txtResalt.Text = (enterFirstValue + entersecondValue).ToString();
                    break;

                case "-":
                    txtResalt.Text = (enterFirstValue - entersecondValue).ToString();
                    break;
                case "*":
                    txtResalt.Text = (enterFirstValue * entersecondValue).ToString();
                    break;
                case "/":
                    txtResalt.Text = (enterFirstValue / entersecondValue).ToString();
                    break;
                case "Mod":
                    txtResalt.Text = (enterFirstValue % entersecondValue).ToString();
                    break;

                case "Exp":
                    double i = Convert.ToDouble(txtResalt.Text);
                    double j;
                    j = entersecondValue;
                    txtResalt.Text = Math.Exp(i* Math.Log(j * 4)).ToString();
                    break;


                default:
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 320;//816
            txtResalt.Width = 280;
            txtdesblay.Width = 280;
        }

        private void butCler_Click(object sender, EventArgs e)
        {
            txtResalt.Text = "0";
            txtdesblay.Text = "";
        }

        private void butClerEntry_Click(object sender, EventArgs e)
        {
            txtResalt.Text = "0";
            txtdesblay.Text = "";
            string f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(entersecondValue);

            f = "";
            s = "";
        }

        private void butPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResalt.Text);
            txtResalt.Text = Convert.ToString(-1 * q);

            txtdesblay.Text = Convert.ToString(-1 * q);
        }

        private void butBS_Click(object sender, EventArgs e)
        {
            if (txtResalt.Text.Length > 0)
            {
                txtResalt.Text = txtResalt.Text.Remove(txtResalt.Text.Length - 1, 1);
                //txtdesblay.Text = txtdesblay.Text.Remove(txtdesblay.Text.Length - 1, 1);
            }

            if (txtResalt.Text == "")
            {
                txtResalt.Text = "0";
            }

            if (txtdesblay.Text.Length > 0)
            {
                txtdesblay.Text = txtdesblay.Text.Remove(txtdesblay.Text.Length - 1, 1);
            }

            if (txtdesblay.Text == "")
            {
                txtdesblay.Text = "";
            }

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 320;//816
            txtResalt.Width = 280;
            txtdesblay.Width = 280;
        }

        private void scoertficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 590;//816
            txtResalt.Width = 550;
            txtdesblay.Width = 550;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to exit", "scientific calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                
        }

        private void butPi_Click(object sender, EventArgs e)
        {
            txtResalt.Text = "3.141592653589976323";
            txtdesblay.Text = "3.141592653589976323";
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResalt.Text);
            logg = Math.Log10(logg);
            txtResalt.Text = Convert.ToString(logg);

            txtdesblay.Text = Convert.ToString(logg);
        }

        private void butsqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResalt.Text);
            sq = Math.Sqrt(sq);
            txtResalt.Text = Convert.ToString(sq);
            txtdesblay.Text = Convert.ToString(sq);
        }

        private void butx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResalt.Text) * Convert.ToDouble(txtResalt.Text);
            txtResalt.Text = Convert.ToString(x);
            txtdesblay.Text = Convert.ToString(x);
        }

        private void butx3_Click(object sender, EventArgs e)
        {
            double x , q , p , m;
            q = Convert.ToDouble(txtResalt.Text);
            p = Convert.ToDouble(txtResalt.Text);
            m = Convert.ToDouble(txtResalt.Text);

            x = (q*p*m);
            txtResalt.Text = Convert.ToString(x);
            txtdesblay.Text = Convert.ToString(x);
        }

        private void butSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResalt.Text);
            sh = Math.Sinh(sh);
            txtResalt.Text = Convert.ToString(sh);
            txtdesblay.Text = Convert.ToString(sh);
        }

        private void butSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResalt.Text);
            sin = Math.Sin(sin);
            txtResalt.Text = Convert.ToString(sin);
            txtdesblay.Text = Convert.ToString(sin);
        }

        private void butCosh_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(txtResalt.Text);
            cosh = Math.Cosh(cosh);
            txtResalt.Text = Convert.ToString(cosh);
            txtdesblay.Text = Convert.ToString(cosh);
        }

        private void butCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtResalt.Text);
            cos = Math.Cos(cos);
            txtResalt.Text = Convert.ToString(cos);
            txtdesblay.Text = Convert.ToString(cos);
        }

        private void butTanh_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txtResalt.Text);
            tanh = Math.Tanh(tanh);
            txtResalt.Text = Convert.ToString(tanh);
            txtdesblay.Text = Convert.ToString(tanh);
        }

        private void butTen_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResalt.Text);
            tan = Math.Tan(tan);
            txtResalt.Text = Convert.ToString(tan);
            txtdesblay.Text = Convert.ToString(tan);
        }

        private void but1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResalt.Text));
            txtResalt.Text = Convert.ToString(a);
            txtdesblay.Text = Convert.ToString(a);

        }

        private void butln_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtResalt.Text);
            lnx = Math.Log(lnx);
            txtResalt.Text = Convert.ToString(lnx);
            txtdesblay.Text = Convert.ToString(lnx);
        }

        private void butpre_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResalt.Text) / Convert.ToDouble(100);
            txtResalt.Text = Convert.ToString(a);
            txtdesblay.Text = Convert.ToString(a);
        }

        private void butDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResalt.Text);

            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResalt.Text = Convert.ToString(i2);
            txtdesblay.Text = Convert.ToString(i2);
        }

        private void butBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResalt.Text);
            txtResalt.Text = Convert.ToString(a, 2);
            txtdesblay.Text = Convert.ToString(a, 2);
        }

        private void butHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResalt.Text);
            txtResalt.Text = Convert.ToString(a, 16);
            txtdesblay.Text = Convert.ToString(a, 16);
        }

        private void butOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResalt.Text);
            txtResalt.Text = Convert.ToString(a, 8);
            txtdesblay.Text = Convert.ToString(a, 8);
        }

        private void txtResalt_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '+':
                    {
                        butAdd.PerformClick();
                    }break;
                case '-':
                    {
                        butSub.PerformClick();
                    }
                    break;
                case '*':
                    {
                        butmod.PerformClick();
                    }
                    break;
                case '/':
                    {
                        butDiv.PerformClick();
                    }
                    break;
                
                case (char)Keys.Back:

                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
                

            }
        }

        private void txtdesblay_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtdesblay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtResalt.Text);
            op = num.Text;
            txtdesblay.Text =Convert.ToString(enterFirstValue);

            txtdesblay.Text += op;///////////////
            firestInput_AfterFunction = true;
            //txtResalt.Text = "";
        }
    }
}
