
namespace Mapharmacy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BardeProgression = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Pourcentagelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BardeProgression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // BardeProgression
            // 
            this.BardeProgression.BackColor = System.Drawing.Color.Crimson;
            this.BardeProgression.Controls.Add(this.Pourcentagelbl);
            this.BardeProgression.FillColor = System.Drawing.Color.Crimson;
            this.BardeProgression.FillThickness = 10;
            this.BardeProgression.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BardeProgression.ForeColor = System.Drawing.Color.Crimson;
            this.BardeProgression.InnerColor = System.Drawing.Color.Crimson;
            this.BardeProgression.Location = new System.Drawing.Point(294, 88);
            this.BardeProgression.Minimum = 0;
            this.BardeProgression.Name = "BardeProgression";
            this.BardeProgression.ProgressColor = System.Drawing.Color.White;
            this.BardeProgression.ProgressColor2 = System.Drawing.Color.White;
            this.BardeProgression.ProgressThickness = 10;
            this.BardeProgression.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BardeProgression.ShadowDecoration.Parent = this.BardeProgression;
            this.BardeProgression.Size = new System.Drawing.Size(130, 130);
            this.BardeProgression.TabIndex = 0;
            this.BardeProgression.Text = "guna2CircleProgressBar1";
            // 
            // Pourcentagelbl
            // 
            this.Pourcentagelbl.AutoSize = true;
            this.Pourcentagelbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pourcentagelbl.ForeColor = System.Drawing.Color.White;
            this.Pourcentagelbl.Location = new System.Drawing.Point(37, 45);
            this.Pourcentagelbl.Name = "Pourcentagelbl";
            this.Pourcentagelbl.Size = new System.Drawing.Size(42, 39);
            this.Pourcentagelbl.TabIndex = 2;
            this.Pourcentagelbl.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHARMACY DU ISCAE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Develope par Elhassen";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(689, -5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 59;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(740, 336);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BardeProgression);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BardeProgression.ResumeLayout(false);
            this.BardeProgression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar BardeProgression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Pourcentagelbl;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

