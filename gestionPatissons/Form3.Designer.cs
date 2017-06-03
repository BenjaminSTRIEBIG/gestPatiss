namespace gestionPatissons
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTitreRecette = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTexteRecette = new System.Windows.Forms.TextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.txtBoxIngredRecette = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxCoutRecette = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDificultRecette = new System.Windows.Forms.ComboBox();
            this.cmbNoteRecette = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre  :";
            // 
            // txtBoxTitreRecette
            // 
            this.txtBoxTitreRecette.Location = new System.Drawing.Point(84, 25);
            this.txtBoxTitreRecette.Name = "txtBoxTitreRecette";
            this.txtBoxTitreRecette.Size = new System.Drawing.Size(469, 20);
            this.txtBoxTitreRecette.TabIndex = 1;
            this.txtBoxTitreRecette.TextChanged += new System.EventHandler(this.txtBoxTitreRecette_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texte :";
            // 
            // txtBoxTexteRecette
            // 
            this.txtBoxTexteRecette.Location = new System.Drawing.Point(87, 66);
            this.txtBoxTexteRecette.Multiline = true;
            this.txtBoxTexteRecette.Name = "txtBoxTexteRecette";
            this.txtBoxTexteRecette.Size = new System.Drawing.Size(466, 277);
            this.txtBoxTexteRecette.TabIndex = 3;
            this.txtBoxTexteRecette.TextChanged += new System.EventHandler(this.txtBoxTexteRecette_TextChanged);
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIngredients.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblIngredients.Location = new System.Drawing.Point(12, 377);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(69, 13);
            this.lblIngredients.TabIndex = 4;
            this.lblIngredients.Text = "Ingredients :";
            // 
            // txtBoxIngredRecette
            // 
            this.txtBoxIngredRecette.Location = new System.Drawing.Point(87, 377);
            this.txtBoxIngredRecette.Multiline = true;
            this.txtBoxIngredRecette.Name = "txtBoxIngredRecette";
            this.txtBoxIngredRecette.Size = new System.Drawing.Size(466, 229);
            this.txtBoxIngredRecette.TabIndex = 5;
            this.txtBoxIngredRecette.TextChanged += new System.EventHandler(this.txtBoxIngredRecette_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.button1.Location = new System.Drawing.Point(686, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Photo1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.button2.Location = new System.Drawing.Point(686, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Photo4";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.button3.Location = new System.Drawing.Point(686, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Photo3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.button4.Location = new System.Drawing.Point(685, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Photo2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.button5.Location = new System.Drawing.Point(662, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 51);
            this.button5.TabIndex = 10;
            this.button5.Text = "COULEUR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(614, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cout Moyen :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(614, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dificulté :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.Location = new System.Drawing.Point(614, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Note  :";
            // 
            // txtBoxCoutRecette
            // 
            this.txtBoxCoutRecette.Location = new System.Drawing.Point(692, 387);
            this.txtBoxCoutRecette.Name = "txtBoxCoutRecette";
            this.txtBoxCoutRecette.Size = new System.Drawing.Size(52, 20);
            this.txtBoxCoutRecette.TabIndex = 14;
            this.txtBoxCoutRecette.TextChanged += new System.EventHandler(this.txtBoxCoutRecette_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(617, 511);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(229, 60);
            this.button6.TabIndex = 17;
            this.button6.Text = "AJOUTER";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label6.Location = new System.Drawing.Point(750, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "€";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbDificultRecette
            // 
            this.cmbDificultRecette.ForeColor = System.Drawing.Color.YellowGreen;
            this.cmbDificultRecette.FormattingEnabled = true;
            this.cmbDificultRecette.Location = new System.Drawing.Point(692, 423);
            this.cmbDificultRecette.Name = "cmbDificultRecette";
            this.cmbDificultRecette.Size = new System.Drawing.Size(121, 21);
            this.cmbDificultRecette.TabIndex = 19;
            this.cmbDificultRecette.SelectedIndexChanged += new System.EventHandler(this.cmbDificultRecette_SelectedIndexChanged);
            // 
            // cmbNoteRecette
            // 
            this.cmbNoteRecette.FormattingEnabled = true;
            this.cmbNoteRecette.Location = new System.Drawing.Point(692, 459);
            this.cmbNoteRecette.Name = "cmbNoteRecette";
            this.cmbNoteRecette.Size = new System.Drawing.Size(121, 21);
            this.cmbNoteRecette.TabIndex = 20;
            this.cmbNoteRecette.SelectedIndexChanged += new System.EventHandler(this.cmbNoteRecette_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(929, 624);
            this.Controls.Add(this.cmbNoteRecette);
            this.Controls.Add(this.cmbDificultRecette);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtBoxCoutRecette);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxIngredRecette);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.txtBoxTexteRecette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTitreRecette);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Ajout de recettes";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTitreRecette;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTexteRecette;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.TextBox txtBoxIngredRecette;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxCoutRecette;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDificultRecette;
        private System.Windows.Forms.ComboBox cmbNoteRecette;
    }
}