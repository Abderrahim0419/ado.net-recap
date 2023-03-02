namespace NavigationAdo.net
{
    partial class connecterFORM
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtpost = new System.Windows.Forms.TextBox();
            this.ajouterBtn = new System.Windows.Forms.Button();
            this.supprimerBTN = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Userid : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Post  :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(131, 57);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(131, 104);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 5;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(131, 146);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 6;
            // 
            // txtpost
            // 
            this.txtpost.Location = new System.Drawing.Point(131, 191);
            this.txtpost.Name = "txtpost";
            this.txtpost.Size = new System.Drawing.Size(100, 20);
            this.txtpost.TabIndex = 7;
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.Location = new System.Drawing.Point(329, 55);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(75, 23);
            this.ajouterBtn.TabIndex = 8;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.UseVisualStyleBackColor = true;
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // supprimerBTN
            // 
            this.supprimerBTN.Location = new System.Drawing.Point(329, 113);
            this.supprimerBTN.Name = "supprimerBTN";
            this.supprimerBTN.Size = new System.Drawing.Size(75, 23);
            this.supprimerBTN.TabIndex = 9;
            this.supprimerBTN.Text = "supprimer";
            this.supprimerBTN.UseVisualStyleBackColor = true;
            this.supprimerBTN.Click += new System.EventHandler(this.supprimerBTN_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Location = new System.Drawing.Point(329, 174);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifierBtn.TabIndex = 10;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // connecterFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "connecterFORM";
            this.Text = "connecterFORM";
            this.Load += new System.EventHandler(this.connecterFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtpost;
        private System.Windows.Forms.Button ajouterBtn;
        private System.Windows.Forms.Button supprimerBTN;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}