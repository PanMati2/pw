namespace BMR
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
            this.components = new System.ComponentModel.Container();
            this.result_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.woman_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weight_textBox = new System.Windows.Forms.TextBox();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.man_checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.result_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result_button
            // 
            this.result_button.Location = new System.Drawing.Point(288, 218);
            this.result_button.Name = "result_button";
            this.result_button.Size = new System.Drawing.Size(75, 23);
            this.result_button.TabIndex = 0;
            this.result_button.Text = "Oblicz";
            this.result_button.UseVisualStyleBackColor = true;
            this.result_button.Click += new System.EventHandler(this.result_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(142, 218);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "Wyczyść";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // woman_checkBox
            // 
            this.woman_checkBox.AutoSize = true;
            this.woman_checkBox.Location = new System.Drawing.Point(187, 146);
            this.woman_checkBox.Name = "woman_checkBox";
            this.woman_checkBox.Size = new System.Drawing.Size(62, 17);
            this.woman_checkBox.TabIndex = 2;
            this.woman_checkBox.Text = "Kobieta";
            this.woman_checkBox.UseVisualStyleBackColor = true;
            this.woman_checkBox.CheckedChanged += new System.EventHandler(this.woman_checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Waga";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(80, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wzrost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(80, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wiek";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(80, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Płeć";
            // 
            // weight_textBox
            // 
            this.weight_textBox.Location = new System.Drawing.Point(232, 41);
            this.weight_textBox.Name = "weight_textBox";
            this.weight_textBox.Size = new System.Drawing.Size(100, 20);
            this.weight_textBox.TabIndex = 7;
            this.weight_textBox.TextChanged += new System.EventHandler(this.weight_textBox_TextChanged);
            this.weight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_textBox_KeyPress);
            // 
            // height_textBox
            // 
            this.height_textBox.Location = new System.Drawing.Point(232, 71);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(100, 20);
            this.height_textBox.TabIndex = 8;
            this.height_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_textBox_KeyPress);
            // 
            // age_textBox
            // 
            this.age_textBox.Location = new System.Drawing.Point(232, 103);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(100, 20);
            this.age_textBox.TabIndex = 9;
            this.age_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_textBox_KeyPress);
            // 
            // man_checkBox
            // 
            this.man_checkBox.AutoSize = true;
            this.man_checkBox.Location = new System.Drawing.Point(284, 146);
            this.man_checkBox.Name = "man_checkBox";
            this.man_checkBox.Size = new System.Drawing.Size(79, 17);
            this.man_checkBox.TabIndex = 10;
            this.man_checkBox.Text = "Mężczyzna";
            this.man_checkBox.UseVisualStyleBackColor = true;
            this.man_checkBox.CheckedChanged += new System.EventHandler(this.man_checkBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(400, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wynik: ";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(438, 218);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 13;
            this.exit_button.Text = "Wyjście";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result_label.Location = new System.Drawing.Point(491, 51);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(0, 18);
            this.result_label.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 267);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.man_checkBox);
            this.Controls.Add(this.age_textBox);
            this.Controls.Add(this.height_textBox);
            this.Controls.Add(this.weight_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.woman_checkBox);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.result_button);
            this.Name = "Form1";
            this.Text = "BMR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button result_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.CheckBox woman_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weight_textBox;
        private System.Windows.Forms.TextBox height_textBox;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.CheckBox man_checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label result_label;
    }
}

