
namespace AlcoholContentCalculation
{
    partial class AlcoholCalculation
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
            this.TextView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextView
            // 
            this.TextView.AutoSize = true;
            this.TextView.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextView.Location = new System.Drawing.Point(12, 9);
            this.TextView.Name = "TextView";
            this.TextView.Size = new System.Drawing.Size(69, 16);
            this.TextView.TabIndex = 0;
            this.TextView.Text = "TextView";
            // 
            // AlcoholCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 336);
            this.Controls.Add(this.TextView);
            this.Name = "AlcoholCalculation";
            this.Text = "AlcoholCalculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextView;
    }
}