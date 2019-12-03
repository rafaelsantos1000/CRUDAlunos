namespace CRUDAlunos.Forms
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPrimeiroNome = new System.Windows.Forms.TextBox();
            this.textBoxApelido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listBoxAlunos = new System.Windows.Forms.ListBox();
            this.btnApagaAuno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(247, 64);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(235, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // textBoxPrimeiroNome
            // 
            this.textBoxPrimeiroNome.Location = new System.Drawing.Point(247, 126);
            this.textBoxPrimeiroNome.Name = "textBoxPrimeiroNome";
            this.textBoxPrimeiroNome.Size = new System.Drawing.Size(338, 20);
            this.textBoxPrimeiroNome.TabIndex = 1;
            // 
            // textBoxApelido
            // 
            this.textBoxApelido.Location = new System.Drawing.Point(247, 192);
            this.textBoxApelido.Name = "textBoxApelido";
            this.textBoxApelido.Size = new System.Drawing.Size(338, 20);
            this.textBoxApelido.TabIndex = 2;
            this.textBoxApelido.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id de aluno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apelido de aluno :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do aluno :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(352, 255);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 45);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(487, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listBoxAlunos
            // 
            this.listBoxAlunos.FormattingEnabled = true;
            this.listBoxAlunos.Location = new System.Drawing.Point(66, 346);
            this.listBoxAlunos.Name = "listBoxAlunos";
            this.listBoxAlunos.Size = new System.Drawing.Size(519, 95);
            this.listBoxAlunos.TabIndex = 8;
            // 
            // btnApagaAuno
            // 
            this.btnApagaAuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagaAuno.Location = new System.Drawing.Point(635, 346);
            this.btnApagaAuno.Name = "btnApagaAuno";
            this.btnApagaAuno.Size = new System.Drawing.Size(127, 45);
            this.btnApagaAuno.TabIndex = 9;
            this.btnApagaAuno.Text = "Apagar aluno selecionado";
            this.btnApagaAuno.UseVisualStyleBackColor = true;
            this.btnApagaAuno.Click += new System.EventHandler(this.btnApagaAuno_Click);
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.Location = new System.Drawing.Point(635, 396);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(127, 45);
            this.btnEditarAluno.TabIndex = 10;
            this.btnEditarAluno.Text = "Editar aluno selecionado";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 470);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.btnApagaAuno);
            this.Controls.Add(this.listBoxAlunos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApelido);
            this.Controls.Add(this.textBoxPrimeiroNome);
            this.Controls.Add(this.textBoxId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPrimeiroNome;
        private System.Windows.Forms.TextBox textBoxApelido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox listBoxAlunos;
        private System.Windows.Forms.Button btnApagaAuno;
        private System.Windows.Forms.Button btnEditarAluno;
    }
}

