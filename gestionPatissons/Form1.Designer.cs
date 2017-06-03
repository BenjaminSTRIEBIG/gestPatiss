namespace gestionPatissons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnVerifAnnonces = new System.Windows.Forms.Button();
            this.btnAjouteRecette = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerifAnnonces
            // 
            this.btnVerifAnnonces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerifAnnonces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerifAnnonces.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifAnnonces.Location = new System.Drawing.Point(41, 12);
            this.btnVerifAnnonces.Name = "btnVerifAnnonces";
            this.btnVerifAnnonces.Size = new System.Drawing.Size(176, 74);
            this.btnVerifAnnonces.TabIndex = 0;
            this.btnVerifAnnonces.Text = "Verifier les Annonces";
            this.btnVerifAnnonces.UseVisualStyleBackColor = false;
            this.btnVerifAnnonces.Click += new System.EventHandler(this.btnVerifAnnonces_Click);
            // 
            // btnAjouteRecette
            // 
            this.btnAjouteRecette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAjouteRecette.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnAjouteRecette.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAjouteRecette.Location = new System.Drawing.Point(41, 118);
            this.btnAjouteRecette.Name = "btnAjouteRecette";
            this.btnAjouteRecette.Size = new System.Drawing.Size(176, 74);
            this.btnAjouteRecette.TabIndex = 1;
            this.btnAjouteRecette.Text = "Ajouter une Recette";
            this.btnAjouteRecette.UseVisualStyleBackColor = false;
            this.btnAjouteRecette.Click += new System.EventHandler(this.btnAjouteRecette_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(260, 204);
            this.Controls.Add(this.btnAjouteRecette);
            this.Controls.Add(this.btnVerifAnnonces);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GestPatiss";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerifAnnonces;
        private System.Windows.Forms.Button btnAjouteRecette;
    }
}

