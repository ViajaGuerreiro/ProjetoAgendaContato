
namespace ProjetoAgendaContato
{
    partial class FormConsulta
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
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLsTodos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a opção de busca:";
            // 
            // cbOpcao
            // 
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Telefone",
            "Celular",
            "Email"});
            this.cbOpcao.Location = new System.Drawing.Point(196, 9);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(176, 21);
            this.cbOpcao.TabIndex = 1;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbOpcao_SelectedIndexChanged);
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(21, 36);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(50, 17);
            this.lblOpcao.TabIndex = 2;
            this.lblOpcao.Text = "Opção";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(24, 56);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(161, 20);
            this.txtBusca.TabIndex = 3;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(238, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 27);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLsTodos
            // 
            this.btnLsTodos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLsTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLsTodos.Location = new System.Drawing.Point(488, 75);
            this.btnLsTodos.Name = "btnLsTodos";
            this.btnLsTodos.Size = new System.Drawing.Size(96, 26);
            this.btnLsTodos.TabIndex = 5;
            this.btnLsTodos.Text = "Listar todos";
            this.btnLsTodos.UseVisualStyleBackColor = false;
            this.btnLsTodos.Click += new System.EventHandler(this.btnLsTodos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 308);
            this.dataGridView1.TabIndex = 6;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(603, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLsTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblOpcao);
            this.Controls.Add(this.cbOpcao);
            this.Controls.Add(this.label1);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLsTodos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}