
namespace MongoDB_Repository
{
    partial class PolicijaDodajBrod
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrod = new System.Windows.Forms.Label();
            this.tbxBrodMarka = new System.Windows.Forms.TextBox();
            this.tbxBrodBoja = new System.Windows.Forms.TextBox();
            this.tbxBrod = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(89, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(86, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka broda:";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(86, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Boja broda:";
            // 
            // lblBrod
            // 
            this.lblBrod.AutoSize = true;
            this.lblBrod.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBrod.Location = new System.Drawing.Point(89, 271);
            this.lblBrod.Name = "lblBrod";
            this.lblBrod.Size = new System.Drawing.Size(223, 31);
            this.lblBrod.TabIndex = 3;
            this.lblBrod.Text = "ID dodatog broda:";
            // 
            // tbxBrodMarka
            // 
            this.tbxBrodMarka.BackColor = System.Drawing.Color.Gray;
            this.tbxBrodMarka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBrodMarka.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBrodMarka.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxBrodMarka.Location = new System.Drawing.Point(89, 75);
            this.tbxBrodMarka.Name = "tbxBrodMarka";
            this.tbxBrodMarka.Size = new System.Drawing.Size(305, 26);
            this.tbxBrodMarka.TabIndex = 4;
            // 
            // tbxBrodBoja
            // 
            this.tbxBrodBoja.BackColor = System.Drawing.Color.Gray;
            this.tbxBrodBoja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBrodBoja.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBrodBoja.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxBrodBoja.Location = new System.Drawing.Point(92, 189);
            this.tbxBrodBoja.Name = "tbxBrodBoja";
            this.tbxBrodBoja.Size = new System.Drawing.Size(302, 26);
            this.tbxBrodBoja.TabIndex = 5;
            // 
            // tbxBrod
            // 
            this.tbxBrod.BackColor = System.Drawing.Color.Gray;
            this.tbxBrod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBrod.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBrod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxBrod.Location = new System.Drawing.Point(92, 305);
            this.tbxBrod.Name = "tbxBrod";
            this.tbxBrod.Size = new System.Drawing.Size(305, 26);
            this.tbxBrod.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(92, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(92, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(92, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 1);
            this.panel3.TabIndex = 9;
            // 
            // PolicijaDodajBrod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(502, 470);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxBrod);
            this.Controls.Add(this.tbxBrodBoja);
            this.Controls.Add(this.tbxBrodMarka);
            this.Controls.Add(this.lblBrod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PolicijaDodajBrod";
            this.Text = "PolicijaDodajBrod";
            this.Load += new System.EventHandler(this.PolicijaDodajBrod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrod;
        private System.Windows.Forms.TextBox tbxBrodMarka;
        private System.Windows.Forms.TextBox tbxBrodBoja;
        private System.Windows.Forms.TextBox tbxBrod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}