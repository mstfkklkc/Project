
namespace App1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.northwindC = new System.Windows.Forms.ComboBox();
            this.show = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.silinecekId = new System.Windows.Forms.TextBox();
            this.silinecek = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Post = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.getLog = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 664);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.northwindC);
            this.tabPage1.Controls.Add(this.show);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Get Metodu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(521, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Endpoint Seçiniz :";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.Location = new System.Drawing.Point(137, 103);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(630, 462);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // northwindC
            // 
            this.northwindC.FormattingEnabled = true;
            this.northwindC.Items.AddRange(new object[] {
            "categories",
            "customers",
            "employess",
            "orders",
            "products",
            "shippers",
            "suppliers"});
            this.northwindC.Location = new System.Drawing.Point(280, 11);
            this.northwindC.Name = "northwindC";
            this.northwindC.Size = new System.Drawing.Size(151, 28);
            this.northwindC.TabIndex = 1;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(211, 55);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(94, 29);
            this.show.TabIndex = 0;
            this.show.Text = "Görüntüle";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteText);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.sil);
            this.tabPage2.Controls.Add(this.silinecekId);
            this.tabPage2.Controls.Add(this.silinecek);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Metodu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteText
            // 
            this.deleteText.Location = new System.Drawing.Point(51, 215);
            this.deleteText.Name = "deleteText";
            this.deleteText.ReadOnly = true;
            this.deleteText.Size = new System.Drawing.Size(511, 276);
            this.deleteText.TabIndex = 5;
            this.deleteText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Silinecek ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endpoint Seçiniz :";
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(116, 139);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(94, 29);
            this.sil.TabIndex = 2;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // silinecekId
            // 
            this.silinecekId.Location = new System.Drawing.Point(223, 63);
            this.silinecekId.Name = "silinecekId";
            this.silinecekId.Size = new System.Drawing.Size(125, 27);
            this.silinecekId.TabIndex = 1;
            // 
            // silinecek
            // 
            this.silinecek.FormattingEnabled = true;
            this.silinecek.Items.AddRange(new object[] {
            "categories",
            "customers",
            "employess",
            "orders",
            "products",
            "shippers",
            "suppliers"});
            this.silinecek.Location = new System.Drawing.Point(197, 18);
            this.silinecek.Name = "silinecek";
            this.silinecek.Size = new System.Drawing.Size(151, 28);
            this.silinecek.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.Post);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(843, 631);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Post Metodu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(112, 139);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(580, 475);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(115, 58);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(94, 29);
            this.Post.TabIndex = 2;
            this.Post.Text = "Ekle";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.post_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.getLog);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(843, 631);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Loglar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // getLog
            // 
            this.getLog.Location = new System.Drawing.Point(270, 38);
            this.getLog.Name = "getLog";
            this.getLog.Size = new System.Drawing.Size(151, 32);
            this.getLog.TabIndex = 1;
            this.getLog.Text = "log kayıtlarını getir";
            this.getLog.UseVisualStyleBackColor = true;
            this.getLog.Click += new System.EventHandler(this.getLog_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(773, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 677);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox northwindC;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox silinecekId;
        private System.Windows.Forms.ComboBox silinecek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox deleteText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button getLog;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

