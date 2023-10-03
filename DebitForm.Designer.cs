namespace BankingApp
{
    partial class DebitForm
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
            this.lbldate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaccno = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtoldbalance = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.cmbmode = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btngetdetails = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(156, 26);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 16);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Account No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Old Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount";
            // 
            // txtaccno
            // 
            this.txtaccno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccno.Location = new System.Drawing.Point(194, 80);
            this.txtaccno.Name = "txtaccno";
            this.txtaccno.Size = new System.Drawing.Size(178, 22);
            this.txtaccno.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(194, 117);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(178, 22);
            this.txtname.TabIndex = 8;
            // 
            // txtoldbalance
            // 
            this.txtoldbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldbalance.Location = new System.Drawing.Point(194, 154);
            this.txtoldbalance.Name = "txtoldbalance";
            this.txtoldbalance.Size = new System.Drawing.Size(178, 22);
            this.txtoldbalance.TabIndex = 9;
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(194, 228);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(178, 22);
            this.txtamount.TabIndex = 11;
            // 
            // cmbmode
            // 
            this.cmbmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmode.FormattingEnabled = true;
            this.cmbmode.Location = new System.Drawing.Point(194, 191);
            this.cmbmode.Name = "cmbmode";
            this.cmbmode.Size = new System.Drawing.Size(178, 24);
            this.cmbmode.TabIndex = 12;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LawnGreen;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(183, 270);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(96, 27);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btngetdetails
            // 
            this.btngetdetails.BackColor = System.Drawing.Color.Gold;
            this.btngetdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetdetails.Location = new System.Drawing.Point(378, 79);
            this.btngetdetails.Name = "btngetdetails";
            this.btngetdetails.Size = new System.Drawing.Size(96, 30);
            this.btngetdetails.TabIndex = 14;
            this.btngetdetails.Text = "Get Details";
            this.btngetdetails.UseVisualStyleBackColor = false;
            this.btngetdetails.Click += new System.EventHandler(this.btngetdetails_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.LawnGreen;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(285, 270);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(96, 27);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // DebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 336);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btngetdetails);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbmode);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtoldbalance);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtaccno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldate);
            this.Name = "DebitForm";
            this.Text = "DebitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaccno;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtoldbalance;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.ComboBox cmbmode;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btngetdetails;
        private System.Windows.Forms.Button btnclose;
    }
}