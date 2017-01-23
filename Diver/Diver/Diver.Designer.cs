namespace Diver
{
    partial class Diver
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
            this.headerText = new System.Windows.Forms.Label();
            this.DiverList = new System.Windows.Forms.ListBox();
            this.diverlistboxlabel = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.pointlist = new System.Windows.Forms.ListBox();
            this.pointlabel = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(31, 22);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(57, 25);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Diver";
            // 
            // DiverList
            // 
            this.DiverList.FormattingEnabled = true;
            this.DiverList.ItemHeight = 25;
            this.DiverList.Location = new System.Drawing.Point(80, 142);
            this.DiverList.Name = "DiverList";
            this.DiverList.Size = new System.Drawing.Size(262, 229);
            this.DiverList.TabIndex = 1;
            // 
            // diverlistboxlabel
            // 
            this.diverlistboxlabel.AutoSize = true;
            this.diverlistboxlabel.Location = new System.Drawing.Point(75, 60);
            this.diverlistboxlabel.Name = "diverlistboxlabel";
            this.diverlistboxlabel.Size = new System.Drawing.Size(92, 25);
            this.diverlistboxlabel.TabIndex = 2;
            this.diverlistboxlabel.Text = "Diver List";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(348, 227);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(133, 54);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pointlist
            // 
            this.pointlist.FormattingEnabled = true;
            this.pointlist.ItemHeight = 25;
            this.pointlist.Location = new System.Drawing.Point(487, 142);
            this.pointlist.Name = "pointlist";
            this.pointlist.Size = new System.Drawing.Size(262, 229);
            this.pointlist.TabIndex = 1;
            // 
            // pointlabel
            // 
            this.pointlabel.AutoSize = true;
            this.pointlabel.Location = new System.Drawing.Point(498, 60);
            this.pointlabel.Name = "pointlabel";
            this.pointlabel.Size = new System.Drawing.Size(91, 25);
            this.pointlabel.TabIndex = 2;
            this.pointlabel.Text = "Point List";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(581, 387);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(135, 54);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // Diver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 562);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.pointlabel);
            this.Controls.Add(this.diverlistboxlabel);
            this.Controls.Add(this.pointlist);
            this.Controls.Add(this.DiverList);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Diver";
            this.Text = "Diver";
            this.Load += new System.EventHandler(this.Diver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox DiverList;
        private System.Windows.Forms.Label diverlistboxlabel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox pointlist;
        private System.Windows.Forms.Label pointlabel;
        private System.Windows.Forms.Button btnsave;
    }
}

