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
            numberOfColorsLabel.Visible = false;
            numberOfColorstextBox.Visible = false;
            summaryTextBox.Text = " ";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            LogoOrderItem order = BuildOrder();
            string summary = order.GetOrderSummary();
            summaryTextBox.Visible = true;
            summaryTextBox.Text = summary;
        }

        private LogoOrderItem BuildOrder()
        {
            LogoOrderItem order = new LogoOrderItem();
            order.ItemID = Int32.Parse(OrderNumberTextBox.Text);
            order.NumItems = Int32.Parse(numberOfItemsTextBox.Text);
            order.TheText = textToEngraveTextBox.Text;
            order.ItemType = this.SelectedItemType;
            //order.HasLogo = this.SelectedHasLogo; 
            order.NumColors = Int32.Parse(numberOfColorstextBox.Text);
            return order;
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
                
            }
            else
            {
                numberOfColorsLabel.Visible = false;
                numberOfColorstextBox.Visible = false;
                numberOfColorstextBox.Text = "0";
            }
        }
    }
}
