namespace NavigationAdo.net
{
    partial class linq
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
            this.ajouterBTN = new System.Windows.Forms.Button();
            this.precedentBTN = new System.Windows.Forms.Button();
            this.suivantBTN = new System.Windows.Forms.Button();
            this.dernierbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtlieu = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ajouterBTN
            // 
            this.ajouterBTN.Location = new System.Drawing.Point(350, 239);
            this.ajouterBTN.Name = "ajouterBTN";
            this.ajouterBTN.Size = new System.Drawing.Size(75, 23);
            this.ajouterBTN.TabIndex = 26;
            this.ajouterBTN.Text = "ajouter";
            this.ajouterBTN.UseVisualStyleBackColor = true;
            this.ajouterBTN.Click += new System.EventHandler(this.ajouterBTN_Click);
            // 
            // precedentBTN
            // 
            this.precedentBTN.Location = new System.Drawing.Point(451, 239);
            this.precedentBTN.Name = "precedentBTN";
            this.precedentBTN.Size = new System.Drawing.Size(75, 23);
            this.precedentBTN.TabIndex = 25;
            this.precedentBTN.Text = "supprimer";
            this.precedentBTN.UseVisualStyleBackColor = true;
            this.precedentBTN.Click += new System.EventHandler(this.precedentBTN_Click);
            // 
            // suivantBTN
            // 
            this.suivantBTN.Location = new System.Drawing.Point(567, 239);
            this.suivantBTN.Name = "suivantBTN";
            this.suivantBTN.Size = new System.Drawing.Size(75, 23);
            this.suivantBTN.TabIndex = 24;
            this.suivantBTN.Text = "modifier";
            this.suivantBTN.UseVisualStyleBackColor = true;
            this.suivantBTN.Click += new System.EventHandler(this.suivantBTN_Click);
            // 
            // dernierbtn
            // 
            this.dernierbtn.Location = new System.Drawing.Point(681, 240);
            this.dernierbtn.Name = "dernierbtn";
            this.dernierbtn.Size = new System.Drawing.Size(75, 23);
            this.dernierbtn.TabIndex = 23;
            this.dernierbtn.Text = "recherche";
            this.dernierbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 178);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // txtlieu
            // 
            this.txtlieu.Location = new System.Drawing.Point(204, 147);
            this.txtlieu.Name = "txtlieu";
            this.txtlieu.Size = new System.Drawing.Size(100, 20);
            this.txtlieu.TabIndex = 21;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(204, 87);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 20;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(204, 37);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lieu  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Num : ";
            // 
            // linq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ajouterBTN);
            this.Controls.Add(this.precedentBTN);
            this.Controls.Add(this.suivantBTN);
            this.Controls.Add(this.dernierbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtlieu);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "linq";
            this.Text = "linq";
            this.Load += new System.EventHandler(this.linq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ajouterBTN;
        private System.Windows.Forms.Button precedentBTN;
        private System.Windows.Forms.Button suivantBTN;
        private System.Windows.Forms.Button dernierbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtlieu;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}