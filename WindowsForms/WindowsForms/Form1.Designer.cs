namespace WindowsForms
{
    partial class Form1
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
            this.grid_TB_VOO = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ddlNivelDor = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radBCapturaN = new System.Windows.Forms.RadioButton();
            this.radBCapturaS = new System.Windows.Forms.RadioButton();
            this.ddlDistancia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TB_VOO)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNivelDor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDistancia)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_TB_VOO
            // 
            this.grid_TB_VOO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TB_VOO.Location = new System.Drawing.Point(13, 49);
            this.grid_TB_VOO.Name = "grid_TB_VOO";
            this.grid_TB_VOO.Size = new System.Drawing.Size(502, 389);
            this.grid_TB_VOO.TabIndex = 0;
            this.grid_TB_VOO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TB_VOO_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACME FLIGHT MANAGER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Location = new System.Drawing.Point(521, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 39);
            this.panel1.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(136, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 32);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(4, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(126, 32);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.ddlNivelDor);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.radBCapturaN);
            this.panel2.Controls.Add(this.radBCapturaS);
            this.panel2.Controls.Add(this.ddlDistancia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCusto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(521, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 343);
            this.panel2.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(136, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 32);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(7, 230);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 32);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ddlNivelDor
            // 
            this.ddlNivelDor.Location = new System.Drawing.Point(64, 127);
            this.ddlNivelDor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ddlNivelDor.Name = "ddlNivelDor";
            this.ddlNivelDor.Size = new System.Drawing.Size(190, 20);
            this.ddlNivelDor.TabIndex = 10;
            this.ddlNivelDor.ValueChanged += new System.EventHandler(this.ddlNivelDor_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nivel Dor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Captura";
            // 
            // radBCapturaN
            // 
            this.radBCapturaN.AutoSize = true;
            this.radBCapturaN.Location = new System.Drawing.Point(171, 104);
            this.radBCapturaN.Name = "radBCapturaN";
            this.radBCapturaN.Size = new System.Drawing.Size(45, 17);
            this.radBCapturaN.TabIndex = 7;
            this.radBCapturaN.TabStop = true;
            this.radBCapturaN.Text = "Não";
            this.radBCapturaN.UseVisualStyleBackColor = true;
            this.radBCapturaN.CheckedChanged += new System.EventHandler(this.radBCapturaN_CheckedChanged);
            // 
            // radBCapturaS
            // 
            this.radBCapturaS.AutoSize = true;
            this.radBCapturaS.Location = new System.Drawing.Point(67, 104);
            this.radBCapturaS.Name = "radBCapturaS";
            this.radBCapturaS.Size = new System.Drawing.Size(42, 17);
            this.radBCapturaS.TabIndex = 6;
            this.radBCapturaS.TabStop = true;
            this.radBCapturaS.Text = "Sim";
            this.radBCapturaS.UseVisualStyleBackColor = true;
            this.radBCapturaS.CheckedChanged += new System.EventHandler(this.radBCapturaS_CheckedChanged);
            // 
            // ddlDistancia
            // 
            this.ddlDistancia.Location = new System.Drawing.Point(67, 70);
            this.ddlDistancia.Name = "ddlDistancia";
            this.ddlDistancia.Size = new System.Drawing.Size(190, 20);
            this.ddlDistancia.TabIndex = 5;
            this.ddlDistancia.ValueChanged += new System.EventHandler(this.ddlDistancia_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Distancia";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(47, 43);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(210, 20);
            this.txtCusto.TabIndex = 3;
            this.txtCusto.TextChanged += new System.EventHandler(this.txtCusto_TextChanged);
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            this.txtCusto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCusto_KeyUp);
            this.txtCusto.Leave += new System.EventHandler(this.txtCusto_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Custo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_TB_VOO);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid_TB_VOO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNivelDor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDistancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_TB_VOO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ddlDistancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radBCapturaS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radBCapturaN;
        private System.Windows.Forms.NumericUpDown ddlNivelDor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}

