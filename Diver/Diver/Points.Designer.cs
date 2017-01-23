namespace Diver
{
    partial class Points
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
            this.hoppareName = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // hoppareName
            // 
            this.hoppareName.Location = new System.Drawing.Point(39, 33);
            this.hoppareName.Name = "hoppareName";
            this.hoppareName.Size = new System.Drawing.Size(326, 51);
            this.hoppareName.TabIndex = 0;
            this.hoppareName.UseCompatibleStateImageBehavior = false;
            this.hoppareName.SelectedIndexChanged += new System.EventHandler(this.hoppareName_SelectedIndexChanged);
            // 
            // Points
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 679);
            this.Controls.Add(this.hoppareName);
            this.Name = "Points";
            this.Text = "Points";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView hoppareName;
    }
}