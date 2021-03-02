
namespace WordToPDF
{
    partial class WordToPDF
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetFileSource = new System.Windows.Forms.Button();
            this.btnClearFileSource = new System.Windows.Forms.Button();
            this.labFileTarget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "轉換";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "檔案來源：";
            // 
            // btnGetFileSource
            // 
            this.btnGetFileSource.Location = new System.Drawing.Point(12, 46);
            this.btnGetFileSource.Name = "btnGetFileSource";
            this.btnGetFileSource.Size = new System.Drawing.Size(129, 32);
            this.btnGetFileSource.TabIndex = 3;
            this.btnGetFileSource.Text = "選取檔案來源";
            this.btnGetFileSource.UseVisualStyleBackColor = true;
            this.btnGetFileSource.Click += new System.EventHandler(this.btnGetFileSource_Click);
            // 
            // btnClearFileSource
            // 
            this.btnClearFileSource.Location = new System.Drawing.Point(147, 46);
            this.btnClearFileSource.Name = "btnClearFileSource";
            this.btnClearFileSource.Size = new System.Drawing.Size(92, 32);
            this.btnClearFileSource.TabIndex = 4;
            this.btnClearFileSource.Text = "重新選擇";
            this.btnClearFileSource.UseVisualStyleBackColor = true;
            this.btnClearFileSource.Click += new System.EventHandler(this.btnClearFileSource_Click);
            // 
            // labFileTarget
            // 
            this.labFileTarget.AutoSize = true;
            this.labFileTarget.Location = new System.Drawing.Point(11, 103);
            this.labFileTarget.Name = "labFileTarget";
            this.labFileTarget.Size = new System.Drawing.Size(146, 18);
            this.labFileTarget.TabIndex = 5;
            this.labFileTarget.Text = "請選取檔案來源...";
            // 
            // WordToPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 241);
            this.Controls.Add(this.labFileTarget);
            this.Controls.Add(this.btnClearFileSource);
            this.Controls.Add(this.btnGetFileSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "WordToPDF";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetFileSource;
        private System.Windows.Forms.Button btnClearFileSource;
        private System.Windows.Forms.Label labFileTarget;
    }
}

