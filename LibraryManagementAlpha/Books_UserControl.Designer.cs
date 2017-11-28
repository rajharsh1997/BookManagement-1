namespace LibraryManagementAlpha
{
    partial class Books_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Acc_text = new System.Windows.Forms.TextBox();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.Publisher_text = new System.Windows.Forms.TextBox();
            this.ISBN_text = new System.Windows.Forms.TextBox();
            this.Author_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dept_id_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOK ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 26);
            this.textBox1.TabIndex = 1;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(419, 71);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(90, 30);
            this.search.TabIndex = 2;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(884, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(115, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "ADD NEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(392, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(620, 317);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 39);
            this.button5.TabIndex = 7;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Acc No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publisher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ISBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Author:";
            // 
            // Acc_text
            // 
            this.Acc_text.Location = new System.Drawing.Point(96, 388);
            this.Acc_text.Name = "Acc_text";
            this.Acc_text.Size = new System.Drawing.Size(306, 26);
            this.Acc_text.TabIndex = 13;
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(96, 458);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(306, 26);
            this.Name_text.TabIndex = 14;
            // 
            // Publisher_text
            // 
            this.Publisher_text.Location = new System.Drawing.Point(96, 517);
            this.Publisher_text.Name = "Publisher_text";
            this.Publisher_text.Size = new System.Drawing.Size(306, 26);
            this.Publisher_text.TabIndex = 15;
            // 
            // ISBN_text
            // 
            this.ISBN_text.Location = new System.Drawing.Point(581, 455);
            this.ISBN_text.Name = "ISBN_text";
            this.ISBN_text.Size = new System.Drawing.Size(306, 26);
            this.ISBN_text.TabIndex = 16;
            // 
            // Author_text
            // 
            this.Author_text.Location = new System.Drawing.Point(581, 520);
            this.Author_text.Name = "Author_text";
            this.Author_text.Size = new System.Drawing.Size(306, 26);
            this.Author_text.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dept_id";
            // 
            // Dept_id_Text
            // 
            this.Dept_id_Text.Location = new System.Drawing.Point(581, 391);
            this.Dept_id_Text.Name = "Dept_id_Text";
            this.Dept_id_Text.Size = new System.Drawing.Size(306, 26);
            this.Dept_id_Text.TabIndex = 19;
            this.Dept_id_Text.TextChanged += new System.EventHandler(this.Dept_id_Text_TextChanged);
            // 
            // Books_UserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Dept_id_Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Author_text);
            this.Controls.Add(this.ISBN_text);
            this.Controls.Add(this.Publisher_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.Acc_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Books_UserControl";
            this.Size = new System.Drawing.Size(1250, 662);
            this.Load += new System.EventHandler(this.Books_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Acc_text;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox Publisher_text;
        private System.Windows.Forms.TextBox ISBN_text;
        private System.Windows.Forms.TextBox Author_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Dept_id_Text;
    }
}
