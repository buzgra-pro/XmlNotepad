namespace XmlNotepad
{
    partial class frmXQuery
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
            this.label1 = new System.Windows.Forms.Label();
            this.txQuery = new System.Windows.Forms.TextBox();
            this.CmdSetValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter XQuery Expression";
            // 
            // txQuery
            // 
            this.txQuery.Location = new System.Drawing.Point(234, 47);
            this.txQuery.Multiline = true;
            this.txQuery.Name = "txQuery";
            this.txQuery.Size = new System.Drawing.Size(465, 20);
            this.txQuery.TabIndex = 1;
            // 
            // CmdSetValue
            // 
            this.CmdSetValue.Location = new System.Drawing.Point(534, 161);
            this.CmdSetValue.Name = "CmdSetValue";
            this.CmdSetValue.Size = new System.Drawing.Size(75, 23);
            this.CmdSetValue.TabIndex = 2;
            this.CmdSetValue.Text = "Set Value";
            this.CmdSetValue.UseVisualStyleBackColor = true;
            this.CmdSetValue.Click += new System.EventHandler(this.CmdSetValue_Click);
            // 
            // frmXQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdSetValue);
            this.Controls.Add(this.txQuery);
            this.Controls.Add(this.label1);
            this.Name = "frmXQuery";
            this.Text = "frmXQuery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txQuery;
        private System.Windows.Forms.Button CmdSetValue;
    }
}