using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_Raman
{
    public partial class Form1 : Form
    {
        photoLoad instance = new photoLoad();
        fire instance_obj = null;

        Random obj = new Random();
        int rd = 0,clk=0,clk2=0,sht = 0;
        public Form1()
        {
            
            InitializeComponent();

            instance_obj = new fire();
            btnFill.Enabled = false;
            btnRevolve.Enabled = false;
            btnFire.Enabled = false;
            btnFireAway.Enabled = false;

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            instance.start(pictureBox1);
            btnStart.Enabled = false;
            btnFill.Enabled = true;

            
            rd = obj.Next(1, 7);
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            instance.fill(pictureBox1);
            btnFill.Enabled = false;
            btnRevolve.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            instance.revolve(pictureBox1);

            btnRevolve.Enabled = false;
            btnFire.Enabled = true;
            btnFireAway.Enabled = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            // count the clik and then generate the sound of the bulllet 
            clk++;
            sht++;

            instance_obj.frstchance();


            instance.fire(pictureBox1);

            if (rd == sht)
            {
                MessageBox.Show("Shooted: You are dead ");
                Application.Restart();
            }
            else {
                MessageBox.Show("Shoot missed: you are alive  ");
            }

            

            // when we click six times then the trigger is automatically disabled
            if (sht == 6)
            {
                MessageBox.Show("you survived ");
                Application.Restart();
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            clk2++;
            sht++;

            instance_obj.frstchance();

            instance.fire(pictureBox1);
            

            if (rd == sht)
            {
                MessageBox.Show("you survived ");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Shoot Awayed");
            }

            

            if (clk2 == 2)
            {
                btnFireAway.Enabled = false;
               
             
            }
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
