    namespace MauiAppProjeto
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
            }

            private void CalcularMedia_Clicked(object sender, EventArgs e)
            {
                try
                {
           
                    if (string.IsNullOrWhiteSpace(txtQtdAlunos.Text) ||
                        string.IsNullOrWhiteSpace(txtNotas.Text))
                    {
                        DisplayAlertAsync("Aviso", "Preencha todos os campos!", "OK");
                        return;
                    }

                    int qtdAlunos = int.Parse(txtQtdAlunos.Text);
                    
                     // Divide o texto digitado no campo de notas (ex: "7.5,8.0,6.5") em partes separadas por vírgula,
                    // criando um array onde cada posição representa uma nota individual.
                    string[] notasTexto = txtNotas.Text.Split(',');

                    if (notasTexto.Length != qtdAlunos)
                    {
                        DisplayAlertAsync("Erro", $"Você informou {notasTexto.Length} notas, mas disse que há {qtdAlunos} alunos.", "OK");
                        return;
                    }

                    double soma = 0;
                    double num = 0;
                    double media = 0;

                    
                    for (int i = 0; i < qtdAlunos; i++)
                    {
                        if (double.TryParse(notasTexto[i].Trim(), out num))
                        {
                            soma += num;
                        }
                        else
                        {
                            DisplayAlertAsync("Erro", $"Valor inválido na nota {i + 1}: {notasTexto[i]}", "OK");
                            return;
                        }
                    }

                    media = soma / qtdAlunos;

                    lblResultado.Text = $"A média da turma é: {media:F2}";
                    lblResultado.IsVisible = true;
                }
                catch (Exception ex)
                {
                    DisplayAlertAsync("Erro", ex.Message, "Fechar");
                }
            }
        }
    }
