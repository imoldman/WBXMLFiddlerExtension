namespace WBXMLFiddlerExtension
{
    partial class TextView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showText
            // 
            this.showText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showText.Location = new System.Drawing.Point(0, 0);
            this.showText.Multiline = true;
            this.showText.Name = "showText";
            this.showText.ReadOnly = true;
            this.showText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.showText.Size = new System.Drawing.Size(150, 150);
            this.showText.TabIndex = 0;
            // 
            // TextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showText);
            this.Name = "TextView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showText;
    }
}
