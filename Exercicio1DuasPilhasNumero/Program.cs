using Exercicio1DuasPilhasNumero;

PilhaNumero p1 = new();
PilhaNumero p2 = new();
PilhaNumero pAux = new();

p1.Push(new(1));
p1.Push(new(3));

p2.Push(new(155));
p2.Push(new(155));
p2.Push(new(155));


p1.VerificarTamanho();
Console.WriteLine();
p2.VerificarTamanho();

Console.WriteLine(MaiorPilha());

//int opc = 0, quantidadeLivros = 0;
//do
//{
//    Console.Clear();

//    Console.WriteLine("****MENU PRINCIPAL****");
//    Console.WriteLine("Digite 1 para ver se as pilhas são do mesmo tamanho, caso não mostrará a maior.");
//    Console.WriteLine("Digite 2 para ver o maior e o menor valor e a média entre eles");
//    Console.WriteLine("Digite 3 para escolher p1 ou p2 para transferir para pAux");
//    Console.WriteLine("Digite 4 para ver o total de números impares");
//    Console.WriteLine("Digite 5 para ver o total de números pares");
//    Console.WriteLine("Digite 0 para sair");
//    Console.Write("Opção desejada:< > \b\b\b");
//    opc = int.Parse(Console.ReadLine());
//    Console.WriteLine();
//    switch (opc)
//    {
//        case 1:
//          Console.WriteLine(MaiorPilha());
//            break;
//        case 2:
//            break;
//        case 3:
//            break;
//        case 4:
//            break;
//        case 5:
//            break;
//        default:
//            break;
//    }
//} while (opc != 0);

string MaiorPilha()
{
    if(p1.VerificarTamanho() == p2.VerificarTamanho())
    {
        return "O tamanho das pilhas são iguais.";
    }
    else if(p1.VerificarTamanho() > p2.VerificarTamanho())
    {
        return "A pilha 1 é maior";
    }
    else
    {
        return "A pilha 2 é maior";
    }
}
