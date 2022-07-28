# Spirthack Loader Design

The design of the SpirtHack loader has been tried to be the same. It is not exactly the same.

# How to use

Download the source file on your computer, then edit it as much as you want. 

- [Discord](https://discord.gg/jyhCw8mvWu) - Our discord address
- [Spoffer#9400]

```Code Information
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spirthack_loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Hide();
            label3.Hide();
            load.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (usernameTXT.Text == "")
            {
                label1.Hide();
                if (passwordTXT.Text == "")
                {
                    label3.Show(); label3.Hide(); 
                }
                else { label3.Hide(); }

            }
            else { label1.Hide(); label1.Show(); timer1.Start(); }
            
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load.Visible = true;
            timer2.Start();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            load.Visible = false;
            timer2.Stop();
        }
    }
}


```
<img src="https://cdn.discordapp.com/attachments/996464921883705444/1002279154936451102/unknown.png"/>
<img src="https://cdn.discordapp.com/attachments/996464921883705444/1002279154936451102/unknown.png"/>  
