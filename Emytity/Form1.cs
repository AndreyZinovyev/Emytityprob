using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emytity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user u = new user();
            u.login = textBox1.Text;
            u.pass = textBox2.Text;
            using (DBEntities DB = new DBEntities())
            {
                DB.user.Add(u);
                DB.SaveChanges();
                List<user> userlist = new List<user>();
                userlist = DB.user.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.user". При необходимости она может быть перемещена или удалена.
         //   this.userTableAdapter.Fill(this.dBDataSet.user);

        }
    }
}
