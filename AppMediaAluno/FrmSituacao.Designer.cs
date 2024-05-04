
namespace AppMediaAluno
{
    partial class FrmSituacao
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
            this.label6 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lblNomeSituacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMediaSituacao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(33, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(487, 60);
            this.label6.TabIndex = 13;
            this.label6.Text = "Situação do aluno (a):";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(627, 86);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(286, 22);
            this.dtData.TabIndex = 12;
            // 
            // lblNomeSituacao
            // 
            this.lblNomeSituacao.AutoSize = true;
            this.lblNomeSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblNomeSituacao.Location = new System.Drawing.Point(281, 314);
            this.lblNomeSituacao.Name = "lblNomeSituacao";
            this.lblNomeSituacao.Size = new System.Drawing.Size(30, 25);
            this.lblNomeSituacao.TabIndex = 11;
            this.lblNomeSituacao.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome do aluno (a):";
            // 
            // lblMediaSituacao
            // 
            this.lblMediaSituacao.AutoSize = true;
            this.lblMediaSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblMediaSituacao.Location = new System.Drawing.Point(160, 382);
            this.lblMediaSituacao.Name = "lblMediaSituacao";
            this.lblMediaSituacao.Size = new System.Drawing.Size(24, 25);
            this.lblMediaSituacao.TabIndex = 15;
            this.lblMediaSituacao.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Média:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblSituacao.Location = new System.Drawing.Point(666, 382);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(30, 25);
            this.lblSituacao.TabIndex = 17;
            this.lblSituacao.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Situação:";
            // 
            // FrmSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMediaSituacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.lblNomeSituacao);
            this.Controls.Add(this.label1);
            this.Name = "FrmSituacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSituacao";
            this.Load += new System.EventHandler(this.FrmSituacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label lblNomeSituacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMediaSituacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label label5;
    }
}