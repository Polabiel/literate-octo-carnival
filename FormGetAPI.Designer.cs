namespace WinFormGetAPI
{
    partial class FormGetAPI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.field_logradouro = new System.Windows.Forms.TextBox();
            this.text_logradouro = new System.Windows.Forms.Label();
            this.txtResponseCep = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.textCEP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.field_complemento = new System.Windows.Forms.TextBox();
            this.text_complemento = new System.Windows.Forms.Label();
            this.field_bairro = new System.Windows.Forms.TextBox();
            this.text_bairro = new System.Windows.Forms.Label();
            this.field_localidade = new System.Windows.Forms.TextBox();
            this.text_localidade = new System.Windows.Forms.Label();
            this.field_uf = new System.Windows.Forms.TextBox();
            this.text_uf = new System.Windows.Forms.Label();
            this.field_ibge = new System.Windows.Forms.TextBox();
            this.text_ibge = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.field_ibge);
            this.pnlMain.Controls.Add(this.text_ibge);
            this.pnlMain.Controls.Add(this.field_uf);
            this.pnlMain.Controls.Add(this.text_uf);
            this.pnlMain.Controls.Add(this.field_localidade);
            this.pnlMain.Controls.Add(this.text_localidade);
            this.pnlMain.Controls.Add(this.field_bairro);
            this.pnlMain.Controls.Add(this.text_bairro);
            this.pnlMain.Controls.Add(this.field_complemento);
            this.pnlMain.Controls.Add(this.text_complemento);
            this.pnlMain.Controls.Add(this.field_logradouro);
            this.pnlMain.Controls.Add(this.text_logradouro);
            this.pnlMain.Controls.Add(this.txtResponseCep);
            this.pnlMain.Controls.Add(this.btnRequest);
            this.pnlMain.Controls.Add(this.txtURI);
            this.pnlMain.Controls.Add(this.textCEP);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(540, 302);
            this.pnlMain.TabIndex = 0;
            // 
            // field_logradouro
            // 
            this.field_logradouro.Location = new System.Drawing.Point(168, 102);
            this.field_logradouro.Multiline = true;
            this.field_logradouro.Name = "field_logradouro";
            this.field_logradouro.Size = new System.Drawing.Size(128, 34);
            this.field_logradouro.TabIndex = 6;
            // 
            // text_logradouro
            // 
            this.text_logradouro.AutoSize = true;
            this.text_logradouro.Location = new System.Drawing.Point(168, 79);
            this.text_logradouro.Name = "text_logradouro";
            this.text_logradouro.Size = new System.Drawing.Size(91, 20);
            this.text_logradouro.TabIndex = 5;
            this.text_logradouro.Text = "Logradouro";
            // 
            // txtResponseCep
            // 
            this.txtResponseCep.Location = new System.Drawing.Point(15, 102);
            this.txtResponseCep.Multiline = true;
            this.txtResponseCep.Name = "txtResponseCep";
            this.txtResponseCep.Size = new System.Drawing.Size(128, 34);
            this.txtResponseCep.TabIndex = 3;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(421, 20);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(55, 46);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Go";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(15, 40);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(319, 26);
            this.txtURI.TabIndex = 2;
            this.txtURI.Text = "https://opencep.com/v1/13020060";
            // 
            // textCEP
            // 
            this.textCEP.AutoSize = true;
            this.textCEP.Location = new System.Drawing.Point(15, 79);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(41, 20);
            this.textCEP.TabIndex = 1;
            this.textCEP.Text = "CEP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request URI";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(456, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // field_complemento
            // 
            this.field_complemento.Location = new System.Drawing.Point(15, 170);
            this.field_complemento.Multiline = true;
            this.field_complemento.Name = "field_complemento";
            this.field_complemento.Size = new System.Drawing.Size(128, 34);
            this.field_complemento.TabIndex = 8;
            // 
            // text_complemento
            // 
            this.text_complemento.AutoSize = true;
            this.text_complemento.Location = new System.Drawing.Point(15, 147);
            this.text_complemento.Name = "text_complemento";
            this.text_complemento.Size = new System.Drawing.Size(108, 20);
            this.text_complemento.TabIndex = 7;
            this.text_complemento.Text = "Complemento";
            // 
            // field_bairro
            // 
            this.field_bairro.Location = new System.Drawing.Point(168, 170);
            this.field_bairro.Multiline = true;
            this.field_bairro.Name = "field_bairro";
            this.field_bairro.Size = new System.Drawing.Size(128, 34);
            this.field_bairro.TabIndex = 10;
            // 
            // text_bairro
            // 
            this.text_bairro.AutoSize = true;
            this.text_bairro.Location = new System.Drawing.Point(168, 147);
            this.text_bairro.Name = "text_bairro";
            this.text_bairro.Size = new System.Drawing.Size(51, 20);
            this.text_bairro.TabIndex = 9;
            this.text_bairro.Text = "Bairro";
            // 
            // field_localidade
            // 
            this.field_localidade.Location = new System.Drawing.Point(15, 233);
            this.field_localidade.Multiline = true;
            this.field_localidade.Name = "field_localidade";
            this.field_localidade.Size = new System.Drawing.Size(128, 34);
            this.field_localidade.TabIndex = 12;
            // 
            // text_localidade
            // 
            this.text_localidade.AutoSize = true;
            this.text_localidade.Location = new System.Drawing.Point(15, 210);
            this.text_localidade.Name = "text_localidade";
            this.text_localidade.Size = new System.Drawing.Size(86, 20);
            this.text_localidade.TabIndex = 11;
            this.text_localidade.Text = "Localidade";
            // 
            // field_uf
            // 
            this.field_uf.Location = new System.Drawing.Point(168, 233);
            this.field_uf.Multiline = true;
            this.field_uf.Name = "field_uf";
            this.field_uf.Size = new System.Drawing.Size(128, 34);
            this.field_uf.TabIndex = 14;
            // 
            // text_uf
            // 
            this.text_uf.AutoSize = true;
            this.text_uf.Location = new System.Drawing.Point(168, 210);
            this.text_uf.Name = "text_uf";
            this.text_uf.Size = new System.Drawing.Size(31, 20);
            this.text_uf.TabIndex = 13;
            this.text_uf.Text = "UF";
            // 
            // field_ibge
            // 
            this.field_ibge.Location = new System.Drawing.Point(317, 102);
            this.field_ibge.Multiline = true;
            this.field_ibge.Name = "field_ibge";
            this.field_ibge.Size = new System.Drawing.Size(128, 34);
            this.field_ibge.TabIndex = 16;
            // 
            // text_ibge
            // 
            this.text_ibge.AutoSize = true;
            this.text_ibge.Location = new System.Drawing.Point(317, 79);
            this.text_ibge.Name = "text_ibge";
            this.text_ibge.Size = new System.Drawing.Size(49, 20);
            this.text_ibge.TabIndex = 15;
            this.text_ibge.Text = "IBGE";
            // 
            // FormGetAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGetAPI";
            this.Text = "Get API Request";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtResponseCep;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Label textCEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox field_logradouro;
        private System.Windows.Forms.Label text_logradouro;
        private System.Windows.Forms.TextBox field_ibge;
        private System.Windows.Forms.Label text_ibge;
        private System.Windows.Forms.TextBox field_uf;
        private System.Windows.Forms.Label text_uf;
        private System.Windows.Forms.TextBox field_localidade;
        private System.Windows.Forms.Label text_localidade;
        private System.Windows.Forms.TextBox field_bairro;
        private System.Windows.Forms.Label text_bairro;
        private System.Windows.Forms.TextBox field_complemento;
        private System.Windows.Forms.Label text_complemento;
    }
}

