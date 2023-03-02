using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelHW
{
    public partial class CardOfClient : Form
    {
        public CardOfClient()
        {
            InitializeComponent();
            using (var t = new MainForm())
            {
                fullName.Text = t.FullName.ToString();
            }
        }
    }
}
