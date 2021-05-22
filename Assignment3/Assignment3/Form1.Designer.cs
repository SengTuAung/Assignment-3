
namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        /// // 4-6-2021 Saung NEW 5L Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///// 4-6-2021 Saung NEW 5L  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.queueListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.orderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cheesecakeRadioButton = new System.Windows.Forms.RadioButton();
            this.pizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.burgerRadioButton = new System.Windows.Forms.RadioButton();
            this.completeButton = new System.Windows.Forms.Button();
            this.loadFromFileButton = new System.Windows.Forms.Button();
            this.saveToFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue:";
            // 
            // queueListBox
            // 
            this.queueListBox.FormattingEnabled = true;
            this.queueListBox.ItemHeight = 20;
            this.queueListBox.Location = new System.Drawing.Point(12, 32);
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.Size = new System.Drawing.Size(327, 384);
            this.queueListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount:";
            // 
            // amountUpDown
            // 
            this.amountUpDown.Location = new System.Drawing.Point(416, 30);
            this.amountUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountUpDown.Name = "amountUpDown";
            this.amountUpDown.Size = new System.Drawing.Size(64, 27);
            this.amountUpDown.TabIndex = 5;
            this.amountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(350, 189);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(113, 29);
            this.orderButton.TabIndex = 7;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cheesecakeRadioButton);
            this.groupBox1.Controls.Add(this.pizzaRadioButton);
            this.groupBox1.Controls.Add(this.burgerRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(350, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of order:";
            // 
            // cheesecakeRadioButton
            // 
            this.cheesecakeRadioButton.AutoSize = true;
            this.cheesecakeRadioButton.Location = new System.Drawing.Point(6, 86);
            this.cheesecakeRadioButton.Name = "cheesecakeRadioButton";
            this.cheesecakeRadioButton.Size = new System.Drawing.Size(107, 24);
            this.cheesecakeRadioButton.TabIndex = 2;
            this.cheesecakeRadioButton.Text = "Cheesecake";
            this.cheesecakeRadioButton.UseVisualStyleBackColor = true;
            // 
            // pizzaRadioButton
            // 
            this.pizzaRadioButton.AutoSize = true;
            this.pizzaRadioButton.Location = new System.Drawing.Point(6, 56);
            this.pizzaRadioButton.Name = "pizzaRadioButton";
            this.pizzaRadioButton.Size = new System.Drawing.Size(64, 24);
            this.pizzaRadioButton.TabIndex = 1;
            this.pizzaRadioButton.Text = "Pizza";
            this.pizzaRadioButton.UseVisualStyleBackColor = true;
            // 
            // burgerRadioButton
            // 
            this.burgerRadioButton.AutoSize = true;
            this.burgerRadioButton.Checked = true;
            this.burgerRadioButton.Location = new System.Drawing.Point(6, 26);
            this.burgerRadioButton.Name = "burgerRadioButton";
            this.burgerRadioButton.Size = new System.Drawing.Size(74, 24);
            this.burgerRadioButton.TabIndex = 0;
            this.burgerRadioButton.TabStop = true;
            this.burgerRadioButton.Text = "Burger";
            this.burgerRadioButton.UseVisualStyleBackColor = true;
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(350, 269);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(113, 29);
            this.completeButton.TabIndex = 9;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // loadFromFileButton
            // 
            this.loadFromFileButton.Location = new System.Drawing.Point(350, 387);
            this.loadFromFileButton.Name = "loadFromFileButton";
            this.loadFromFileButton.Size = new System.Drawing.Size(113, 29);
            this.loadFromFileButton.TabIndex = 10;
            this.loadFromFileButton.Text = "Load from file";
            this.loadFromFileButton.UseVisualStyleBackColor = true;
            this.loadFromFileButton.Click += new System.EventHandler(this.loadFromFileButton_Click);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(350, 352);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(113, 29);
            this.saveToFileButton.TabIndex = 11;
            this.saveToFileButton.Text = "Save to file";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 436);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.loadFromFileButton);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.amountUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.queueListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Restaurant order processing app";
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox queueListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amountUpDown;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cheesecakeRadioButton;
        private System.Windows.Forms.RadioButton pizzaRadioButton;
        private System.Windows.Forms.RadioButton burgerRadioButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button loadFromFileButton;
        private System.Windows.Forms.Button saveToFileButton;
    }
}

