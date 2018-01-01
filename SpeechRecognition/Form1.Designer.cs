namespace PersonalAIGayle
{
    partial class frmgayle
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
            this.btnenable = new System.Windows.Forms.Button();
            this.btndisable = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnenable
            // 
            this.btnenable.Location = new System.Drawing.Point(12, 280);
            this.btnenable.Name = "btnenable";
            this.btnenable.Size = new System.Drawing.Size(187, 23);
            this.btnenable.TabIndex = 0;
            this.btnenable.Text = "Enable Voice";
            this.btnenable.UseVisualStyleBackColor = true;
            this.btnenable.Click += new System.EventHandler(this.btnenable_Click);
            // 
            // btndisable
            // 
            this.btndisable.Enabled = false;
            this.btndisable.Location = new System.Drawing.Point(241, 280);
            this.btndisable.Name = "btndisable";
            this.btndisable.Size = new System.Drawing.Size(170, 23);
            this.btndisable.TabIndex = 1;
            this.btndisable.Text = "Disable Voice";
            this.btndisable.UseVisualStyleBackColor = true;
            this.btndisable.Click += new System.EventHandler(this.btndisable_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 12);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(399, 262);
            this.log.TabIndex = 2;
            this.log.Text = "";
            // 
            // frmgayle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(438, 327);
            this.Controls.Add(this.log);
            this.Controls.Add(this.btndisable);
            this.Controls.Add(this.btnenable);
            this.Name = "frmgayle";
            this.Text = "PAIGayle";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmgayle_FormClosing);
            this.Load += new System.EventHandler(this.frmgayle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnenable;
        private System.Windows.Forms.Button btndisable;
        private System.Windows.Forms.RichTextBox log;
    }
}

