namespace meow_meow_gang_u_prodavnici
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
            listaProizvoda = new ListBox();
            groupBox1 = new GroupBox();
            reset = new Button();
            label1 = new Label();
            cena_pretraga = new CheckBox();
            ime_pretraga = new CheckBox();
            upc_pretraga = new CheckBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            opadajuce_radio = new RadioButton();
            rastuce_radio = new RadioButton();
            sortiraj = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listaProizvoda
            // 
            listaProizvoda.FormattingEnabled = true;
            listaProizvoda.ItemHeight = 15;
            listaProizvoda.Location = new Point(33, 101);
            listaProizvoda.Name = "listaProizvoda";
            listaProizvoda.Size = new Size(258, 184);
            listaProizvoda.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(reset);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cena_pretraga);
            groupBox1.Controls.Add(ime_pretraga);
            groupBox1.Controls.Add(upc_pretraga);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(33, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 83);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pretraga";
            // 
            // reset
            // 
            reset.Location = new Point(177, 55);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 4;
            reset.Text = "Resert";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Pretraga:";
            // 
            // cena_pretraga
            // 
            cena_pretraga.AutoSize = true;
            cena_pretraga.Location = new Point(113, 58);
            cena_pretraga.Name = "cena_pretraga";
            cena_pretraga.Size = new Size(53, 19);
            cena_pretraga.TabIndex = 3;
            cena_pretraga.Text = "Cena";
            cena_pretraga.UseVisualStyleBackColor = true;
            cena_pretraga.Click += cena_pretraga_Click;
            // 
            // ime_pretraga
            // 
            ime_pretraga.AutoSize = true;
            ime_pretraga.Location = new Point(61, 58);
            ime_pretraga.Name = "ime_pretraga";
            ime_pretraga.Size = new Size(46, 19);
            ime_pretraga.TabIndex = 2;
            ime_pretraga.Text = "Ime";
            ime_pretraga.UseVisualStyleBackColor = true;
            ime_pretraga.Click += ime_pretraga_Click;
            // 
            // upc_pretraga
            // 
            upc_pretraga.AutoSize = true;
            upc_pretraga.Location = new Point(6, 58);
            upc_pretraga.Name = "upc_pretraga";
            upc_pretraga.Size = new Size(49, 19);
            upc_pretraga.TabIndex = 1;
            upc_pretraga.Text = "UPC";
            upc_pretraga.UseVisualStyleBackColor = true;
            upc_pretraga.Click += upc_pretraga_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(opadajuce_radio);
            groupBox2.Controls.Add(rastuce_radio);
            groupBox2.Controls.Add(sortiraj);
            groupBox2.Location = new Point(33, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(258, 59);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sortiraj";
            // 
            // opadajuce_radio
            // 
            opadajuce_radio.AutoSize = true;
            opadajuce_radio.Location = new Point(85, 24);
            opadajuce_radio.Name = "opadajuce_radio";
            opadajuce_radio.Size = new Size(82, 19);
            opadajuce_radio.TabIndex = 2;
            opadajuce_radio.TabStop = true;
            opadajuce_radio.Text = "Opadajuce";
            opadajuce_radio.UseVisualStyleBackColor = true;
            // 
            // rastuce_radio
            // 
            rastuce_radio.AutoSize = true;
            rastuce_radio.Location = new Point(13, 24);
            rastuce_radio.Name = "rastuce_radio";
            rastuce_radio.Size = new Size(66, 19);
            rastuce_radio.TabIndex = 1;
            rastuce_radio.TabStop = true;
            rastuce_radio.Text = "Rastuce";
            rastuce_radio.UseVisualStyleBackColor = true;
            // 
            // sortiraj
            // 
            sortiraj.Location = new Point(177, 22);
            sortiraj.Name = "sortiraj";
            sortiraj.Size = new Size(75, 23);
            sortiraj.TabIndex = 0;
            sortiraj.Text = "Sortiraj";
            sortiraj.UseVisualStyleBackColor = true;
            sortiraj.Click += sortiraj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 362);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listaProizvoda);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listaProizvoda;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox cena_pretraga;
        private CheckBox ime_pretraga;
        private CheckBox upc_pretraga;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private RadioButton opadajuce_radio;
        private RadioButton rastuce_radio;
        private Button sortiraj;
        private Button reset;
    }
}