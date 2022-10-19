using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;


namespace new_pwd
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var new_pwd_username = textBox1.Text;
            var new_pwd_password = textBox2.Text;
            Change C_pwd = new Change();
            try
            {
                C_pwd.Change_pwd(new_pwd_username,new_pwd_password);
                
            }
            catch (Exception)
            { return; }
           
        }
    }
}
