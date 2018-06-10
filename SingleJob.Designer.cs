namespace Task_Manager
{
    partial class SingleJob
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
            this.jobContent = new System.Windows.Forms.TextBox();
            this.jobType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // jobContent
            // 
            this.jobContent.Location = new System.Drawing.Point(6, 8);
            this.jobContent.Name = "jobContent";
            this.jobContent.Size = new System.Drawing.Size(185, 22);
            this.jobContent.TabIndex = 0;
            // 
            // jobType
            // 
            this.jobType.Location = new System.Drawing.Point(197, 8);
            this.jobType.Name = "jobType";
            this.jobType.Size = new System.Drawing.Size(106, 22);
            this.jobType.TabIndex = 1;
            // 
            // SingleJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jobType);
            this.Controls.Add(this.jobContent);
            this.Name = "SingleJob";
            this.Size = new System.Drawing.Size(308, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jobContent;
        private System.Windows.Forms.TextBox jobType;
    }
}
