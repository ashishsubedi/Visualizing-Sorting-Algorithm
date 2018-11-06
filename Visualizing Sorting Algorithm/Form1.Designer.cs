namespace Visualizing_Sorting_Algorithm
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
            this.surface1 = new System.Windows.Forms.Panel();
            this.surface2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surface1
            // 
            this.surface1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.surface1.BackgroundImage = global::Visualizing_Sorting_Algorithm.Properties.Resources.test;
            this.surface1.Location = new System.Drawing.Point(12, 12);
            this.surface1.Name = "surface1";
            this.surface1.Size = new System.Drawing.Size(452, 318);
            this.surface1.TabIndex = 0;
            this.surface1.Paint += new System.Windows.Forms.PaintEventHandler(this.surface_Paint);
            // 
            // surface2
            // 
            this.surface2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.surface2.BackgroundImage = global::Visualizing_Sorting_Algorithm.Properties.Resources.test;
            this.surface2.Location = new System.Drawing.Point(495, 12);
            this.surface2.Name = "surface2";
            this.surface2.Size = new System.Drawing.Size(452, 318);
            this.surface2.TabIndex = 1;
            this.surface2.Paint += new System.Windows.Forms.PaintEventHandler(this.surface2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.surface2);
            this.Controls.Add(this.surface1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Visualizing Sort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel surface1;
        private System.Windows.Forms.Panel surface2;
        private System.Windows.Forms.Button button2;
    }
}

