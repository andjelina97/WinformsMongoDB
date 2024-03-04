
namespace MongoDB_Repository
{
    partial class ServisFormTehnickiPregled
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
            this.clbPregled = new System.Windows.Forms.CheckedListBox();
            this.tbxIdVozila = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Bisque;
            this.button1.Location = new System.Drawing.Point(40, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "POTVRDI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite identifikator vozila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(33, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Obelezite kategorije za koje je vozilo proslo tehnicki pregled:";
            // 
            // clbPregled
            // 
            this.clbPregled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clbPregled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPregled.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPregled.ForeColor = System.Drawing.Color.Bisque;
            this.clbPregled.FormattingEnabled = true;
            this.clbPregled.Location = new System.Drawing.Point(40, 188);
            this.clbPregled.Name = "clbPregled";
            this.clbPregled.Size = new System.Drawing.Size(482, 168);
            this.clbPregled.TabIndex = 3;
            // 
            // tbxIdVozila
            // 
            this.tbxIdVozila.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbxIdVozila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxIdVozila.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdVozila.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxIdVozila.Location = new System.Drawing.Point(40, 88);
            this.tbxIdVozila.Name = "tbxIdVozila";
            this.tbxIdVozila.Size = new System.Drawing.Size(262, 26);
            this.tbxIdVozila.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(40, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 1);
            this.panel1.TabIndex = 5;
            // 
            // ServisFormTehnickiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(643, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxIdVozila);
            this.Controls.Add(this.clbPregled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServisFormTehnickiPregled";
            this.Text = "ServisFormTehnickiPregled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbPregled;
        private System.Windows.Forms.TextBox tbxIdVozila;
        private System.Windows.Forms.Panel panel1;
    }
}