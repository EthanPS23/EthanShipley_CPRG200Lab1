namespace EthanShipleyCPRG200Lab1
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
            this.lblPwrConsump = new System.Windows.Forms.Label();
            this.txtPwrConsump = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCalcChrg = new System.Windows.Forms.Label();
            this.txtCalcChrg = new System.Windows.Forms.TextBox();
            this.radRes = new System.Windows.Forms.RadioButton();
            this.radCom = new System.Windows.Forms.RadioButton();
            this.radInd = new System.Windows.Forms.RadioButton();
            this.txtOffPk = new System.Windows.Forms.TextBox();
            this.lblOffPk = new System.Windows.Forms.Label();
            this.lblPkPwr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPwrConsump
            // 
            this.lblPwrConsump.AutoSize = true;
            this.lblPwrConsump.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwrConsump.Location = new System.Drawing.Point(23, 24);
            this.lblPwrConsump.Name = "lblPwrConsump";
            this.lblPwrConsump.Size = new System.Drawing.Size(236, 24);
            this.lblPwrConsump.TabIndex = 0;
            this.lblPwrConsump.Text = "Power Consumption (kWh)";
            // 
            // txtPwrConsump
            // 
            this.txtPwrConsump.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwrConsump.Location = new System.Drawing.Point(329, 20);
            this.txtPwrConsump.Name = "txtPwrConsump";
            this.txtPwrConsump.Size = new System.Drawing.Size(121, 29);
            this.txtPwrConsump.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(25, 206);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(128, 35);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(159, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(293, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCalcChrg
            // 
            this.lblCalcChrg.AutoSize = true;
            this.lblCalcChrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcChrg.Location = new System.Drawing.Point(23, 129);
            this.lblCalcChrg.Name = "lblCalcChrg";
            this.lblCalcChrg.Size = new System.Drawing.Size(165, 24);
            this.lblCalcChrg.TabIndex = 0;
            this.lblCalcChrg.Text = "Calculated Charge";
            // 
            // txtCalcChrg
            // 
            this.txtCalcChrg.Enabled = false;
            this.txtCalcChrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalcChrg.Location = new System.Drawing.Point(329, 126);
            this.txtCalcChrg.Name = "txtCalcChrg";
            this.txtCalcChrg.Size = new System.Drawing.Size(121, 29);
            this.txtCalcChrg.TabIndex = 1;
            // 
            // radRes
            // 
            this.radRes.AutoSize = true;
            this.radRes.Checked = true;
            this.radRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRes.Location = new System.Drawing.Point(26, 168);
            this.radRes.Name = "radRes";
            this.radRes.Size = new System.Drawing.Size(120, 28);
            this.radRes.TabIndex = 3;
            this.radRes.TabStop = true;
            this.radRes.Text = "Residential";
            this.radRes.UseVisualStyleBackColor = true;
            this.radRes.CheckedChanged += new System.EventHandler(this.radRes_CheckedChanged);
            // 
            // radCom
            // 
            this.radCom.AutoSize = true;
            this.radCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCom.Location = new System.Drawing.Point(159, 168);
            this.radCom.Name = "radCom";
            this.radCom.Size = new System.Drawing.Size(129, 28);
            this.radCom.TabIndex = 3;
            this.radCom.Text = "Commercial";
            this.radCom.UseVisualStyleBackColor = true;
            this.radCom.CheckedChanged += new System.EventHandler(this.radCom_CheckedChanged);
            // 
            // radInd
            // 
            this.radInd.AutoSize = true;
            this.radInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInd.Location = new System.Drawing.Point(293, 168);
            this.radInd.Name = "radInd";
            this.radInd.Size = new System.Drawing.Size(102, 28);
            this.radInd.TabIndex = 3;
            this.radInd.Text = "Industrial";
            this.radInd.UseVisualStyleBackColor = true;
            this.radInd.CheckedChanged += new System.EventHandler(this.radInd_CheckedChanged);
            // 
            // txtOffPk
            // 
            this.txtOffPk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPk.Location = new System.Drawing.Point(329, 74);
            this.txtOffPk.Name = "txtOffPk";
            this.txtOffPk.Size = new System.Drawing.Size(121, 29);
            this.txtOffPk.TabIndex = 1;
            // 
            // lblOffPk
            // 
            this.lblOffPk.AutoSize = true;
            this.lblOffPk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPk.Location = new System.Drawing.Point(12, 77);
            this.lblOffPk.Name = "lblOffPk";
            this.lblOffPk.Size = new System.Drawing.Size(312, 24);
            this.lblOffPk.TabIndex = 0;
            this.lblOffPk.Text = "Off-Peak Power Consumption (kWh)";
            // 
            // lblPkPwr
            // 
            this.lblPkPwr.AutoSize = true;
            this.lblPkPwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkPwr.Location = new System.Drawing.Point(12, 25);
            this.lblPkPwr.Name = "lblPkPwr";
            this.lblPkPwr.Size = new System.Drawing.Size(283, 24);
            this.lblPkPwr.TabIndex = 0;
            this.lblPkPwr.Text = "Peak Power Consumption (kWh)";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(468, 261);
            this.Controls.Add(this.radInd);
            this.Controls.Add(this.radCom);
            this.Controls.Add(this.radRes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtOffPk);
            this.Controls.Add(this.txtCalcChrg);
            this.Controls.Add(this.txtPwrConsump);
            this.Controls.Add(this.lblCalcChrg);
            this.Controls.Add(this.lblPkPwr);
            this.Controls.Add(this.lblOffPk);
            this.Controls.Add(this.lblPwrConsump);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Power Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPwrConsump;
        private System.Windows.Forms.TextBox txtPwrConsump;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCalcChrg;
        private System.Windows.Forms.TextBox txtCalcChrg;
        private System.Windows.Forms.RadioButton radRes;
        private System.Windows.Forms.RadioButton radCom;
        private System.Windows.Forms.RadioButton radInd;
        private System.Windows.Forms.TextBox txtOffPk;
        private System.Windows.Forms.Label lblOffPk;
        private System.Windows.Forms.Label lblPkPwr;
    }
}

