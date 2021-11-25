namespace _11900156carnaval.Ui
{
    partial class FrmCarnaval
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomedobloco = new System.Windows.Forms.TextBox();
            this.txtquantpessoas = new System.Windows.Forms.TextBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.dgvcarnaval = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarnaval)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.Location = new System.Drawing.Point(183, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 46);
            this.label4.TabIndex = 19;
            this.label4.Text = "Carnaval";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantidade de pessoas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome do bloco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id";
            // 
            // txtnomedobloco
            // 
            this.txtnomedobloco.Location = new System.Drawing.Point(222, 159);
            this.txtnomedobloco.Name = "txtnomedobloco";
            this.txtnomedobloco.Size = new System.Drawing.Size(100, 20);
            this.txtnomedobloco.TabIndex = 15;
            // 
            // txtquantpessoas
            // 
            this.txtquantpessoas.Location = new System.Drawing.Point(411, 159);
            this.txtquantpessoas.Name = "txtquantpessoas";
            this.txtquantpessoas.Size = new System.Drawing.Size(100, 20);
            this.txtquantpessoas.TabIndex = 14;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(222, 453);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 13;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(222, 424);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 12;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(39, 159);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 11;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(222, 482);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 10;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // dgvcarnaval
            // 
            this.dgvcarnaval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarnaval.Location = new System.Drawing.Point(86, 201);
            this.dgvcarnaval.Name = "dgvcarnaval";
            this.dgvcarnaval.Size = new System.Drawing.Size(372, 217);
            this.dgvcarnaval.TabIndex = 20;
            this.dgvcarnaval.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcarnaval_CellContentClick);
            // 
            // FrmCarnaval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 514);
            this.Controls.Add(this.dgvcarnaval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomedobloco);
            this.Controls.Add(this.txtquantpessoas);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnexcluir);
            this.Name = "FrmCarnaval";
            this.Text = "FrmCarnaval";
            this.Load += new System.EventHandler(this.FrmCarnaval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarnaval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomedobloco;
        private System.Windows.Forms.TextBox txtquantpessoas;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.DataGridView dgvcarnaval;
    }
}