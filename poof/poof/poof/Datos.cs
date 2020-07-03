using System;
using System.Windows.Forms;

namespace poof
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardar guardar = new guardar();
            guardar.guardardatos(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Top llamar = new Top();
            llamar.Show();
        }
    }


        }

    