using CamDo.CustomControl;

namespace CamDo.Forms
{
    partial class MFCreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.ckbIsMachine = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMoney = new CamDo.CustomControl.TextBoxMoney();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSavePrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iptTypeGold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iptPriceUnit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iptTotalMass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iptNotGoldMass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(41, 7);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "M112";
            // 
            // ckbIsMachine
            // 
            this.ckbIsMachine.AutoSize = true;
            this.ckbIsMachine.Location = new System.Drawing.Point(148, 6);
            this.ckbIsMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbIsMachine.Name = "ckbIsMachine";
            this.ckbIsMachine.Size = new System.Drawing.Size(80, 19);
            this.ckbIsMachine.TabIndex = 2;
            this.ckbIsMachine.Text = "ĐIỆN MÁY";
            this.ckbIsMachine.UseVisualStyleBackColor = true;
            this.ckbIsMachine.CheckedChanged += new System.EventHandler(this.ckbIsMachine_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(331, 7);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "CẦM MỚI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "NGÀY CẦM:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(87, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 15);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "09 - 11- 2022";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên khách";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(76, 57);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(324, 23);
            this.txtCustomerName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tài sản cầm";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(11, 104);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(389, 86);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số tiền cầm";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(93, 261);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(308, 23);
            this.txtMoney.TabIndex = 11;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(93, 297);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(24, 15);
            this.lblMoney.TabIndex = 12;
            this.lblMoney.Text = "(...)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 324);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(108, 324);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 22);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Location = new System.Drawing.Point(212, 324);
            this.btnSavePrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(82, 22);
            this.btnSavePrint.TabIndex = 15;
            this.btnSavePrint.Text = "Lưu - In";
            this.btnSavePrint.UseVisualStyleBackColor = true;
            this.btnSavePrint.Click += new System.EventHandler(this.btnSavePrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Loại vàng";
            // 
            // iptTypeGold
            // 
            this.iptTypeGold.Location = new System.Drawing.Point(93, 231);
            this.iptTypeGold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptTypeGold.Name = "iptTypeGold";
            this.iptTypeGold.Size = new System.Drawing.Size(98, 23);
            this.iptTypeGold.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Đơn giá";
            // 
            // iptPriceUnit
            // 
            this.iptPriceUnit.Location = new System.Drawing.Point(261, 231);
            this.iptPriceUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptPriceUnit.Name = "iptPriceUnit";
            this.iptPriceUnit.Size = new System.Drawing.Size(140, 23);
            this.iptPriceUnit.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tổng KL";
            // 
            // iptTotalMass
            // 
            this.iptTotalMass.Location = new System.Drawing.Point(93, 202);
            this.iptTotalMass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptTotalMass.Name = "iptTotalMass";
            this.iptTotalMass.Size = new System.Drawing.Size(98, 23);
            this.iptTotalMass.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "KL hột";
            // 
            // iptNotGoldMass
            // 
            this.iptNotGoldMass.Location = new System.Drawing.Point(261, 202);
            this.iptNotGoldMass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptNotGoldMass.Name = "iptNotGoldMass";
            this.iptNotGoldMass.Size = new System.Drawing.Size(140, 23);
            this.iptNotGoldMass.TabIndex = 23;
            // 
            // MFCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 526);
            this.Controls.Add(this.iptNotGoldMass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iptTotalMass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.iptPriceUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iptTypeGold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSavePrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckbIsMachine);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MFCreateForm";
            this.Text = "MFCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblId;
        private CheckBox ckbIsMachine;
        private Label label3;
        private Label label4;
        private Label lblDate;
        private Label label6;
        private TextBox txtCustomerName;
        private Label label7;
        private RichTextBox txtDescription;
        private Label label8;
        private Label lblMoney;
        private Button btnSave;
        private Button btnClose;
        private Button btnSavePrint;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox3;
        private Label label10;
        private TextBox textBox4;
        private TextBoxMoney txtMoney;
        private TextBox iptTypeGold;
        private TextBox iptPriceUnit;
        private TextBox iptTotalMass;
        private TextBox iptNotGoldMass;
    }
}