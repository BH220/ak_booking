namespace AK_Booking
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.axWebBrowser19 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser18 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser17 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser16 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser15 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser14 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser13 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser12 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser11 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser10 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser9 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser8 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser7 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser6 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser5 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser4 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser3 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser2 = new AxSHDocVw.AxWebBrowser();
            this.axWebBrowser1 = new AxSHDocVw.AxWebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnRefreshAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 31);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "탐지";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(174, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(93, 3);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(75, 23);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Location = new System.Drawing.Point(12, 3);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshAll.TabIndex = 2;
            this.btnRefreshAll.Text = "Refresh";
            this.btnRefreshAll.UseVisualStyleBackColor = true;
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser19, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser18, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser17, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.axWebBrowser1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 511);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // axWebBrowser19
            // 
            this.axWebBrowser19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser19.Enabled = true;
            this.axWebBrowser19.Location = new System.Drawing.Point(471, 411);
            this.axWebBrowser19.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser19.OcxState")));
            this.axWebBrowser19.Size = new System.Drawing.Size(228, 97);
            this.axWebBrowser19.TabIndex = 18;
            this.axWebBrowser19.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser18
            // 
            this.axWebBrowser18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser18.Enabled = true;
            this.axWebBrowser18.Location = new System.Drawing.Point(237, 411);
            this.axWebBrowser18.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser18.OcxState")));
            this.axWebBrowser18.Size = new System.Drawing.Size(228, 97);
            this.axWebBrowser18.TabIndex = 17;
            this.axWebBrowser18.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser17
            // 
            this.axWebBrowser17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser17.Enabled = true;
            this.axWebBrowser17.Location = new System.Drawing.Point(3, 411);
            this.axWebBrowser17.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser17.OcxState")));
            this.axWebBrowser17.Size = new System.Drawing.Size(228, 97);
            this.axWebBrowser17.TabIndex = 16;
            this.axWebBrowser17.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser16
            // 
            this.axWebBrowser16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser16.Enabled = true;
            this.axWebBrowser16.Location = new System.Drawing.Point(705, 309);
            this.axWebBrowser16.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser16.OcxState")));
            this.axWebBrowser16.Size = new System.Drawing.Size(230, 96);
            this.axWebBrowser16.TabIndex = 15;
            this.axWebBrowser16.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser15
            // 
            this.axWebBrowser15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser15.Enabled = true;
            this.axWebBrowser15.Location = new System.Drawing.Point(471, 309);
            this.axWebBrowser15.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser15.OcxState")));
            this.axWebBrowser15.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser15.TabIndex = 14;
            this.axWebBrowser15.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser14
            // 
            this.axWebBrowser14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser14.Enabled = true;
            this.axWebBrowser14.Location = new System.Drawing.Point(237, 309);
            this.axWebBrowser14.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser14.OcxState")));
            this.axWebBrowser14.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser14.TabIndex = 13;
            this.axWebBrowser14.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser13
            // 
            this.axWebBrowser13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser13.Enabled = true;
            this.axWebBrowser13.Location = new System.Drawing.Point(3, 309);
            this.axWebBrowser13.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser13.OcxState")));
            this.axWebBrowser13.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser13.TabIndex = 12;
            this.axWebBrowser13.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser12
            // 
            this.axWebBrowser12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser12.Enabled = true;
            this.axWebBrowser12.Location = new System.Drawing.Point(705, 207);
            this.axWebBrowser12.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser12.OcxState")));
            this.axWebBrowser12.Size = new System.Drawing.Size(230, 96);
            this.axWebBrowser12.TabIndex = 11;
            this.axWebBrowser12.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser11
            // 
            this.axWebBrowser11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser11.Enabled = true;
            this.axWebBrowser11.Location = new System.Drawing.Point(471, 207);
            this.axWebBrowser11.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser11.OcxState")));
            this.axWebBrowser11.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser11.TabIndex = 10;
            this.axWebBrowser11.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser10
            // 
            this.axWebBrowser10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser10.Enabled = true;
            this.axWebBrowser10.Location = new System.Drawing.Point(237, 207);
            this.axWebBrowser10.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser10.OcxState")));
            this.axWebBrowser10.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser10.TabIndex = 9;
            this.axWebBrowser10.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser9
            // 
            this.axWebBrowser9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser9.Enabled = true;
            this.axWebBrowser9.Location = new System.Drawing.Point(3, 207);
            this.axWebBrowser9.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser9.OcxState")));
            this.axWebBrowser9.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser9.TabIndex = 8;
            this.axWebBrowser9.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser8
            // 
            this.axWebBrowser8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser8.Enabled = true;
            this.axWebBrowser8.Location = new System.Drawing.Point(705, 105);
            this.axWebBrowser8.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser8.OcxState")));
            this.axWebBrowser8.Size = new System.Drawing.Size(230, 96);
            this.axWebBrowser8.TabIndex = 7;
            this.axWebBrowser8.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser7
            // 
            this.axWebBrowser7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser7.Enabled = true;
            this.axWebBrowser7.Location = new System.Drawing.Point(471, 105);
            this.axWebBrowser7.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser7.OcxState")));
            this.axWebBrowser7.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser7.TabIndex = 6;
            this.axWebBrowser7.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser6
            // 
            this.axWebBrowser6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser6.Enabled = true;
            this.axWebBrowser6.Location = new System.Drawing.Point(237, 105);
            this.axWebBrowser6.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser6.OcxState")));
            this.axWebBrowser6.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser6.TabIndex = 5;
            this.axWebBrowser6.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser5
            // 
            this.axWebBrowser5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser5.Enabled = true;
            this.axWebBrowser5.Location = new System.Drawing.Point(3, 105);
            this.axWebBrowser5.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser5.OcxState")));
            this.axWebBrowser5.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser5.TabIndex = 4;
            this.axWebBrowser5.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser4
            // 
            this.axWebBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser4.Enabled = true;
            this.axWebBrowser4.Location = new System.Drawing.Point(705, 3);
            this.axWebBrowser4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser4.OcxState")));
            this.axWebBrowser4.Size = new System.Drawing.Size(230, 96);
            this.axWebBrowser4.TabIndex = 3;
            this.axWebBrowser4.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser3
            // 
            this.axWebBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser3.Enabled = true;
            this.axWebBrowser3.Location = new System.Drawing.Point(471, 3);
            this.axWebBrowser3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser3.OcxState")));
            this.axWebBrowser3.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser3.TabIndex = 2;
            this.axWebBrowser3.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser2
            // 
            this.axWebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser2.Enabled = true;
            this.axWebBrowser2.Location = new System.Drawing.Point(237, 3);
            this.axWebBrowser2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser2.OcxState")));
            this.axWebBrowser2.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser2.TabIndex = 1;
            this.axWebBrowser2.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // axWebBrowser1
            // 
            this.axWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser1.Enabled = true;
            this.axWebBrowser1.Location = new System.Drawing.Point(3, 3);
            this.axWebBrowser1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser1.OcxState")));
            this.axWebBrowser1.Size = new System.Drawing.Size(228, 96);
            this.axWebBrowser1.TabIndex = 0;
            this.axWebBrowser1.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.axWebBrowser_DocumentComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "미탐지";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AxSHDocVw.AxWebBrowser axWebBrowser18;
        private AxSHDocVw.AxWebBrowser axWebBrowser17;
        private AxSHDocVw.AxWebBrowser axWebBrowser16;
        private AxSHDocVw.AxWebBrowser axWebBrowser15;
        private AxSHDocVw.AxWebBrowser axWebBrowser14;
        private AxSHDocVw.AxWebBrowser axWebBrowser13;
        private AxSHDocVw.AxWebBrowser axWebBrowser12;
        private AxSHDocVw.AxWebBrowser axWebBrowser11;
        private AxSHDocVw.AxWebBrowser axWebBrowser10;
        private AxSHDocVw.AxWebBrowser axWebBrowser9;
        private AxSHDocVw.AxWebBrowser axWebBrowser8;
        private AxSHDocVw.AxWebBrowser axWebBrowser7;
        private AxSHDocVw.AxWebBrowser axWebBrowser6;
        private AxSHDocVw.AxWebBrowser axWebBrowser5;
        private AxSHDocVw.AxWebBrowser axWebBrowser4;
        private AxSHDocVw.AxWebBrowser axWebBrowser3;
        private AxSHDocVw.AxWebBrowser axWebBrowser2;
        private AxSHDocVw.AxWebBrowser axWebBrowser1;
        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.Button btnBooking;
        private AxSHDocVw.AxWebBrowser axWebBrowser19;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

