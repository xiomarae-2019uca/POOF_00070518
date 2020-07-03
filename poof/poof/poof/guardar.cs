using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace poof
{
    public class guardar
    {
        public void guardardatos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();   
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox) txt).SelectedIndex = 0;
                }
                {
                    
                }
            }
           
        }
    }
}