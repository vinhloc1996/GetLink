using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetLink
{
    public partial class player : Form
    {
        public player(string url)
        {
            InitializeComponent();

            wmp.URL = @url;
        }

        private void player_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmp.close();
        }
    }
}
