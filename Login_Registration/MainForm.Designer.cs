namespace Login_Registration
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.btn_FeedSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_FeedSubmit);
            this.groupBox1.Controls.Add(this.txtFeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feedback";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Give some Feedback about the Application:";
            // 
            // txtFeed
            // 
            this.txtFeed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeed.Location = new System.Drawing.Point(9, 84);
            this.txtFeed.Multiline = true;
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeed.Size = new System.Drawing.Size(266, 103);
            this.txtFeed.TabIndex = 1;
            // 
            // btn_FeedSubmit
            // 
            this.btn_FeedSubmit.Location = new System.Drawing.Point(82, 214);
            this.btn_FeedSubmit.Name = "btn_FeedSubmit";
            this.btn_FeedSubmit.Size = new System.Drawing.Size(121, 30);
            this.btn_FeedSubmit.TabIndex = 2;
            this.btn_FeedSubmit.Text = "SUBMIT";
            this.btn_FeedSubmit.UseVisualStyleBackColor = true;
            this.btn_FeedSubmit.Click += new System.EventHandler(this.btn_FeedSubmit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 296);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER DETAILS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_FeedSubmit;
        private System.Windows.Forms.TextBox txtFeed;
        private System.Windows.Forms.Label label1;
    }
}