namespace OcarinaBox
{
    partial class OcarinaBBox
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValidationButton = new System.Windows.Forms.Button();
            this.textBoxMP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label4.Location = new System.Drawing.Point(490, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(737, 555);
            this.label4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 18;
            // 
            // ValidationButton
            // 
            this.ValidationButton.BackColor = System.Drawing.Color.ForestGreen;
            this.ValidationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValidationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ValidationButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F);
            this.ValidationButton.Location = new System.Drawing.Point(0, 567);
            this.ValidationButton.Name = "ValidationButton";
            this.ValidationButton.Size = new System.Drawing.Size(1227, 74);
            this.ValidationButton.TabIndex = 17;
            this.ValidationButton.Text = "Valider";
            this.ValidationButton.UseVisualStyleBackColor = false;
            this.ValidationButton.Click += new System.EventHandler(this.ValidationButton_Click);
            // 
            // textBoxMP
            // 
            this.textBoxMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMP.Font = new System.Drawing.Font("Arial Narrow", 19.8F);
            this.textBoxMP.Location = new System.Drawing.Point(12, 366);
            this.textBoxMP.Name = "textBoxMP";
            this.textBoxMP.Size = new System.Drawing.Size(472, 45);
            this.textBoxMP.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label2.Location = new System.Drawing.Point(9, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label1.Location = new System.Drawing.Point(9, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom Utilisateur :";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Arial Narrow", 19.8F);
            this.textBoxName.Location = new System.Drawing.Point(12, 278);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(472, 45);
            this.textBoxName.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.DimGray;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(12, 417);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(472, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::OcarinaBox.Properties.Resources.logo_ocarina;
            this.pictureBox1.InitialImage = global::OcarinaBox.Properties.Resources.logo_ocarina;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // OcarinaBBox
            // 
            this.AcceptButton = this.ValidationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1227, 641);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValidationButton);
            this.Controls.Add(this.textBoxMP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "OcarinaBBox";
            this.Text = "OcarianBox";
            this.Load += new System.EventHandler(this.OcarinaBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ValidationButton;
        private System.Windows.Forms.TextBox textBoxMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

