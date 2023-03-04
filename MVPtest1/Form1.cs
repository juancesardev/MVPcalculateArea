using MVPtest1.Presenters;
using MVPtest1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPtest1
{
    public partial class Form1 : Form, IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LengthText 
        {
            get { return txtLength.Text; }
            set { txtLength.Text = value; }
        }
        public string BreadthText 
        {
            get { return txtBreadth.Text;}
            set { txtBreadth.Text = value;}
        }
        public string AreaText 
        {
            get { return lblArea.Text; }
            set
            {
                lblArea.Text = value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateAreaText();
        }
    }
}
