namespace Check_PESEL
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
            this.confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pesel = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(308, 140);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "Sprawdź";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(125, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj PESEL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(418, 69);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(106, 20);
            this.pesel.TabIndex = 2;
            this.pesel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.pesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesel_KeyPress);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.Location = new System.Drawing.Point(302, 231);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(86, 31);
            this.result.TabIndex = 3;
            this.result.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm);
            this.Name = "Form1";
            this.Text = "Sprawdzanie poprawności peselu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.Label result;
    }
}

