namespace eger
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
            this.x_input = new System.Windows.Forms.TextBox();
            this.y_input = new System.Windows.Forms.TextBox();
            this.eger_x = new System.Windows.Forms.Label();
            this.eger_y = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x_input
            // 
            this.x_input.Location = new System.Drawing.Point(265, 65);
            this.x_input.Name = "x_input";
            this.x_input.Size = new System.Drawing.Size(100, 20);
            this.x_input.TabIndex = 0;
            // 
            // y_input
            // 
            this.y_input.Location = new System.Drawing.Point(265, 101);
            this.y_input.Name = "y_input";
            this.y_input.Size = new System.Drawing.Size(100, 20);
            this.y_input.TabIndex = 1;
            // 
            // eger_x
            // 
            this.eger_x.AutoSize = true;
            this.eger_x.Location = new System.Drawing.Point(81, 65);
            this.eger_x.Name = "eger_x";
            this.eger_x.Size = new System.Drawing.Size(67, 13);
            this.eger_x.TabIndex = 2;
            this.eger_x.Text = "X coordinate";
            // 
            // eger_y
            // 
            this.eger_y.AutoSize = true;
            this.eger_y.Location = new System.Drawing.Point(84, 107);
            this.eger_y.Name = "eger_y";
            this.eger_y.Size = new System.Drawing.Size(67, 13);
            this.eger_y.TabIndex = 3;
            this.eger_y.Text = "Y coordinate";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(160, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "UGRIK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eger_y);
            this.Controls.Add(this.eger_x);
            this.Controls.Add(this.y_input);
            this.Controls.Add(this.x_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x_input;
        private System.Windows.Forms.TextBox y_input;
        private System.Windows.Forms.Label eger_x;
        private System.Windows.Forms.Label eger_y;
        private System.Windows.Forms.Button button1;
    }
}

