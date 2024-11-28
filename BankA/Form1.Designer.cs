namespace BankA
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
            this.Numbers1 = new System.Windows.Forms.TextBox();
            this.showing = new System.Windows.Forms.TextBox();
            this.Numbers2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Numbers1
            // 
            this.Numbers1.Location = new System.Drawing.Point(374, 57);
            this.Numbers1.Name = "Numbers1";
            this.Numbers1.Size = new System.Drawing.Size(150, 24);
            this.Numbers1.TabIndex = 0;
            this.Numbers1.TextChanged += new System.EventHandler(this.Numbers1_TextChanged);
            // 
            // showing
            // 
            this.showing.Location = new System.Drawing.Point(374, 180);
            this.showing.Name = "showing";
            this.showing.Size = new System.Drawing.Size(150, 24);
            this.showing.TabIndex = 1;
            // 
            // Numbers2
            // 
            this.Numbers2.Location = new System.Drawing.Point(374, 115);
            this.Numbers2.Name = "Numbers2";
            this.Numbers2.Size = new System.Drawing.Size(150, 24);
            this.Numbers2.TabIndex = 2;
            this.Numbers2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnDeposit);
            this.groupBox1.Controls.Add(this.Numbers1);
            this.groupBox1.Controls.Add(this.showing);
            this.groupBox1.Controls.Add(this.Numbers2);
            this.groupBox1.Location = new System.Drawing.Point(74, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 281);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(238, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "add account";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(47, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 41);
            this.button5.TabIndex = 7;
            this.button5.Text = "check number of accounts";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(47, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 33);
            this.button4.TabIndex = 6;
            this.button4.Text = "check balance";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "transfer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "withdraw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(47, 33);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(128, 38);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Numbers1;
        private System.Windows.Forms.TextBox showing;
        private System.Windows.Forms.TextBox Numbers2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button button6;
    }
}

