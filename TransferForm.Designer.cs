namespace BankingApp
{
    partial class TransferForm
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
            this.lbldate1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfromaccno = new System.Windows.Forms.TextBox();
            this.txtname2 = new System.Windows.Forms.TextBox();
            this.txtcurrentamount = new System.Windows.Forms.TextBox();
            this.txtdestinationamount = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btntransferamount = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date :";
            // 
            // lbldate1
            // 
            this.lbldate1.AutoSize = true;
            this.lbldate1.Location = new System.Drawing.Point(330, 54);
            this.lbldate1.Name = "lbldate1";
            this.lbldate1.Size = new System.Drawing.Size(0, 13);
            this.lbldate1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Destination Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount";
            // 
            // txtfromaccno
            // 
            this.txtfromaccno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromaccno.Location = new System.Drawing.Point(262, 93);
            this.txtfromaccno.Name = "txtfromaccno";
            this.txtfromaccno.Size = new System.Drawing.Size(163, 22);
            this.txtfromaccno.TabIndex = 7;
            // 
            // txtname2
            // 
            this.txtname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname2.Location = new System.Drawing.Point(262, 130);
            this.txtname2.Name = "txtname2";
            this.txtname2.Size = new System.Drawing.Size(163, 22);
            this.txtname2.TabIndex = 8;
            // 
            // txtcurrentamount
            // 
            this.txtcurrentamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrentamount.Location = new System.Drawing.Point(262, 167);
            this.txtcurrentamount.Name = "txtcurrentamount";
            this.txtcurrentamount.Size = new System.Drawing.Size(163, 22);
            this.txtcurrentamount.TabIndex = 9;
            // 
            // txtdestinationamount
            // 
            this.txtdestinationamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdestinationamount.Location = new System.Drawing.Point(262, 204);
            this.txtdestinationamount.Name = "txtdestinationamount";
            this.txtdestinationamount.Size = new System.Drawing.Size(163, 22);
            this.txtdestinationamount.TabIndex = 10;
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(262, 241);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(163, 22);
            this.txtamount.TabIndex = 11;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.LimeGreen;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(465, 87);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(120, 32);
            this.btnshow.TabIndex = 12;
            this.btnshow.Text = "Show Details";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btntransferamount
            // 
            this.btntransferamount.BackColor = System.Drawing.Color.RoyalBlue;
            this.btntransferamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransferamount.Location = new System.Drawing.Point(262, 269);
            this.btntransferamount.Name = "btntransferamount";
            this.btntransferamount.Size = new System.Drawing.Size(163, 34);
            this.btntransferamount.TabIndex = 13;
            this.btntransferamount.Text = "Transfer Amount";
            this.btntransferamount.UseVisualStyleBackColor = false;
            this.btntransferamount.Click += new System.EventHandler(this.btntransferamount_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(262, 309);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(163, 34);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 384);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btntransferamount);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtdestinationamount);
            this.Controls.Add(this.txtcurrentamount);
            this.Controls.Add(this.txtname2);
            this.Controls.Add(this.txtfromaccno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldate1);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfromaccno;
        private System.Windows.Forms.TextBox txtname2;
        private System.Windows.Forms.TextBox txtcurrentamount;
        private System.Windows.Forms.TextBox txtdestinationamount;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btntransferamount;
        private System.Windows.Forms.Button btnclose;
    }
}