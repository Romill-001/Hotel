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
        }
        public char c;
        public new string FullName
        {
            get { return fullName.Text; }
            set { fullName.Text = value; }
        }
        public new string BDay
        {
            get { return BirthDay.Text; }
            set { BirthDay.Text = value; }
        }
        public new string Payment
        {
            get { return PaymentLabel.Text; }
            set { PaymentLabel.Text = value; }
        }
        public new string Days
        {
            get { return DaysLabel.Text; }
            set { DaysLabel.Text = value; }
        }
        public new char Animals
        {
            get 
            {
                return c; 
            }
            set 
            {
                if (value == '1')
                {
                    AnimalsCheck.Checked = true;
                }
                else
                {
                    AnimalsCheck.Checked = false;
                }
            }
        }
    }
}
