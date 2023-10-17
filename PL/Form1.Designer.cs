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
            urllbl = new Label();
            urltxt = new TextBox();
            podcastnamnlbl = new Label();
            textBox1 = new TextBox();
            kategorilbl = new Label();
            kategoricb = new ComboBox();
            overviewlv = new ListView();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // urllbl
            // 
            urllbl.AutoSize = true;
            urllbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            urllbl.Location = new Point(32, 65);
            urllbl.Name = "urllbl";
            urllbl.Size = new Size(92, 20);
            urllbl.TabIndex = 0;
            urllbl.Text = "Podcast URL";
            // 
            // urltxt
            // 
            urltxt.Location = new Point(32, 88);
            urltxt.Name = "urltxt";
            urltxt.Size = new Size(164, 27);
            urltxt.TabIndex = 1;
            // 
            // podcastnamnlbl
            // 
            podcastnamnlbl.AutoSize = true;
            podcastnamnlbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            podcastnamnlbl.Location = new Point(32, 128);
            podcastnamnlbl.Name = "podcastnamnlbl";
            podcastnamnlbl.Size = new Size(104, 20);
            podcastnamnlbl.TabIndex = 2;
            podcastnamnlbl.Text = "Podcast namn";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 3;
            // 
            // kategorilbl
            // 
            kategorilbl.AutoSize = true;
            kategorilbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kategorilbl.Location = new Point(32, 196);
            kategorilbl.Name = "kategorilbl";
            kategorilbl.Size = new Size(67, 20);
            kategorilbl.TabIndex = 4;
            kategorilbl.Text = "Kategori";
            // 
            // kategoricb
            // 
            kategoricb.FormattingEnabled = true;
            kategoricb.Location = new Point(32, 219);
            kategoricb.Name = "kategoricb";
            kategoricb.Size = new Size(164, 28);
            kategoricb.TabIndex = 5;
            // 
            // overviewlv
            // 
            overviewlv.GridLines = true;
            overviewlv.Location = new Point(32, 309);
            overviewlv.Name = "overviewlv";
            overviewlv.Size = new Size(667, 437);
            overviewlv.TabIndex = 6;
            overviewlv.UseCompatibleStateImageBehavior = false;
            overviewlv.View = View.Details;
            // 
            // listView1
            // 
            listView1.GridLines = true;
            listView1.Location = new Point(737, 309);
            listView1.Name = "listView1";
            listView1.Size = new Size(275, 437);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(32, 264);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Lägg till";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(162, 264);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Ändra";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(32, 764);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Ta bort";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(442, 263);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(605, 260);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "Återställ";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(737, 257);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 13;
            label1.Text = "Avsnitt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(442, 240);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 14;
            label2.Text = "Filtrera på kategori";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 892);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(overviewlv);
            Controls.Add(kategoricb);
            Controls.Add(kategorilbl);
            Controls.Add(textBox1);
            Controls.Add(podcastnamnlbl);
            Controls.Add(urltxt);
            Controls.Add(urllbl);
            Name = "Form1";
            Text = "PodcastApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label urllbl;
        private TextBox urltxt;
        private Label podcastnamnlbl;
        private TextBox textBox1;
        private Label kategorilbl;
        private ComboBox kategoricb;
        private ListView overviewlv;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}