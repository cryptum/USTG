using Login.Model;
using Login.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ControleFalta : Form
    {
        ControleDeFaltaM controledefalta = new ControleDeFaltaM();
        ControleDeFaltaC controledefaltaDao = new ControleDeFaltaC();
        public ControleFalta()
        {
            InitializeComponent();
        }

        private void ControleFalta_Load(object sender, EventArgs e)
        {
        
        }
    }
}
