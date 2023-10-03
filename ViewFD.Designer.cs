namespace BankingApp
{
    partial class ViewFD
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Turquoise;
            this.btnshow.Font = new System.Drawing.Font("Data", 8.25F);
            this.btnshow.Location = new System.Drawing.Point(387, 39);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(87, 28);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "SHOW";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 384);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Turquoise;
            this.btnclose.Font = new System.Drawing.Font("Data", 8.25F);
            this.btnclose.Location = new System.Drawing.Point(480, 39);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(87, 28);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ViewFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 496);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ViewFD";
            this.Text = "ViewFD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnclose;
    }
}