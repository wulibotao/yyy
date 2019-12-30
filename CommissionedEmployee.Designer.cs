namespace Payroll
{
    partial class CommissionedEmployee
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
            this.textcommissionRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textbaseRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textcommissionRate
            // 
            this.textcommissionRate.Location = new System.Drawing.Point(121, 288);
            this.textcommissionRate.Name = "textcommissionRate";
            this.textcommissionRate.Size = new System.Drawing.Size(265, 25);
            this.textcommissionRate.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "提成：";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(121, 93);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(265, 25);
            this.textid.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "编号：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 47;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 46;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbaseRate
            // 
            this.textbaseRate.Location = new System.Drawing.Point(121, 241);
            this.textbaseRate.Name = "textbaseRate";
            this.textbaseRate.Size = new System.Drawing.Size(265, 25);
            this.textbaseRate.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "地址:";
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(121, 195);
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(265, 25);
            this.textaddress.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "底薪：";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(121, 147);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(265, 25);
            this.textname.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(170, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "添加销售雇员";
            // 
            // CommissionedEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textcommissionRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbaseRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label1);
            this.Name = "CommissionedEmployee";
            this.Text = "CommissionedEmployee";
            this.Load += new System.EventHandler(this.CommissionedEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcommissionRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbaseRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}