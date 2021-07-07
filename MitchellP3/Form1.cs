using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MitchellP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            OrderNumberTextBox.Text = " ";
            numberOfItemsTextBox.Text = " ";
            textToEngraveTextBox.Text = " ";
            usbRadioButton.Checked = false;
            mugRadioButton.Checked = false;
            penRadioButton.Checked = false;
            logoCheckBox.Checked = false;
            summaryTextBox.Text = " ";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            LogoOrderItem order = BuildOrder();
            string summary = GetOrderSummary(order);
            summaryTextBox.Text = summary;
        }

        private LogoOrderItem BuildOrder()
        {
            LogoOrderItem order = new LogoOrderItem();
            order.ItemID = Int32.Parse(OrderNumberTextBox.Text);
            order.NumItems = Int32.Parse(numberOfItemsTextBox.Text);
            order.TheText = textToEngraveTextBox.Text;
            order.ItemType = this.SelectedItemType;
            order.HasLogo = this.SelectedHasLogo; //needs these to get info from props/meths below
            order.NumColors = this.SelectedNumColors;
            return order;
        }

        private LogoOrderItem GetOrderSummary(LogoOrderItem order)
        {
            string summary =
                "Order number: " + order.ItemID + "\r" +
                order.NumItems + " " + order.ItemType +
                " with a " + order.NumColors + "logo with the following text: " +
                order.TheText +
                "\r\nPrice: " + order.TotalPrice;

            return summary;
          
        }

        private string SelectedItemType 
        {
            get
            {
                if (usbRadioButton.Checked)
                {
                    return "USB";
                }
                else if (mugRadioButton.Checked)
                {
                    return "Mug";
                }
                else if (penRadioButton.Checked)
                {
                    return "Pen";
                }
                else
                {
                    return "none";
                }
            }
        }

        private void logoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (logoCheckBox.Checked)
            {
                numberOfColorsLabel.Visible = true;
                numberOfColorstextBox.Visible = true;
                
            }else
            {
                numberOfColorstextBox = "0";
            }
        }


    }
}
