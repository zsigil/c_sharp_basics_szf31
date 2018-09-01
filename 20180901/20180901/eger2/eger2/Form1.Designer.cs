namespace eger2
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
            this.x2_input = new System.Windows.Forms.TextBox();
            this.y2_input = new System.Windows.Forms.TextBox();
            this.x_coord = new System.Windows.Forms.Label();
            this.y_coord = new System.Windows.Forms.Label();
            this.x2_coord = new System.Windows.Forms.Label();
            this.y2_coord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x_input
            // 
            this.x_input.Location = new System.Drawing.Point(299, 64);
            this.x_input.Name = "x_input";
            this.x_input.Size = new System.Drawing.Size(100, 20);
            this.x_input.TabIndex = 0;
            // 
            // y_input
            // 
            this.y_input.Location = new System.Drawing.Point(299, 125);
            this.y_input.Name = "y_input";
            this.y_input.Size = new System.Drawing.Size(100, 20);
            this.y_input.TabIndex = 1;
            // 
            // x2_input
            // 
            this.x2_input.Location = new System.Drawing.Point(299, 197);
            this.x2_input.Name = "x2_input";
            this.x2_input.Size = new System.Drawing.Size(100, 20);
            this.x2_input.TabIndex = 2;
            // 
            // y2_input
            // 
            this.y2_input.Location = new System.Drawing.Point(299, 264);
            this.y2_input.Name = "y2_input";
            this.y2_input.Size = new System.Drawing.Size(100, 20);
            this.y2_input.TabIndex = 3;
            // 
            // x_coord
            // 
            this.x_coord.AutoSize = true;
            this.x_coord.Location = new System.Drawing.Point(102, 64);
            this.x_coord.MinimumSize = new System.Drawing.Size(50, 20);
            this.x_coord.Name = "x_coord";
            this.x_coord.Size = new System.Drawing.Size(67, 20);
            this.x_coord.TabIndex = 4;
            this.x_coord.Text = "X coordinate";
            // 
            // y_coord
            // 
            this.y_coord.AutoSize = true;
            this.y_coord.Location = new System.Drawing.Point(102, 125);
            this.y_coord.MinimumSize = new System.Drawing.Size(50, 20);
            this.y_coord.Name = "y_coord";
            this.y_coord.Size = new System.Drawing.Size(67, 20);
            this.y_coord.TabIndex = 5;
            this.y_coord.Text = "Y coordinate";
            // 
            // x2_coord
            // 
            this.x2_coord.AutoSize = true;
            this.x2_coord.Location = new System.Drawing.Point(102, 197);
            this.x2_coord.MinimumSize = new System.Drawing.Size(50, 20);
            this.x2_coord.Name = "x2_coord";
            this.x2_coord.Size = new System.Drawing.Size(76, 20);
            this.x2_coord.TabIndex = 6;
            this.x2_coord.Text = "X coordinate 2";
            // 
            // y2_coord
            // 
            this.y2_coord.AutoSize = true;
            this.y2_coord.Location = new System.Drawing.Point(102, 264);
            this.y2_coord.MinimumSize = new System.Drawing.Size(50, 20);
            this.y2_coord.Name = "y2_coord";
            this.y2_coord.Size = new System.Drawing.Size(76, 20);
            this.y2_coord.TabIndex = 7;
            this.y2_coord.Text = "Y coordinate 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.y2_coord);
            this.Controls.Add(this.x2_coord);
            this.Controls.Add(this.y_coord);
            this.Controls.Add(this.x_coord);
            this.Controls.Add(this.y2_input);
            this.Controls.Add(this.x2_input);
            this.Controls.Add(this.y_input);
            this.Controls.Add(this.x_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x_input;
        private System.Windows.Forms.TextBox y_input;
        private System.Windows.Forms.TextBox x2_input;
        private System.Windows.Forms.TextBox y2_input;
        private System.Windows.Forms.Label x_coord;
        private System.Windows.Forms.Label y_coord;
        private System.Windows.Forms.Label x2_coord;
        private System.Windows.Forms.Label y2_coord;
    }
}

