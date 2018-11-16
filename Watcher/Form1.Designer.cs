namespace Watcher
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
            this.observer1btn = new System.Windows.Forms.Button();
            this.Watchertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // observer1btn
            // 
            this.observer1btn.Location = new System.Drawing.Point(345, 99);
            this.observer1btn.Name = "observer1btn";
            this.observer1btn.Size = new System.Drawing.Size(85, 56);
            this.observer1btn.TabIndex = 0;
            this.observer1btn.Text = "20";
            this.observer1btn.UseVisualStyleBackColor = true;
            // 
            // Watchertxt
            // 
            this.Watchertxt.Location = new System.Drawing.Point(86, 12);
            this.Watchertxt.Name = "Watchertxt";
            this.Watchertxt.Size = new System.Drawing.Size(100, 20);
            this.Watchertxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Citation Speed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Watchertxt);
            this.Controls.Add(this.observer1btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button observer1btn;
        private System.Windows.Forms.TextBox Watchertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

