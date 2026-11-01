namespace Program3Spring2025
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
            this.ConsultantLbl = new System.Windows.Forms.Label();
            this.BusinessNameLbl = new System.Windows.Forms.Label();
            this.ContractLengthLbl = new System.Windows.Forms.Label();
            this.ContractCostLbl = new System.Windows.Forms.Label();
            this.CalcBttn = new System.Windows.Forms.Button();
            this.InputContractLengthTxt = new System.Windows.Forms.TextBox();
            this.OutputContractCostLbl = new System.Windows.Forms.Label();
            this.ConsultantNameComboBox = new System.Windows.Forms.ComboBox();
            this.BusinessNameComboBox = new System.Windows.Forms.ComboBox();
            this.CostCalculatorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsultantLbl
            // 
            this.ConsultantLbl.AutoSize = true;
            this.ConsultantLbl.Location = new System.Drawing.Point(68, 77);
            this.ConsultantLbl.Name = "ConsultantLbl";
            this.ConsultantLbl.Size = new System.Drawing.Size(72, 16);
            this.ConsultantLbl.TabIndex = 0;
            this.ConsultantLbl.Text = "Consultant:";
            // 
            // BusinessNameLbl
            // 
            this.BusinessNameLbl.AutoSize = true;
            this.BusinessNameLbl.Location = new System.Drawing.Point(68, 118);
            this.BusinessNameLbl.Name = "BusinessNameLbl";
            this.BusinessNameLbl.Size = new System.Drawing.Size(105, 16);
            this.BusinessNameLbl.TabIndex = 1;
            this.BusinessNameLbl.Text = "Business Name:";
            // 
            // ContractLengthLbl
            // 
            this.ContractLengthLbl.AutoSize = true;
            this.ContractLengthLbl.Location = new System.Drawing.Point(68, 164);
            this.ContractLengthLbl.Name = "ContractLengthLbl";
            this.ContractLengthLbl.Size = new System.Drawing.Size(99, 16);
            this.ContractLengthLbl.TabIndex = 2;
            this.ContractLengthLbl.Text = "Contract Length";
            // 
            // ContractCostLbl
            // 
            this.ContractCostLbl.AutoSize = true;
            this.ContractCostLbl.Location = new System.Drawing.Point(68, 286);
            this.ContractCostLbl.Name = "ContractCostLbl";
            this.ContractCostLbl.Size = new System.Drawing.Size(89, 16);
            this.ContractCostLbl.TabIndex = 3;
            this.ContractCostLbl.Text = "Contract Cost:";
            // 
            // CalcBttn
            // 
            this.CalcBttn.Location = new System.Drawing.Point(145, 220);
            this.CalcBttn.Name = "CalcBttn";
            this.CalcBttn.Size = new System.Drawing.Size(120, 23);
            this.CalcBttn.TabIndex = 4;
            this.CalcBttn.Text = "Calculate";
            this.CalcBttn.UseVisualStyleBackColor = true;
            this.CalcBttn.Click += new System.EventHandler(this.CalcBttn_Click);
            // 
            // InputContractLengthTxt
            // 
            this.InputContractLengthTxt.Location = new System.Drawing.Point(204, 158);
            this.InputContractLengthTxt.Name = "InputContractLengthTxt";
            this.InputContractLengthTxt.Size = new System.Drawing.Size(121, 22);
            this.InputContractLengthTxt.TabIndex = 5;
            // 
            // OutputContractCostLbl
            // 
            this.OutputContractCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputContractCostLbl.Location = new System.Drawing.Point(204, 279);
            this.OutputContractCostLbl.Name = "OutputContractCostLbl";
            this.OutputContractCostLbl.Size = new System.Drawing.Size(121, 23);
            this.OutputContractCostLbl.TabIndex = 6;
            this.OutputContractCostLbl.Click += new System.EventHandler(this.OutputContractCostLbl_Click);
            // 
            // ConsultantNameComboBox
            // 
            this.ConsultantNameComboBox.FormattingEnabled = true;
            this.ConsultantNameComboBox.Items.AddRange(new object[] {
            "John Jones",
            "Sally Sue",
            "Billy Bob",
            "Betty Ballinger"});
            this.ConsultantNameComboBox.Location = new System.Drawing.Point(204, 74);
            this.ConsultantNameComboBox.Name = "ConsultantNameComboBox";
            this.ConsultantNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.ConsultantNameComboBox.TabIndex = 7;
            // 
            // BusinessNameComboBox
            // 
            this.BusinessNameComboBox.FormattingEnabled = true;
            this.BusinessNameComboBox.Items.AddRange(new object[] {
            "John\'s Books",
            "Office Supplies",
            "J.B. Car Parts",
            "Gevalia Coffee",
            "Ceylon Tea",
            "My Footwear"});
            this.BusinessNameComboBox.Location = new System.Drawing.Point(204, 110);
            this.BusinessNameComboBox.Name = "BusinessNameComboBox";
            this.BusinessNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.BusinessNameComboBox.TabIndex = 8;
            // 
            // CostCalculatorLbl
            // 
            this.CostCalculatorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostCalculatorLbl.Location = new System.Drawing.Point(76, 21);
            this.CostCalculatorLbl.Name = "CostCalculatorLbl";
            this.CostCalculatorLbl.Size = new System.Drawing.Size(279, 32);
            this.CostCalculatorLbl.TabIndex = 9;
            this.CostCalculatorLbl.Text = "Contract Cost Calculator";
            this.CostCalculatorLbl.Click += new System.EventHandler(this.CostCalculatorLbl_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 503);
            this.Controls.Add(this.CostCalculatorLbl);
            this.Controls.Add(this.BusinessNameComboBox);
            this.Controls.Add(this.ConsultantNameComboBox);
            this.Controls.Add(this.OutputContractCostLbl);
            this.Controls.Add(this.InputContractLengthTxt);
            this.Controls.Add(this.CalcBttn);
            this.Controls.Add(this.ContractCostLbl);
            this.Controls.Add(this.ContractLengthLbl);
            this.Controls.Add(this.BusinessNameLbl);
            this.Controls.Add(this.ConsultantLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsultantLbl;
        private System.Windows.Forms.Label BusinessNameLbl;
        private System.Windows.Forms.Label ContractLengthLbl;
        private System.Windows.Forms.Label ContractCostLbl;
        private System.Windows.Forms.Button CalcBttn;
        private System.Windows.Forms.TextBox InputContractLengthTxt;
        private System.Windows.Forms.Label OutputContractCostLbl;
        private System.Windows.Forms.ComboBox ConsultantNameComboBox;
        private System.Windows.Forms.ComboBox BusinessNameComboBox;
        private System.Windows.Forms.Label CostCalculatorLbl;
    }
}

