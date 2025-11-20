namespace back_propagation_neural_networks
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 33);
            textBox1.MinimumSize = new Size(0, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 30);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 85);
            textBox2.MinimumSize = new Size(0, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 30);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(94, 282);
            button1.Name = "button1";
            button1.Size = new Size(154, 50);
            button1.TabIndex = 3;
            button1.Text = "Create BPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(313, 331);
            button2.Name = "button2";
            button2.Size = new Size(154, 50);
            button2.TabIndex = 4;
            button2.Text = "Train NN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(553, 282);
            button3.Name = "button3";
            button3.Size = new Size(154, 50);
            button3.TabIndex = 5;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(454, 139);
            textBox5.MinimumSize = new Size(0, 30);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(272, 30);
            textBox5.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(67, 139);
            textBox3.MinimumSize = new Size(0, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 30);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(67, 195);
            textBox4.MinimumSize = new Size(0, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(272, 30);
            textBox4.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 410);
            label1.Name = "label1";
            label1.Size = new Size(310, 20);
            label1.TabIndex = 9;
            label1.Text = "NOTE: Create BPNN first before anything else.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Back Propagation Neural Network";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label1;
    }
}
