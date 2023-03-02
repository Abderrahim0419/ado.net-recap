namespace NavigationAdo.net
{
    partial class DEconnecterForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.supprimerBTN = new System.Windows.Forms.Button();
            this.ajouterBtn = new System.Windows.Forms.Button();
            this.txtpost = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Location = new System.Drawing.Point(319, 155);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifierBtn.TabIndex = 22;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // supprimerBTN
            // 
            this.supprimerBTN.Location = new System.Drawing.Point(319, 94);
            this.supprimerBTN.Name = "supprimerBTN";
            this.supprimerBTN.Size = new System.Drawing.Size(75, 23);
            this.supprimerBTN.TabIndex = 21;
            this.supprimerBTN.Text = "supprimer";
            this.supprimerBTN.UseVisualStyleBackColor = true;
            this.supprimerBTN.Click += new System.EventHandler(this.supprimerBTN_Click);
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.Location = new System.Drawing.Point(319, 36);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(75, 23);
            this.ajouterBtn.TabIndex = 20;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.UseVisualStyleBackColor = true;
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // txtpost
            // 
            this.txtpost.Location = new System.Drawing.Point(121, 172);
            this.txtpost.Name = "txtpost";
            this.txtpost.Size = new System.Drawing.Size(100, 20);
            this.txtpost.TabIndex = 19;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(121, 127);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 18;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(121, 85);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 17;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(121, 38);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Post  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Userid : ";
            // 
            // DEconnecterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.supprimerBTN);
            this.Controls.Add(this.ajouterBtn);
            this.Controls.Add(this.txtpost);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DEconnecterForm";
            this.Text = "DEconnecterForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button supprimerBTN;
        private System.Windows.Forms.Button ajouterBtn;
        private System.Windows.Forms.TextBox txtpost;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}