
namespace AlcoholContentCalculation
{
    partial class RiquorAbout
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
            this.RiquorTextView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RiquorTextView
            // 
            this.RiquorTextView.AutoSize = true;
            this.RiquorTextView.BackColor = System.Drawing.Color.Transparent;
            this.RiquorTextView.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiquorTextView.ForeColor = System.Drawing.Color.Black;
            this.RiquorTextView.Location = new System.Drawing.Point(13, 13);
            this.RiquorTextView.Name = "RiquorTextView";
            this.RiquorTextView.Size = new System.Drawing.Size(149, 25);
            this.RiquorTextView.TabIndex = 0;
            this.RiquorTextView.Text = "RiquorTextView";
            // 
            // RiquorAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlcoholContentCalculation.Properties.Resources.dottoBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RiquorTextView);
            this.Name = "RiquorAbout";
            this.Text = "RiquorAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RiquorTextView;
    }
}