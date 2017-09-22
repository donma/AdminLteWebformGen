namespace AdminLteWebformGen
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnGen1 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkEnableAutoGenWB = new System.Windows.Forms.CheckBox();
            this.chkIncludeContainer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSource.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSource.Location = new System.Drawing.Point(1, 1);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(481, 542);
            this.txtSource.TabIndex = 0;
            this.txtSource.Text = "帳號;account;tb;6;12;必填，這是登入帳號;\r\n密碼;pass;tb;6;12;;;*\r\n生日;birthday;tb;12;12;;date \r\n" +
    "Email;email;tb;12;12;綁Google要用的\r\n居住城市;city;ddl;12;12;請選擇你居住的城市\r\nhr\r\n備註;memo;ta;1" +
    "2;12;\r\n存檔;save;btn;12;12;save";
            this.txtSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSource_KeyDown);
            // 
            // btnGen1
            // 
            this.btnGen1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen1.Location = new System.Drawing.Point(488, 157);
            this.btnGen1.Name = "btnGen1";
            this.btnGen1.Size = new System.Drawing.Size(117, 83);
            this.btnGen1.TabIndex = 1;
            this.btnGen1.Text = "Gen \r\nWebform\r\n=>";
            this.btnGen1.UseVisualStyleBackColor = true;
            this.btnGen1.Click += new System.EventHandler(this.btnGen1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(611, 1);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(469, 542);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutput_KeyDown);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(488, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 66);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Settings";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(488, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 67);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkEnableAutoGenWB
            // 
            this.chkEnableAutoGenWB.Checked = true;
            this.chkEnableAutoGenWB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableAutoGenWB.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkEnableAutoGenWB.Location = new System.Drawing.Point(488, 246);
            this.chkEnableAutoGenWB.Name = "chkEnableAutoGenWB";
            this.chkEnableAutoGenWB.Size = new System.Drawing.Size(117, 48);
            this.chkEnableAutoGenWB.TabIndex = 5;
            this.chkEnableAutoGenWB.Text = "Auto Gen";
            this.chkEnableAutoGenWB.UseVisualStyleBackColor = true;
            // 
            // chkIncludeContainer
            // 
            this.chkIncludeContainer.Checked = true;
            this.chkIncludeContainer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeContainer.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIncludeContainer.Location = new System.Drawing.Point(488, 290);
            this.chkIncludeContainer.Name = "chkIncludeContainer";
            this.chkIncludeContainer.Size = new System.Drawing.Size(117, 49);
            this.chkIncludeContainer.TabIndex = 6;
            this.chkIncludeContainer.Text = "Add Container";
            this.chkIncludeContainer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.chkIncludeContainer);
            this.Controls.Add(this.chkEnableAutoGenWB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnGen1);
            this.Controls.Add(this.txtSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLte Form Generetor for Webform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnGen1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkEnableAutoGenWB;
        private System.Windows.Forms.CheckBox chkIncludeContainer;
    }
}

