﻿
namespace Calculator
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
            this.btCong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btCong.Location = new System.Drawing.Point(497, 210);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(84, 40);
            this.btCong.TabIndex = 0;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(107, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(252, 71);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(329, 26);
            this.txtA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(267, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tính toán";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(252, 114);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(329, 26);
            this.txtB.TabIndex = 2;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(252, 160);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(329, 26);
            this.txtKetQua.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(107, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(107, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả:";
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btTru.Location = new System.Drawing.Point(383, 210);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(84, 40);
            this.btTru.TabIndex = 0;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTru;
    }
}

