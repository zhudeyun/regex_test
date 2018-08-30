using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool CheckSN(string sn)
        {
            if (sn.Length <= 0)
                return false;
            Regex regex = new Regex("^[A-Za-z0-9]{13}$");   //13位长字母与数字
            bool result = regex.IsMatch(sn);
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sn = textBox1.Text.Trim();
            Result.Text = CheckSN(sn).ToString();
        }
    }
}
