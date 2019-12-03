using Biblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CRUDAlunos.Forms
{
    public partial class Form1 : Form
    {
        List<Aluno> Alunos;
        int contaAlunos = 6;

        public Form1()
        {
            Alunos = new List<Aluno>();
            Alunos.Add(new Aluno { Id = 1, Nome = "Maria", Apelido = "Joana" });
            Alunos.Add(new Aluno { Id = 2, Nome = "João", Apelido = "Félix" });
            Alunos.Add(new Aluno { Id = 3, Nome = "Tiago", Apelido = "Torres" });
            Alunos.Add(new Aluno { Id = 4, Nome = "Ricardo", Apelido = "Lourenço" });
            Alunos.Add(new Aluno { Id = 5, Nome = "Cátia", Apelido = "Oliveira" });
            
            InitializeComponent();
            InitLista();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Aluno novoAluno;

            if (ValidaForm())
            {

                novoAluno = new Aluno
                {
                    Id = contaAlunos,
                    Nome = textBoxPrimeiroNome.Text,
                    Apelido = textBoxApelido.Text,
                };

                Alunos.Add(novoAluno);
                contaAlunos++;

                InitLista();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            textBoxPrimeiroNome.Text = string.Empty;
            textBoxApelido.Text = string.Empty;
        }

        public void InitLista()
        {
            listBoxAlunos.DataSource = null;
            listBoxAlunos.DataSource = Alunos;
            listBoxAlunos.DisplayMember = "NomeCompleto";
 
        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(textBoxPrimeiroNome.Text))
            {
                MessageBox.Show("Insira o seu primeiro nome", 
                    "Erro", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);

                output = false;
            }

            if (string.IsNullOrEmpty(textBoxApelido.Text))
            {
                MessageBox.Show("Insira o seu apelido",
                    "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                output = false;
            }

            return output;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O aluno não vai ser guardado!",
                    "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            textBoxPrimeiroNome.Text = string.Empty;
            textBoxApelido.Text = string.Empty;
        }

        private void btnApagaAuno_Click(object sender, EventArgs e)
        {
            Aluno alunoAApagar = (Aluno)listBoxAlunos.SelectedItem;

            Aluno apagado = null;

            if(alunoAApagar != null)
            {
                foreach(Aluno aluno in Alunos)
                {
                    if(alunoAApagar.Id == aluno.Id)
                    {
                        apagado = aluno;
                    }
                }

                if(apagado != null)
                {
                    DialogResult resposta;

                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.NomeCompleto}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if(DialogResult.OK == resposta)
                    {
                        Alunos.Remove(apagado);
                        InitLista();
                    }
                }
            }
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoAEditar = (Aluno)listBoxAlunos.SelectedItem;
            Aluno editado = null;

            if(alunoAEditar != null)
            {
                foreach(Aluno aluno in Alunos)
                {
                    if(alunoAEditar.Id == aluno.Id)
                    {
                        editado = aluno;
                    }
                }

                //abrir a nova form para editar
                if(editado != null)
                {
                    EditarAlunoForm editarAlunoForm = new EditarAlunoForm(this, editado);
                    editarAlunoForm.Show();
                }
                
            }

        }
    }
}
