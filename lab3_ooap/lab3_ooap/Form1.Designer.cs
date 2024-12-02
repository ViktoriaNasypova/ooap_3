namespace lab3_ooap
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.rbtnFullPayment = new System.Windows.Forms.RadioButton();
            this.rbtnCredit = new System.Windows.Forms.RadioButton();
            this.rbtnInstallment = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter the base price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(244, 49);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(112, 26);
            this.txtBasePrice.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Final price";
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.Location = new System.Drawing.Point(128, 317);
            this.txtFinalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.Size = new System.Drawing.Size(112, 26);
            this.txtFinalPrice.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Insurance scheme";
            // 
            // txtInsurance
            // 
            this.txtInsurance.Location = new System.Drawing.Point(187, 249);
            this.txtInsurance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(350, 26);
            this.txtInsurance.TabIndex = 16;
            // 
            // rbtnFullPayment
            // 
            this.rbtnFullPayment.AutoSize = true;
            this.rbtnFullPayment.Location = new System.Drawing.Point(187, 101);
            this.rbtnFullPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnFullPayment.Name = "rbtnFullPayment";
            this.rbtnFullPayment.Size = new System.Drawing.Size(119, 24);
            this.rbtnFullPayment.TabIndex = 17;
            this.rbtnFullPayment.TabStop = true;
            this.rbtnFullPayment.Text = "full payment";
            this.rbtnFullPayment.UseVisualStyleBackColor = true;
            this.rbtnFullPayment.CheckedChanged += new System.EventHandler(this.rbtnFullPayment_CheckedChanged);
            // 
            // rbtnCredit
            // 
            this.rbtnCredit.AutoSize = true;
            this.rbtnCredit.Location = new System.Drawing.Point(355, 101);
            this.rbtnCredit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnCredit.Name = "rbtnCredit";
            this.rbtnCredit.Size = new System.Drawing.Size(73, 24);
            this.rbtnCredit.TabIndex = 18;
            this.rbtnCredit.TabStop = true;
            this.rbtnCredit.Text = "credit";
            this.rbtnCredit.UseVisualStyleBackColor = true;
            // 
            // rbtnInstallment
            // 
            this.rbtnInstallment.AutoSize = true;
            this.rbtnInstallment.Location = new System.Drawing.Point(495, 101);
            this.rbtnInstallment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnInstallment.Name = "rbtnInstallment";
            this.rbtnInstallment.Size = new System.Drawing.Size(94, 24);
            this.rbtnInstallment.TabIndex = 19;
            this.rbtnInstallment.TabStop = true;
            this.rbtnInstallment.Text = "warranty";
            this.rbtnInstallment.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(272, 161);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 29);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Guarantee";
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(128, 378);
            this.txtWarranty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(187, 26);
            this.txtWarranty.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Choose";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWarranty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbtnInstallment);
            this.Controls.Add(this.rbtnCredit);
            this.Controls.Add(this.rbtnFullPayment);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFinalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.RadioButton rbtnFullPayment;
        private System.Windows.Forms.RadioButton rbtnCredit;
        private System.Windows.Forms.RadioButton rbtnInstallment;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.Label label5;
    }
}

