using classes.models;
bool controleWhile = true;
  Estacionamento estacionamento = new Estacionamento(); // instância
string[] arg  = ["Cadastrar veiculo", "remover veiculo","listar veiculos", "encerrar"];
Console.WriteLine("digite a quantidade incial: ");
estacionamento.InitialValue = double.Parse(Console.ReadLine()!);
Console.WriteLine("digite a quantidade por hora: ");
estacionamento.ValueHour =double.Parse(Console.ReadLine()!);
while(controleWhile){
Console.Clear();
for (int controle = 0; controle < 4; controle++){
  Console.WriteLine($"{controle + 1} - {arg[controle]}");
}
switch(Console.ReadLine()){
  case "1":

  estacionamento.CadastroV();
     //classes referentes , adicionar , remover etc.....

    break;
  case "2":
  estacionamento.RemoverV();
     //classes referentes , adicionar , remover etc.....
    break;
     case "3":
    estacionamento.ListarV();
    //classes referentes , adicionar , remover etc.....
    break;
     case "4":
    Console.WriteLine("digite uma tecla para continuar");
    Console.ReadLine();
    Console.WriteLine("programa encerrado");
   
    controleWhile = false;  //classes referentes , adicionar , remover etc.....
    break;
    default: Console.WriteLine("digite um número válido, entre 1 a 4");
      
    break;
  
}

}
