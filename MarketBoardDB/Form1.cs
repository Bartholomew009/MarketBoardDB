using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace MarketBoardDB
{
    public partial class Form1 : Form
    {
        public static string connect = "Data Source = C:\\Users\\tachikmoa\\Documents\\School\\SQLsp16\\Market.db; Version=3;";
        SQLiteConnection me = new SQLiteConnection(connect);
        
        public Form1()
        {
            InitializeComponent();
            me.Open();
            string getTables = "SELECT name FROM Market.sqlite_master WHERE type = 'table';";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblItem_Click(object sender, EventArgs e)
        {

        }
    }
}
