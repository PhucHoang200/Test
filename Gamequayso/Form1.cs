using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamequayso
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Timer timerStop = new Timer();
        public Form1()
        {
            InitializeComponent();

            timerStop.Interval = 5000; 
            timerStop.Tick += new EventHandler(timerStop_Tick);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            timer1.Start();
            timer2.Start();
            timer3.Start();

            timerStop.Start();
            if (int.Parse(textBox1.Text) < 20)
            {
                MessageBox.Show("Số tiền hiện tại nhỏ hơn 20, vui lòng nạp thêm xu để tiếp tục chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBox1.Text = (int.Parse(textBox1.Text) - 20).ToString();
            timer1_Tick(sender, e);
            timer2_Tick(sender, e);
            timer3_Tick(sender, e);

        }

        private void timerStop_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timerStop.Stop();


        
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "100";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "100";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int randomNumber = random.Next(0, 8);
            label1.Text = randomNumber.ToString();

           

            int currentValue;
            if (int.TryParse(textBox1.Text, out currentValue))
            {
                if (randomNumber == 7)
                {
                    currentValue += 30;
                }
                textBox1.text = currentValue.ToString();

                

                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int randomNumber = random.Next(0, 9);
            label2.Text = randomNumber.ToString();

            if (randomNumber == 7)
            {
                int currentValue;
                if (int.TryParse(textBox1.Text, out currentValue))
                {
                    currentValue += 40;
                    
                }
               
              
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int randomNumber = random.Next(0, 9);
            label3.Text = randomNumber.ToString();

            if (randomNumber == 7)
            {
                int currentValue;
                if (int.TryParse(textBox1.Text, out currentValue))
                {
                    currentValue += 50;
                    
                }
               
                
            }
        }
    }
}
