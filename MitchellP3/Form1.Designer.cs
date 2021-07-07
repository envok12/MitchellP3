
namespace MitchellP3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberOfItemsLabel = new System.Windows.Forms.Label();
            this.numberOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.penRadioButton = new System.Windows.Forms.RadioButton();
            this.mugRadioButton = new System.Windows.Forms.RadioButton();
            this.usbRadioButton = new System.Windows.Forms.RadioButton();
            this.textToEngraveLabel = new System.Windows.Forms.Label();
            this.textToEngraveTextBox = new System.Windows.Forms.TextBox();
            this.logoCheckBox = new System.Windows.Forms.CheckBox();
            this.numberOfColorsLabel = new System.Windows.Forms.Label();
            this.numberOfColorstextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(51, 48);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(99, 17);
            this.orderNumberLabel.TabIndex = 0;
            this.orderNumberLabel.Text = "Order Number";
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(195, 48);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.Size = new System.Drawing.Size(120, 22);
            this.OrderNumberTextBox.TabIndex = 1;
            // 
            // numberOfItemsLabel
            // 
            this.numberOfItemsLabel.AutoSize = true;
            this.numberOfItemsLabel.Location = new System.Drawing.Point(51, 92);
            this.numberOfItemsLabel.Name = "numberOfItemsLabel";
            this.numberOfItemsLabel.Size = new System.Drawing.Size(111, 17);
            this.numberOfItemsLabel.TabIndex = 2;
            this.numberOfItemsLabel.Text = "Number of Items";
            // 
            // numberOfItemsTextBox
            // 
            this.numberOfItemsTextBox.Location = new System.Drawing.Point(195, 89);
            this.numberOfItemsTextBox.Name = "numberOfItemsTextBox";
            this.numberOfItemsTextBox.Size = new System.Drawing.Size(120, 22);
            this.numberOfItemsTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.penRadioButton);
            this.groupBox1.Controls.Add(this.mugRadioButton);
            this.groupBox1.Controls.Add(this.usbRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(231, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Type";
            // 
            // penRadioButton
            // 
            this.penRadioButton.AutoSize = true;
            this.penRadioButton.Location = new System.Drawing.Point(28, 110);
            this.penRadioButton.Name = "penRadioButton";
            this.penRadioButton.Size = new System.Drawing.Size(54, 21);
            this.penRadioButton.TabIndex = 2;
            this.penRadioButton.TabStop = true;
            this.penRadioButton.Text = "Pen";
            this.penRadioButton.UseVisualStyleBackColor = true;
            // 
            // mugRadioButton
            // 
            this.mugRadioButton.AutoSize = true;
            this.mugRadioButton.Location = new System.Drawing.Point(28, 74);
            this.mugRadioButton.Name = "mugRadioButton";
            this.mugRadioButton.Size = new System.Drawing.Size(56, 21);
            this.mugRadioButton.TabIndex = 1;
            this.mugRadioButton.TabStop = true;
            this.mugRadioButton.Text = "Mug";
            this.mugRadioButton.UseVisualStyleBackColor = true;
            // 
            // usbRadioButton
            // 
            this.usbRadioButton.AutoSize = true;
            this.usbRadioButton.Location = new System.Drawing.Point(28, 38);
            this.usbRadioButton.Name = "usbRadioButton";
            this.usbRadioButton.Size = new System.Drawing.Size(57, 21);
            this.usbRadioButton.TabIndex = 0;
            this.usbRadioButton.TabStop = true;
            this.usbRadioButton.Text = "USB";
            this.usbRadioButton.UseVisualStyleBackColor = true;
            // 
            // textToEngraveLabel
            // 
            this.textToEngraveLabel.AutoSize = true;
            this.textToEngraveLabel.Location = new System.Drawing.Point(51, 134);
            this.textToEngraveLabel.Name = "textToEngraveLabel";
            this.textToEngraveLabel.Size = new System.Drawing.Size(140, 17);
            this.textToEngraveLabel.TabIndex = 5;
            this.textToEngraveLabel.Text = "Text to Engrave/print";
            // 
            // textToEngraveTextBox
            // 
            this.textToEngraveTextBox.Location = new System.Drawing.Point(54, 163);
            this.textToEngraveTextBox.Multiline = true;
            this.textToEngraveTextBox.Name = "textToEngraveTextBox";
            this.textToEngraveTextBox.Size = new System.Drawing.Size(132, 168);
            this.textToEngraveTextBox.TabIndex = 6;
            // 
            // logoCheckBox
            // 
            this.logoCheckBox.AutoSize = true;
            this.logoCheckBox.Location = new System.Drawing.Point(54, 353);
            this.logoCheckBox.Name = "logoCheckBox";
            this.logoCheckBox.Size = new System.Drawing.Size(70, 21);
            this.logoCheckBox.TabIndex = 7;
            this.logoCheckBox.Text = "Logo?";
            this.logoCheckBox.UseVisualStyleBackColor = true;
            this.logoCheckBox.CheckedChanged += new System.EventHandler(this.logoCheckBox_CheckedChanged);
            // 
            // numberOfColorsLabel
            // 
            this.numberOfColorsLabel.AutoSize = true;
            this.numberOfColorsLabel.Location = new System.Drawing.Point(51, 388);
            this.numberOfColorsLabel.Name = "numberOfColorsLabel";
            this.numberOfColorsLabel.Size = new System.Drawing.Size(118, 17);
            this.numberOfColorsLabel.TabIndex = 8;
            this.numberOfColorsLabel.Text = "Number of Colors";
            this.numberOfColorsLabel.Visible = false;
            // 
            // numberOfColorstextBox
            // 
            this.numberOfColorstextBox.Location = new System.Drawing.Point(189, 383);
            this.numberOfColorstextBox.Name = "numberOfColorstextBox";
            this.numberOfColorstextBox.Size = new System.Drawing.Size(36, 22);
            this.numberOfColorstextBox.TabIndex = 9;
            this.numberOfColorstextBox.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(274, 353);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(274, 397);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Location = new System.Drawing.Point(64, 453);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(285, 122);
            this.summaryTextBox.TabIndex = 12;
            this.summaryTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 587);
            this.Controls.Add(this.summaryTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numberOfColorstextBox);
            this.Controls.Add(this.numberOfColorsLabel);
            this.Controls.Add(this.logoCheckBox);
            this.Controls.Add(this.textToEngraveTextBox);
            this.Controls.Add(this.textToEngraveLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numberOfItemsTextBox);
            this.Controls.Add(this.numberOfItemsLabel);
            this.Controls.Add(this.OrderNumberTextBox);
            this.Controls.Add(this.orderNumberLabel);
            this.Name = "Form1";
            this.Text = "Logo Items Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.TextBox OrderNumberTextBox;
        private System.Windows.Forms.Label numberOfItemsLabel;
        private System.Windows.Forms.TextBox numberOfItemsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton penRadioButton;
        private System.Windows.Forms.RadioButton mugRadioButton;
        private System.Windows.Forms.RadioButton usbRadioButton;
        private System.Windows.Forms.Label textToEngraveLabel;
        private System.Windows.Forms.TextBox textToEngraveTextBox;
        private System.Windows.Forms.CheckBox logoCheckBox;
        private System.Windows.Forms.Label numberOfColorsLabel;
        private System.Windows.Forms.TextBox numberOfColorstextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox summaryTextBox;
    }
}

