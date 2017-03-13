namespace example03
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.product1Button = new System.Windows.Forms.Button();
            this.product2Button = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.orderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.tableCcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // product1Button
            // 
            this.product1Button.Location = new System.Drawing.Point(39, 60);
            this.product1Button.Name = "product1Button";
            this.product1Button.Size = new System.Drawing.Size(120, 45);
            this.product1Button.TabIndex = 0;
            this.product1Button.Text = "button1";
            this.product1Button.UseVisualStyleBackColor = true;
            this.product1Button.Click += new System.EventHandler(this.product1Button_Click);
            // 
            // product2Button
            // 
            this.product2Button.Location = new System.Drawing.Point(211, 59);
            this.product2Button.Name = "product2Button";
            this.product2Button.Size = new System.Drawing.Size(108, 46);
            this.product2Button.TabIndex = 1;
            this.product2Button.Text = "button2";
            this.product2Button.UseVisualStyleBackColor = true;
            this.product2Button.Click += new System.EventHandler(this.product2Button2_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(385, 18);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(33, 12);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "label1";
            // 
            // orderRichTextBox
            // 
            this.orderRichTextBox.Location = new System.Drawing.Point(41, 193);
            this.orderRichTextBox.Name = "orderRichTextBox";
            this.orderRichTextBox.Size = new System.Drawing.Size(465, 157);
            this.orderRichTextBox.TabIndex = 3;
            this.orderRichTextBox.Text = "";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(211, 13);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "button1";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // accountButton
            // 
            this.accountButton.Location = new System.Drawing.Point(359, 60);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(100, 45);
            this.accountButton.TabIndex = 5;
            this.accountButton.Text = "button1";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // tableCcomboBox
            // 
            this.tableCcomboBox.FormattingEnabled = true;
            this.tableCcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.tableCcomboBox.Location = new System.Drawing.Point(39, 13);
            this.tableCcomboBox.Name = "tableCcomboBox";
            this.tableCcomboBox.Size = new System.Drawing.Size(121, 20);
            this.tableCcomboBox.TabIndex = 6;
            this.tableCcomboBox.SelectedIndexChanged += new System.EventHandler(this.tableCcomboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 362);
            this.Controls.Add(this.tableCcomboBox);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.orderRichTextBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.product2Button);
            this.Controls.Add(this.product1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button product1Button;
        private System.Windows.Forms.Button product2Button;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.RichTextBox orderRichTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.ComboBox tableCcomboBox;
    }
}

