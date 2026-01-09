
🎓 MauiAppProjeto — Cálculo da Média da Turma

Aplicativo desenvolvido com .NET MAUI, que permite calcular a média aritmética das notas de uma turma de forma simples e interativa.
O usuário informa a quantidade de alunos e as notas separadas por vírgulas, e o sistema realiza o cálculo automaticamente, exibindo o resultado na tela.

📘 Classe MainPage

A classe MainPage representa a tela principal do aplicativo MauiAppProjeto.
Ela é responsável por processar os dados inseridos pelo usuário e calcular a média das notas informadas.

O usuário deve informar:

A quantidade de alunos;

As notas separadas por vírgulas (exemplo: 7.5,8.0,6.5).

O sistema valida os dados e, se estiverem corretos, calcula e exibe a média aritmética das notas.

⚙️ Funcionalidades Principais

✅ Validação de entrada:
Verifica se todos os campos foram preenchidos e se o número de notas corresponde à quantidade de alunos.

⚠️ Tratamento de erros:
Exibe mensagens informativas caso sejam inseridos valores inválidos ou ocorram exceções.

➗ Cálculo automático da média:
Soma todas as notas válidas e divide pelo número de alunos.

📊 Exibição do resultado:
Mostra a média formatada com duas casas decimais na interface.

🖼️ Interface (MainPage.xaml)

O arquivo MainPage.xaml define a interface gráfica do aplicativo, estruturada com VerticalStackLayout dentro de um ScrollView, garantindo boa adaptação a diferentes tamanhos de tela.

Componentes da Interface

Título:
Label centralizado com o texto “Cálculo da Média da Turma 🎓” em cor azul.

Campo de Quantidade de Alunos:
Entry com teclado numérico para inserir o número de alunos.

Campo de Notas:
Entry para digitar as notas separadas por vírgulas (ex: 7.5,8.0,9.0).

Botão de Cálculo:
Button estilizado em azul, que chama o método CalcularMedia_Clicked ao ser pressionado.

Resultado:
Label invisível inicialmente, exibido após o cálculo com o texto da média final.

🎨 Características do Layout

Interface limpa e intuitiva.

Layout vertical e responsivo.

Cores e fontes escolhidas para boa legibilidade em dispositivos móveis.

🧠 Resumo do Funcionamento

O usuário informa a quantidade de alunos e as notas.

O app valida se a quantidade de notas corresponde ao número de alunos.

As notas são convertidas para números e somadas.

A média é calculada e exibida formatada com duas casas decimais.

Em caso de erro, o aplicativo mostra uma mensagem explicativa.
