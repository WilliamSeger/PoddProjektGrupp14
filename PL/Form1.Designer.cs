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
            label11 = new Label();
            chooseCategoryCb = new ComboBox();
            removeCategoryBtn = new Button();
            changeCategoryBtn = new Button();
            label10 = new Label();
            addCategoryBtn = new Button();
            categoryNameTxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            addFlowBtn = new Button();
            podCategoryCb = new ComboBox();
            label4 = new Label();
            podNameTxt = new TextBox();
            label3 = new Label();
            podUrlTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            antalAvsnitt = new ColumnHeader();
            namn = new ColumnHeader();
            titel = new ColumnHeader();
            frekvens = new ColumnHeader();
            kategori = new ColumnHeader();
            flowOverviewLv = new ListView();
            label7 = new Label();
            filterOnCategoryCb = new ComboBox();
            resetFilterBtn = new Button();
            episodesLv = new ListView();
            label8 = new Label();
            episodeInfoLv = new ListView();
            label9 = new Label();
            editFlowBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(chooseCategoryCb);
            panel1.Controls.Add(removeCategoryBtn);
            panel1.Controls.Add(changeCategoryBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(addCategoryBtn);
            panel1.Controls.Add(categoryNameTxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(addFlowBtn);
            panel1.Controls.Add(podCategoryCb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(podNameTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(podUrlTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.ImeMode = ImeMode.On;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 803);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(12, 550);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 22;
            label11.Text = "Kategori";
            // 
            // chooseCategoryCb
            // 
            chooseCategoryCb.AutoCompleteMode = AutoCompleteMode.Append;
            chooseCategoryCb.AutoCompleteSource = AutoCompleteSource.ListItems;
            chooseCategoryCb.FormattingEnabled = true;
            chooseCategoryCb.Items.AddRange(new object[] { "Historia", "Sport", "Skräck" });
            chooseCategoryCb.Location = new Point(14, 574);
            chooseCategoryCb.Margin = new Padding(3, 4, 3, 4);
            chooseCategoryCb.Name = "chooseCategoryCb";
            chooseCategoryCb.Size = new Size(129, 28);
            chooseCategoryCb.TabIndex = 21;
            // 
            // removeCategoryBtn
            // 
            removeCategoryBtn.Location = new Point(170, 630);
            removeCategoryBtn.Margin = new Padding(3, 4, 3, 4);
            removeCategoryBtn.Name = "removeCategoryBtn";
            removeCategoryBtn.Size = new Size(97, 31);
            removeCategoryBtn.TabIndex = 20;
            removeCategoryBtn.Text = "Ta bort";
            removeCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // changeCategoryBtn
            // 
            changeCategoryBtn.Location = new Point(170, 574);
            changeCategoryBtn.Margin = new Padding(3, 4, 3, 4);
            changeCategoryBtn.Name = "changeCategoryBtn";
            changeCategoryBtn.Size = new Size(97, 31);
            changeCategoryBtn.TabIndex = 19;
            changeCategoryBtn.Text = "Ändra";
            changeCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(14, 484);
            label10.Name = "label10";
            label10.Size = new Size(240, 32);
            label10.TabIndex = 18;
            label10.Text = "Redigera kategorier";
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.Location = new Point(170, 401);
            addCategoryBtn.Margin = new Padding(3, 4, 3, 4);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(97, 31);
            addCategoryBtn.TabIndex = 11;
            addCategoryBtn.Text = "Lägg till";
            addCategoryBtn.UseVisualStyleBackColor = true;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // categoryNameTxt
            // 
            categoryNameTxt.Location = new Point(14, 403);
            categoryNameTxt.Margin = new Padding(3, 4, 3, 4);
            categoryNameTxt.Name = "categoryNameTxt";
            categoryNameTxt.Size = new Size(129, 27);
            categoryNameTxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 377);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 9;
            label6.Text = "Namn (valfritt)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 312);
            label5.Name = "label5";
            label5.Size = new Size(208, 32);
            label5.TabIndex = 8;
            label5.Text = "Lägg till kategori";
            // 
            // addFlowBtn
            // 
            addFlowBtn.Location = new Point(170, 228);
            addFlowBtn.Margin = new Padding(3, 4, 3, 4);
            addFlowBtn.Name = "addFlowBtn";
            addFlowBtn.Size = new Size(97, 31);
            addFlowBtn.TabIndex = 7;
            addFlowBtn.Text = "Lägg till";
            addFlowBtn.UseVisualStyleBackColor = true;
            // 
            // podCategoryCb
            // 
            podCategoryCb.FormattingEnabled = true;
            podCategoryCb.Location = new Point(14, 228);
            podCategoryCb.Margin = new Padding(3, 4, 3, 4);
            podCategoryCb.Name = "podCategoryCb";
            podCategoryCb.Size = new Size(129, 28);
            podCategoryCb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 204);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Kategori";
            // 
            // podNameTxt
            // 
            podNameTxt.Location = new Point(170, 141);
            podNameTxt.Margin = new Padding(3, 4, 3, 4);
            podNameTxt.Name = "podNameTxt";
            podNameTxt.Size = new Size(97, 27);
            podNameTxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(170, 117);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 3;
            label3.Text = "Namn (valfritt)";
            // 
            // podUrlTxt
            // 
            podUrlTxt.Location = new Point(14, 141);
            podUrlTxt.Margin = new Padding(3, 4, 3, 4);
            podUrlTxt.Name = "podUrlTxt";
            podUrlTxt.Size = new Size(129, 27);
            podUrlTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 117);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Podcast URL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 51);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
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
            // frekvens
            // 
            frekvens.Text = "Frekvens(opt)";
            frekvens.Width = 100;
            // 
            // kategori
            // 
            kategori.Text = "Kategori";
            kategori.Width = 100;
            // 
            // flowOverviewLv
            // 
            flowOverviewLv.Columns.AddRange(new ColumnHeader[] { antalAvsnitt, namn, titel, frekvens, kategori });
            flowOverviewLv.Cursor = Cursors.Hand;
            flowOverviewLv.Location = new Point(362, 160);
            flowOverviewLv.Margin = new Padding(3, 4, 3, 4);
            flowOverviewLv.Name = "flowOverviewLv";
            flowOverviewLv.Size = new Size(504, 492);
            flowOverviewLv.TabIndex = 1;
            flowOverviewLv.UseCompatibleStateImageBehavior = false;
            flowOverviewLv.View = View.Details;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(362, 51);
            label7.Name = "label7";
            label7.Size = new Size(192, 32);
            label7.TabIndex = 11;
            label7.Text = "Flödesöverblick";
            // 
            // filterOnCategoryCb
            // 
            filterOnCategoryCb.FormattingEnabled = true;
            filterOnCategoryCb.Items.AddRange(new object[] { "1", "2", "3" });
            filterOnCategoryCb.Location = new Point(362, 105);
            filterOnCategoryCb.Margin = new Padding(3, 4, 3, 4);
            filterOnCategoryCb.Name = "filterOnCategoryCb";
            filterOnCategoryCb.Size = new Size(138, 28);
            filterOnCategoryCb.TabIndex = 12;
            filterOnCategoryCb.Text = "Filtrera...";
            // 
            // resetFilterBtn
            // 
            resetFilterBtn.Location = new Point(518, 105);
            resetFilterBtn.Margin = new Padding(3, 4, 3, 4);
            resetFilterBtn.Name = "resetFilterBtn";
            resetFilterBtn.Size = new Size(97, 31);
            resetFilterBtn.TabIndex = 13;
            resetFilterBtn.Text = "Återställ";
            resetFilterBtn.UseVisualStyleBackColor = true;
            // 
            // episodesLv
            // 
            episodesLv.Location = new Point(872, 160);
            episodesLv.Margin = new Padding(3, 4, 3, 4);
            episodesLv.Name = "episodesLv";
            episodesLv.Size = new Size(237, 492);
            episodesLv.TabIndex = 14;
            episodesLv.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(872, 107);
            label8.Name = "label8";
            label8.Size = new Size(94, 32);
            label8.TabIndex = 15;
            label8.Text = "Avsnitt";
            // 
            // episodeInfoLv
            // 
            episodeInfoLv.Location = new Point(1115, 160);
            episodeInfoLv.Margin = new Padding(3, 4, 3, 4);
            episodeInfoLv.Name = "episodeInfoLv";
            episodeInfoLv.Size = new Size(237, 184);
            episodeInfoLv.TabIndex = 16;
            episodeInfoLv.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1115, 107);
            label9.Name = "label9";
            label9.Size = new Size(239, 32);
            label9.TabIndex = 18;
            label9.Text = "Avsnittsbeskrivning";
            // 
            // editFlowBtn
            // 
            editFlowBtn.Location = new Point(362, 670);
            editFlowBtn.Name = "editFlowBtn";
            editFlowBtn.Size = new Size(121, 29);
            editFlowBtn.TabIndex = 19;
            editFlowBtn.Text = "Redigera flöde";
            editFlowBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 803);
            Controls.Add(editFlowBtn);
            Controls.Add(label9);
            Controls.Add(episodeInfoLv);
            Controls.Add(label8);
            Controls.Add(episodesLv);
            Controls.Add(resetFilterBtn);
            Controls.Add(filterOnCategoryCb);
            Controls.Add(label7);
            Controls.Add(flowOverviewLv);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "PodcastLibrary";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox podNameTxt;
        private Label label3;
        private TextBox podUrlTxt;
        private Label label2;
        private Button addFlowBtn;
        private ComboBox podCategoryCb;
        private Label label4;
        private TextBox categoryNameTxt;
        private Label label6;
        private Label label5;
        private ColumnHeader antalAvsnitt;
        private ColumnHeader namn;
        private ColumnHeader titel;
        private ColumnHeader frekvens;
        private ColumnHeader kategori;
        private ListView flowOverviewLv;
        private Button addCategoryBtn;
        private Label label7;
        private ComboBox filterOnCategoryCb;
        private Button resetFilterBtn;
        private ListView episodesLv;
        private Label label8;
        private ListView episodeInfoLv;
        private Label label9;
        private Button removeCategoryBtn;
        private Button changeCategoryBtn;
        private Label label10;
        private Label label11;
        private ComboBox chooseCategoryCb;
        private Button editFlowBtn;
    }
}