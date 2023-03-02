namespace NavigationAdo.net
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtfonction = new System.Windows.Forms.TextBox();
            this.txtsalaire = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dernierbtn = new System.Windows.Forms.Button();
            this.suivantBTN = new System.Windows.Forms.Button();
            this.precedentBTN = new System.Windows.Forms.Button();
            this.premierBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fonction : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "salaire : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N_dept : ";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(199, 46);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 4;
            // 
            // txtfonction
            // 
            this.txtfonction.Location = new System.Drawing.Point(199, 96);
            this.txtfonction.Name = "txtfonction";
            this.txtfonction.Size = new System.Drawing.Size(100, 20);
            this.txtfonction.TabIndex = 5;
            // 
            // txtsalaire
            // 
            this.txtsalaire.Location = new System.Drawing.Point(199, 156);
            this.txtsalaire.Name = "txtsalaire";
            this.txtsalaire.Size = new System.Drawing.Size(100, 20);
            this.txtsalaire.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 178);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dernierbtn
            // 
            this.dernierbtn.Location = new System.Drawing.Point(676, 249);
            this.dernierbtn.Name = "dernierbtn";
            this.dernierbtn.Size = new System.Drawing.Size(75, 23);
            this.dernierbtn.TabIndex = 9;
            this.dernierbtn.Text = "dernier";
            this.dernierbtn.UseVisualStyleBackColor = true;
            this.dernierbtn.Click += new System.EventHandler(this.dernierbtn_Click);
            // 
            // suivantBTN
            // 
            this.suivantBTN.Location = new System.Drawing.Point(562, 248);
            this.suivantBTN.Name = "suivantBTN";
            this.suivantBTN.Size = new System.Drawing.Size(75, 23);
            this.suivantBTN.TabIndex = 10;
            this.suivantBTN.Text = "suivant";
            this.suivantBTN.UseVisualStyleBackColor = true;
            this.suivantBTN.Click += new System.EventHandler(this.suivantBTN_Click);
            // 
            // precedentBTN
            // 
            this.precedentBTN.Location = new System.Drawing.Point(446, 248);
            this.precedentBTN.Name = "precedentBTN";
            this.precedentBTN.Size = new System.Drawing.Size(75, 23);
            this.precedentBTN.TabIndex = 11;
            this.precedentBTN.Text = "precedent";
            this.precedentBTN.UseVisualStyleBackColor = true;
            this.precedentBTN.Click += new System.EventHandler(this.precedentBTN_Click);
            // 
            // premierBTN
            // 
            this.premierBTN.Location = new System.Drawing.Point(345, 248);
            this.premierBTN.Name = "premierBTN";
            this.premierBTN.Size = new System.Drawing.Size(75, 23);
            this.premierBTN.TabIndex = 12;
            this.premierBTN.Text = "premier";
            this.premierBTN.UseVisualStyleBackColor = true;
            this.premierBTN.Click += new System.EventHandler(this.premierBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "supprimer depuis checkbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "exporter vers XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "Importer debuis XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 43);
            this.button4.TabIndex = 17;
            this.button4.Text = "exporter vers TXT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.premierBTN);
            this.Controls.Add(this.precedentBTN);
            this.Controls.Add(this.suivantBTN);
            this.Controls.Add(this.dernierbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsalaire);
            this.Controls.Add(this.txtfonction);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtfonction;
        private System.Windows.Forms.TextBox txtsalaire;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dernierbtn;
        private System.Windows.Forms.Button suivantBTN;
        private System.Windows.Forms.Button precedentBTN;
        private System.Windows.Forms.Button premierBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

