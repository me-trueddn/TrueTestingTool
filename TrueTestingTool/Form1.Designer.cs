namespace TrueTestingTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            mailaction1 = new Button();
            radioping = new RadioButton();
            radioporttesting = new RadioButton();
            lblport = new Label();
            lblserver = new Label();
            porttextbox = new TextBox();
            mserverbox = new TextBox();
            tabPage2 = new TabPage();
            mailtestlabelsonuc = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 32);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 406);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(mailtestlabelsonuc);
            tabPage1.Controls.Add(mailaction1);
            tabPage1.Controls.Add(radioping);
            tabPage1.Controls.Add(radioporttesting);
            tabPage1.Controls.Add(lblport);
            tabPage1.Controls.Add(lblserver);
            tabPage1.Controls.Add(porttextbox);
            tabPage1.Controls.Add(mserverbox);
            tabPage1.Cursor = Cursors.IBeam;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 378);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Smtp Test Tool";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // mailaction1
            // 
            mailaction1.Location = new Point(321, 29);
            mailaction1.Name = "mailaction1";
            mailaction1.Size = new Size(128, 23);
            mailaction1.TabIndex = 6;
            mailaction1.Text = "Başlat";
            mailaction1.UseVisualStyleBackColor = true;
            mailaction1.Click += mailaction1_Click;
            // 
            // radioping
            // 
            radioping.AutoSize = true;
            radioping.Location = new Point(400, 7);
            radioping.Name = "radioping";
            radioping.Size = new Size(49, 19);
            radioping.TabIndex = 5;
            radioping.TabStop = true;
            radioping.Text = "Ping";
            radioping.UseVisualStyleBackColor = true;
            // 
            // radioporttesting
            // 
            radioporttesting.AutoSize = true;
            radioporttesting.Location = new Point(320, 7);
            radioporttesting.Name = "radioporttesting";
            radioporttesting.Size = new Size(74, 19);
            radioporttesting.TabIndex = 4;
            radioporttesting.TabStop = true;
            radioporttesting.Text = "Port Testi";
            radioporttesting.UseVisualStyleBackColor = true;
            // 
            // lblport
            // 
            lblport.AutoSize = true;
            lblport.Location = new Point(206, 20);
            lblport.Name = "lblport";
            lblport.Size = new Size(35, 15);
            lblport.TabIndex = 3;
            lblport.Text = "Port :";
            // 
            // lblserver
            // 
            lblserver.AutoSize = true;
            lblserver.Location = new Point(7, 20);
            lblserver.Name = "lblserver";
            lblserver.Size = new Size(45, 15);
            lblserver.TabIndex = 2;
            lblserver.Text = "Server :";
            // 
            // porttextbox
            // 
            porttextbox.Location = new Point(247, 16);
            porttextbox.Name = "porttextbox";
            porttextbox.Size = new Size(31, 23);
            porttextbox.TabIndex = 1;
            // 
            // mserverbox
            // 
            mserverbox.Location = new Point(55, 16);
            mserverbox.Name = "mserverbox";
            mserverbox.Size = new Size(144, 23);
            mserverbox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 378);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // mailtestlabelsonuc
            // 
            mailtestlabelsonuc.AutoSize = true;
            mailtestlabelsonuc.Location = new Point(597, 28);
            mailtestlabelsonuc.Name = "mailtestlabelsonuc";
            mailtestlabelsonuc.Size = new Size(37, 15);
            mailtestlabelsonuc.TabIndex = 7;
            mailtestlabelsonuc.Text = "..........";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "True TrueDDN Sistem Admin Araçları";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox porttextbox;
        private TextBox mserverbox;
        private Label lblserver;
        private Label lblport;
        private Button mailaction1;
        private RadioButton radioping;
        private RadioButton radioporttesting;
        private Label mailtestlabelsonuc;
    }
}
