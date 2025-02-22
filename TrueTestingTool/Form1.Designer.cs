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
            groupBox2 = new GroupBox();
            smtplog = new RichTextBox();
            groupBox1 = new GroupBox();
            outauthporttxt = new TextBox();
            inauthporttxt = new TextBox();
            label11 = new Label();
            label10 = new Label();
            messatestbutton = new Button();
            label9 = new Label();
            noneradio = new RadioButton();
            tlsradio = new RadioButton();
            sslradio = new RadioButton();
            label8 = new Label();
            outmailtxt = new TextBox();
            label7 = new Label();
            inmailtxt = new TextBox();
            pwusertxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            mailusertxt = new TextBox();
            label4 = new Label();
            bodyrichtext = new RichTextBox();
            label3 = new Label();
            subjecttext = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tomailtxt = new TextBox();
            formmailtext = new TextBox();
            mailtestlabelsonuc = new Label();
            mailaction1 = new Button();
            radioping = new RadioButton();
            radioporttesting = new RadioButton();
            lblport = new Label();
            lblserver = new Label();
            porttextbox = new TextBox();
            mserverbox = new TextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 32);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1066, 676);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
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
            tabPage1.Size = new Size(1058, 648);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Smtp Test Tool";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(smtplog);
            groupBox2.Location = new Point(7, 488);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1045, 154);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Log";
            // 
            // smtplog
            // 
            smtplog.Location = new Point(31, 22);
            smtplog.Name = "smtplog";
            smtplog.Size = new Size(993, 117);
            smtplog.TabIndex = 10;
            smtplog.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(outauthporttxt);
            groupBox1.Controls.Add(inauthporttxt);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(messatestbutton);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(noneradio);
            groupBox1.Controls.Add(tlsradio);
            groupBox1.Controls.Add(sslradio);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(outmailtxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(inmailtxt);
            groupBox1.Controls.Add(pwusertxt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(mailusertxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(bodyrichtext);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(subjecttext);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tomailtxt);
            groupBox1.Controls.Add(formmailtext);
            groupBox1.Location = new Point(7, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(704, 381);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Message Test";
            // 
            // outauthporttxt
            // 
            outauthporttxt.Location = new Point(615, 138);
            outauthporttxt.Name = "outauthporttxt";
            outauthporttxt.Size = new Size(48, 23);
            outauthporttxt.TabIndex = 35;
            // 
            // inauthporttxt
            // 
            inauthporttxt.Location = new Point(615, 109);
            inauthporttxt.Name = "inauthporttxt";
            inauthporttxt.Size = new Size(48, 23);
            inauthporttxt.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(575, 141);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 33;
            label11.Text = "Port : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(575, 116);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 32;
            label10.Text = "Port : ";
            // 
            // messatestbutton
            // 
            messatestbutton.Location = new Point(454, 192);
            messatestbutton.Name = "messatestbutton";
            messatestbutton.Size = new Size(201, 23);
            messatestbutton.TabIndex = 12;
            messatestbutton.Text = "Başlat";
            messatestbutton.UseVisualStyleBackColor = true;
            messatestbutton.Click += messatestbutton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(453, 25);
            label9.Name = "label9";
            label9.Size = new Size(202, 25);
            label9.TabIndex = 31;
            label9.Text = "Mail Kullanıcı Bilgileri";
            // 
            // noneradio
            // 
            noneradio.AutoSize = true;
            noneradio.Location = new Point(601, 167);
            noneradio.Name = "noneradio";
            noneradio.Size = new Size(54, 19);
            noneradio.TabIndex = 30;
            noneradio.TabStop = true;
            noneradio.Text = "None";
            noneradio.UseVisualStyleBackColor = true;
            // 
            // tlsradio
            // 
            tlsradio.AutoSize = true;
            tlsradio.Location = new Point(527, 167);
            tlsradio.Name = "tlsradio";
            tlsradio.Size = new Size(68, 19);
            tlsradio.TabIndex = 29;
            tlsradio.TabStop = true;
            tlsradio.Text = "StartTLS";
            tlsradio.UseVisualStyleBackColor = true;
            // 
            // sslradio
            // 
            sslradio.AutoSize = true;
            sslradio.Location = new Point(454, 167);
            sslradio.Name = "sslradio";
            sslradio.Size = new Size(67, 19);
            sslradio.TabIndex = 28;
            sslradio.TabStop = true;
            sslradio.Text = "SSL/TLS";
            sslradio.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(359, 141);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 27;
            label8.Text = "Giden Sunucu :";
            // 
            // outmailtxt
            // 
            outmailtxt.Location = new Point(454, 138);
            outmailtxt.Name = "outmailtxt";
            outmailtxt.Size = new Size(115, 23);
            outmailtxt.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 113);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 25;
            label7.Text = "Gelen Sunucu :";
            // 
            // inmailtxt
            // 
            inmailtxt.Location = new Point(454, 110);
            inmailtxt.Name = "inmailtxt";
            inmailtxt.Size = new Size(115, 23);
            inmailtxt.TabIndex = 24;
            // 
            // pwusertxt
            // 
            pwusertxt.Location = new Point(454, 81);
            pwusertxt.Name = "pwusertxt";
            pwusertxt.Size = new Size(209, 23);
            pwusertxt.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 85);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 22;
            label6.Text = "Parola :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 61);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 21;
            label5.Text = "Kullanıcı Adı : ";
            // 
            // mailusertxt
            // 
            mailusertxt.Location = new Point(453, 53);
            mailusertxt.Name = "mailusertxt";
            mailusertxt.Size = new Size(210, 23);
            mailusertxt.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 156);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Body :";
            // 
            // bodyrichtext
            // 
            bodyrichtext.Location = new Point(72, 153);
            bodyrichtext.Name = "bodyrichtext";
            bodyrichtext.Size = new Size(279, 136);
            bodyrichtext.TabIndex = 6;
            bodyrichtext.Text = "Mesaj İçeriğini Buraya Yazınız";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 116);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Subject :";
            // 
            // subjecttext
            // 
            subjecttext.Location = new Point(72, 113);
            subjecttext.Name = "subjecttext";
            subjecttext.Size = new Size(279, 23);
            subjecttext.TabIndex = 4;
            subjecttext.Text = "Mail Başlığını Buraya Yazınız";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 71);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 3;
            label2.Text = "To :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 41);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Form :";
            // 
            // tomailtxt
            // 
            tomailtxt.Location = new Point(72, 68);
            tomailtxt.Name = "tomailtxt";
            tomailtxt.Size = new Size(157, 23);
            tomailtxt.TabIndex = 1;
            tomailtxt.Text = "mail2@mail2.com";
            // 
            // formmailtext
            // 
            formmailtext.Location = new Point(72, 38);
            formmailtext.Name = "formmailtext";
            formmailtext.Size = new Size(157, 23);
            formmailtext.TabIndex = 0;
            formmailtext.Text = "mail@mail.com";
            // 
            // mailtestlabelsonuc
            // 
            mailtestlabelsonuc.AutoSize = true;
            mailtestlabelsonuc.Location = new Point(489, 29);
            mailtestlabelsonuc.Name = "mailtestlabelsonuc";
            mailtestlabelsonuc.Size = new Size(37, 15);
            mailtestlabelsonuc.TabIndex = 7;
            mailtestlabelsonuc.Text = "..........";
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
            tabPage2.Size = new Size(1058, 648);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 720);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "True TrueDDN Sistem Admin Araçları";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RichTextBox bodyrichtext;
        private Label label3;
        private TextBox subjecttext;
        private Label label2;
        private Label label1;
        private TextBox tomailtxt;
        private TextBox formmailtext;
        private GroupBox groupBox2;
        private RichTextBox smtplog;
        private Label label4;
        private Label label9;
        private RadioButton noneradio;
        private RadioButton tlsradio;
        private RadioButton sslradio;
        private Label label8;
        private TextBox outmailtxt;
        private Label label7;
        private TextBox inmailtxt;
        private TextBox pwusertxt;
        private Label label6;
        private Label label5;
        private TextBox mailusertxt;
        private Button messatestbutton;
        private TextBox outauthporttxt;
        private TextBox inauthporttxt;
        private Label label11;
        private Label label10;
    }
}
