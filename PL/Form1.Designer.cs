namespace PL
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
            panel1 = new Panel();
            newNameLbl = new Label();
            newCategoryNameTxt = new TextBox();
            categoriesLv = new ListView();
            label11 = new Label();
            removeCategoryBtn = new Button();
            editCategoryBtn = new Button();
            label10 = new Label();
            addCategoryBtn = new Button();
            categoryNameTxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            podcastCategoryCb = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            antalAvsnitt = new ColumnHeader();
            namn = new ColumnHeader();
            titel = new ColumnHeader();
            kategori = new ColumnHeader();
            listView1 = new ListView();
            label7 = new Label();
            filterOnCategoryCb = new ComboBox();
            button3 = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            label8 = new Label();
            label9 = new Label();
            button6 = new Button();
            richTextBox1 = new RichTextBox();
            textBox3 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(newNameLbl);
            panel1.Controls.Add(newCategoryNameTxt);
            panel1.Controls.Add(categoriesLv);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(removeCategoryBtn);
            panel1.Controls.Add(editCategoryBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(addCategoryBtn);
            panel1.Controls.Add(categoryNameTxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(podcastCategoryCb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.ImeMode = ImeMode.On;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 602);
            panel1.TabIndex = 0;
            // 
            // newNameLbl
            // 
            newNameLbl.AutoSize = true;
            newNameLbl.Location = new Point(150, 412);
            newNameLbl.Name = "newNameLbl";
            newNameLbl.Size = new Size(64, 15);
            newNameLbl.TabIndex = 25;
            newNameLbl.Text = "Nytt namn";
            // 
            // newCategoryNameTxt
            // 
            newCategoryNameTxt.Location = new Point(150, 434);
            newCategoryNameTxt.Margin = new Padding(3, 2, 3, 2);
            newCategoryNameTxt.Name = "newCategoryNameTxt";
            newCategoryNameTxt.Size = new Size(84, 23);
            newCategoryNameTxt.TabIndex = 24;
            // 
            // categoriesLv
            // 
            categoriesLv.Location = new Point(10, 434);
            categoriesLv.Margin = new Padding(3, 2, 3, 2);
            categoriesLv.Name = "categoriesLv";
            categoriesLv.Size = new Size(115, 140);
            categoriesLv.TabIndex = 23;
            categoriesLv.UseCompatibleStateImageBehavior = false;
            categoriesLv.View = View.List;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(10, 412);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 22;
            label11.Text = "Kategori";
            // 
            // removeCategoryBtn
            // 
            removeCategoryBtn.Location = new Point(149, 550);
            removeCategoryBtn.Name = "removeCategoryBtn";
            removeCategoryBtn.Size = new Size(85, 23);
            removeCategoryBtn.TabIndex = 20;
            removeCategoryBtn.Text = "Ta bort";
            removeCategoryBtn.UseVisualStyleBackColor = true;
            removeCategoryBtn.Click += removeCategoryBtn_Click;
            // 
            // editCategoryBtn
            // 
            editCategoryBtn.Location = new Point(149, 466);
            editCategoryBtn.Name = "editCategoryBtn";
            editCategoryBtn.Size = new Size(85, 23);
            editCategoryBtn.TabIndex = 19;
            editCategoryBtn.Text = "Ändra";
            editCategoryBtn.UseVisualStyleBackColor = true;
            editCategoryBtn.Click += editCategoryBtn_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 363);
            label10.Name = "label10";
            label10.Size = new Size(189, 25);
            label10.TabIndex = 18;
            label10.Text = "Redigera kategorier";
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.Location = new Point(149, 301);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(85, 23);
            addCategoryBtn.TabIndex = 11;
            addCategoryBtn.Text = "Lägg till";
            addCategoryBtn.UseVisualStyleBackColor = true;
            addCategoryBtn.Click += addCategoryBtn_Click_1;
            // 
            // categoryNameTxt
            // 
            categoryNameTxt.Location = new Point(12, 302);
            categoryNameTxt.Name = "categoryNameTxt";
            categoryNameTxt.Size = new Size(113, 23);
            categoryNameTxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 283);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 9;
            label6.Text = "Namn (valfritt)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 234);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 8;
            label5.Text = "Lägg till kategori";
            // 
            // button1
            // 
            button1.Location = new Point(149, 171);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 7;
            button1.Text = "Lägg till";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // podcastCategoryCb
            // 
            podcastCategoryCb.FormattingEnabled = true;
            podcastCategoryCb.Location = new Point(12, 171);
            podcastCategoryCb.Name = "podcastCategoryCb";
            podcastCategoryCb.Size = new Size(113, 23);
            podcastCategoryCb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Kategori";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(85, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(149, 88);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 3;
            label3.Text = "Namn (valfritt)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Podcast URL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "Lägg till flöde";
            // 
            // antalAvsnitt
            // 
            antalAvsnitt.Tag = "";
            antalAvsnitt.Text = "Antal avsnitt";
            antalAvsnitt.Width = 100;
            // 
            // namn
            // 
            namn.Text = "Namn";
            namn.Width = 100;
            // 
            // titel
            // 
            titel.Text = "Titel";
            titel.Width = 100;
            // 
            // kategori
            // 
            kategori.Text = "Kategori";
            kategori.Width = 100;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { antalAvsnitt, namn, titel, kategori });
            listView1.Cursor = Cursors.Hand;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(317, 120);
            listView1.Name = "listView1";
            listView1.Size = new Size(353, 370);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(317, 38);
            label7.Name = "label7";
            label7.Size = new Size(151, 25);
            label7.TabIndex = 11;
            label7.Text = "Flödesöverblick";
            // 
            // filterOnCategoryCb
            // 
            filterOnCategoryCb.FormattingEnabled = true;
            filterOnCategoryCb.Location = new Point(317, 79);
            filterOnCategoryCb.Name = "filterOnCategoryCb";
            filterOnCategoryCb.Size = new Size(121, 23);
            filterOnCategoryCb.TabIndex = 12;
            filterOnCategoryCb.Text = "Filtrera...";
            filterOnCategoryCb.SelectedIndexChanged += filterOnCategoryCb_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(443, 76);
            button3.Name = "button3";
            button3.Size = new Size(85, 23);
            button3.TabIndex = 13;
            button3.Text = "Återställ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView2.FullRowSelect = true;
            listView2.Location = new Point(675, 120);
            listView2.Name = "listView2";
            listView2.Size = new Size(195, 370);
            listView2.TabIndex = 14;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = " ";
            columnHeader1.Width = 220;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(675, 80);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 15;
            label8.Text = "Avsnitt";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(874, 80);
            label9.Name = "label9";
            label9.Size = new Size(187, 25);
            label9.TabIndex = 18;
            label9.Text = "Avsnittsbeskrivning";
            // 
            // button6
            // 
            button6.Location = new Point(317, 550);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(109, 22);
            button6.TabIndex = 19;
            button6.Text = "Ändra Namn";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(874, 120);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(210, 370);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 522);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(317, 500);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 24;
            label12.Text = "Nytt Namn";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(552, 500);
            label13.Name = "label13";
            label13.Size = new Size(69, 15);
            label13.TabIndex = 25;
            label13.Text = "Ny Kategori";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(552, 522);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 23);
            comboBox1.TabIndex = 26;
            // 
            // button2
            // 
            button2.Location = new Point(552, 550);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(117, 22);
            button2.TabIndex = 27;
            button2.Text = "Ändra Kategori";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(576, 80);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(94, 22);
            button4.TabIndex = 28;
            button4.Text = "Radera Flöde";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 602);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBox3);
            Controls.Add(richTextBox1);
            Controls.Add(button6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(listView2);
            Controls.Add(button3);
            Controls.Add(filterOnCategoryCb);
            Controls.Add(label7);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "PodcastLibrary";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private ComboBox podcastCategoryCb;
        private Label label4;
        private TextBox categoryNameTxt;
        private Label label6;
        private Label label5;
        private ColumnHeader antalAvsnitt;
        private ColumnHeader namn;
        private ColumnHeader titel;
        private ColumnHeader kategori;
        private ListView listView1;
        private Button addCategoryBtn;
        private Label label7;
        private ComboBox filterOnCategoryCb;
        private Button button3;
        private ListView listView2;
        private Label label8;
        private Label label9;
        private Button removeCategoryBtn;
        private Button editCategoryBtn;
        private Label label10;
        private Label label11;
        private Button button6;
        private Label newNameLbl;
        private TextBox newCategoryNameTxt;
        private ListView categoriesLv;
        private ColumnHeader columnHeader1;
        private RichTextBox richTextBox1;
        private TextBox textBox3;
        private Label label12;
        private Label label13;
        private ComboBox comboBox1;
        private Button button2;
        private Button button4;
    }
}