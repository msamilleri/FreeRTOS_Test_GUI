
namespace RTOSGUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbox_com = new System.Windows.Forms.ComboBox();
            this.cmbox_baud = new System.Windows.Forms.ComboBox();
            this.label_com = new System.Windows.Forms.Label();
            this.label_baud = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.port_durum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_gerek = new System.Windows.Forms.Label();
            this.label_test = new System.Windows.Forms.Label();
            this.cmbox_gerek = new System.Windows.Forms.ComboBox();
            this.cmbox_testyon = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_box_task1 = new System.Windows.Forms.ComboBox();
            this.txt_box_task3 = new System.Windows.Forms.ComboBox();
            this.txt_box_task2 = new System.Windows.Forms.ComboBox();
            this.txt_box_task4 = new System.Windows.Forms.ComboBox();
            this.listBox_Recv = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbox_com
            // 
            this.cmbox_com.FormattingEnabled = true;
            this.cmbox_com.Location = new System.Drawing.Point(79, 24);
            this.cmbox_com.Name = "cmbox_com";
            this.cmbox_com.Size = new System.Drawing.Size(121, 24);
            this.cmbox_com.TabIndex = 0;
            // 
            // cmbox_baud
            // 
            this.cmbox_baud.FormattingEnabled = true;
            this.cmbox_baud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbox_baud.Location = new System.Drawing.Point(79, 70);
            this.cmbox_baud.Name = "cmbox_baud";
            this.cmbox_baud.Size = new System.Drawing.Size(121, 24);
            this.cmbox_baud.TabIndex = 1;
            // 
            // label_com
            // 
            this.label_com.AutoSize = true;
            this.label_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_com.Location = new System.Drawing.Point(2, 27);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(73, 25);
            this.label_com.TabIndex = 2;
            this.label_com.Text = "COM :";
            // 
            // label_baud
            // 
            this.label_baud.AutoSize = true;
            this.label_baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baud.Location = new System.Drawing.Point(2, 73);
            this.label_baud.Name = "label_baud";
            this.label_baud.Size = new System.Drawing.Size(79, 25);
            this.label_baud.TabIndex = 3;
            this.label_baud.Text = "Baud  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbox_baud);
            this.groupBox1.Controls.Add(this.label_baud);
            this.groupBox1.Controls.Add(this.cmbox_com);
            this.groupBox1.Controls.Add(this.label_com);
            this.groupBox1.Location = new System.Drawing.Point(31, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seri Port";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Lime;
            this.btn_open.Location = new System.Drawing.Point(57, 363);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 33);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "bağlan";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(138, 363);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(93, 33);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "bağ. kapat";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 418);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(162, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // port_durum
            // 
            this.port_durum.AutoSize = true;
            this.port_durum.Location = new System.Drawing.Point(80, 454);
            this.port_durum.Name = "port_durum";
            this.port_durum.Size = new System.Drawing.Size(88, 17);
            this.port_durum.TabIndex = 8;
            this.port_durum.Text = "Port Durumu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbox_testyon);
            this.groupBox2.Controls.Add(this.cmbox_gerek);
            this.groupBox2.Controls.Add(this.label_test);
            this.groupBox2.Controls.Add(this.label_gerek);
            this.groupBox2.Location = new System.Drawing.Point(290, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 137);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // label_gerek
            // 
            this.label_gerek.AutoSize = true;
            this.label_gerek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_gerek.Location = new System.Drawing.Point(17, 31);
            this.label_gerek.Name = "label_gerek";
            this.label_gerek.Size = new System.Drawing.Size(130, 25);
            this.label_gerek.TabIndex = 0;
            this.label_gerek.Text = "Gereksinim :";
            // 
            // label_test
            // 
            this.label_test.AutoSize = true;
            this.label_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_test.Location = new System.Drawing.Point(17, 70);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(115, 25);
            this.label_test.TabIndex = 1;
            this.label_test.Text = "Test yont. :";
            // 
            // cmbox_gerek
            // 
            this.cmbox_gerek.FormattingEnabled = true;
            this.cmbox_gerek.Items.AddRange(new object[] {
            "001_Tasks_Scheduling",
            "002_LedTasks",
            "003(6)_Led_Btn_ISR",
            "004()_Change_Task_Priority",
            "005(8)_Mutex",
            "006(9)_Queue"});
            this.cmbox_gerek.Location = new System.Drawing.Point(120, 31);
            this.cmbox_gerek.Name = "cmbox_gerek";
            this.cmbox_gerek.Size = new System.Drawing.Size(173, 24);
            this.cmbox_gerek.TabIndex = 2;
            this.cmbox_gerek.SelectedValueChanged += new System.EventHandler(this.cmbox_gerek_SelectedValueChanged);
            // 
            // cmbox_testyon
            // 
            this.cmbox_testyon.FormattingEnabled = true;
            this.cmbox_testyon.Location = new System.Drawing.Point(120, 70);
            this.cmbox_testyon.Name = "cmbox_testyon";
            this.cmbox_testyon.Size = new System.Drawing.Size(173, 24);
            this.cmbox_testyon.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_box_task4);
            this.groupBox3.Controls.Add(this.txt_box_task2);
            this.groupBox3.Controls.Add(this.txt_box_task3);
            this.groupBox3.Controls.Add(this.txt_box_task1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(290, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 126);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Task-1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Task-2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(153, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Task-4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(152, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Task-3";
            // 
            // txt_box_task1
            // 
            this.txt_box_task1.FormattingEnabled = true;
            this.txt_box_task1.Location = new System.Drawing.Point(73, 38);
            this.txt_box_task1.Name = "txt_box_task1";
            this.txt_box_task1.Size = new System.Drawing.Size(73, 24);
            this.txt_box_task1.TabIndex = 1;
            // 
            // txt_box_task3
            // 
            this.txt_box_task3.FormattingEnabled = true;
            this.txt_box_task3.Location = new System.Drawing.Point(218, 38);
            this.txt_box_task3.Name = "txt_box_task3";
            this.txt_box_task3.Size = new System.Drawing.Size(73, 24);
            this.txt_box_task3.TabIndex = 1;
            // 
            // txt_box_task2
            // 
            this.txt_box_task2.FormattingEnabled = true;
            this.txt_box_task2.Location = new System.Drawing.Point(73, 78);
            this.txt_box_task2.Name = "txt_box_task2";
            this.txt_box_task2.Size = new System.Drawing.Size(73, 24);
            this.txt_box_task2.TabIndex = 1;
            // 
            // txt_box_task4
            // 
            this.txt_box_task4.FormattingEnabled = true;
            this.txt_box_task4.Location = new System.Drawing.Point(218, 81);
            this.txt_box_task4.Name = "txt_box_task4";
            this.txt_box_task4.Size = new System.Drawing.Size(73, 24);
            this.txt_box_task4.TabIndex = 1;
            // 
            // listBox_Recv
            // 
            this.listBox_Recv.FormattingEnabled = true;
            this.listBox_Recv.ItemHeight = 16;
            this.listBox_Recv.Location = new System.Drawing.Point(613, 248);
            this.listBox_Recv.Name = "listBox_Recv";
            this.listBox_Recv.Size = new System.Drawing.Size(320, 308);
            this.listBox_Recv.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(763, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(334, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 52);
            this.label1.TabIndex = 14;
            this.label1.Text = "RTOS TEST GUI";
            // 
            // btn_gonder
            // 
            this.btn_gonder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_gonder.Location = new System.Drawing.Point(513, 562);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(94, 35);
            this.btn_gonder.TabIndex = 15;
            this.btn_gonder.Text = "gonder";
            this.btn_gonder.UseVisualStyleBackColor = false;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_temizle.Location = new System.Drawing.Point(858, 562);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 38);
            this.btn_temizle.TabIndex = 16;
            this.btn_temizle.Text = "temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(802, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox_Recv);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.port_durum);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbox_com;
        private System.Windows.Forms.ComboBox cmbox_baud;
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.Label label_baud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label port_durum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbox_testyon;
        private System.Windows.Forms.ComboBox cmbox_gerek;
        private System.Windows.Forms.Label label_test;
        private System.Windows.Forms.Label label_gerek;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txt_box_task4;
        private System.Windows.Forms.ComboBox txt_box_task2;
        private System.Windows.Forms.ComboBox txt_box_task3;
        private System.Windows.Forms.ComboBox txt_box_task1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_Recv;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

