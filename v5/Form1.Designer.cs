namespace v5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(18, 307);
            button1.Name = "button1";
            button1.Size = new Size(173, 38);
            button1.TabIndex = 1;
            button1.Text = "Transparency";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(215, 307);
            button2.Name = "button2";
            button2.Size = new Size(173, 38);
            button2.TabIndex = 2;
            button2.Text = "BG color";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(406, 307);
            button3.Name = "button3";
            button3.Size = new Size(173, 38);
            button3.TabIndex = 3;
            button3.Text = "Hello world";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(179, 366);
            button4.Name = "button4";
            button4.Size = new Size(238, 57);
            button4.TabIndex = 4;
            button4.Text = "super-mega button";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(19, 171);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(156, 23);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "super-mega bg color";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(19, 233);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(173, 23);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "super-mega hello world";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 111);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(185, 23);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "super-mega transparency";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(checkBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
    }
}