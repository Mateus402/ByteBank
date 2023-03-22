using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario();
//pedro.Nome = "Pedro malazartes";
//pedro.Cpf = "123456789";
//pedro.Salario = 2000;

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor();
//roberta.Nome = "Roberta Silva";
//roberta.Cpf = "987654321";
//roberta.Salario = 5000;

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);
//Console.WriteLine(Funcionario.TotalDeFuncionarios);
#endregion

UsarSistema();

void UsarSistema()
{
  SistemaInterno sistema = new SistemaInterno();

  Diretor ingrid = new Diretor();
  ingrid.Nome = "Ingrid";
  ingrid.Senha = "123";


  sistema.Logar(ingrid, "222");
}




