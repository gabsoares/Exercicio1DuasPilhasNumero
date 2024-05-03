using Exercicio1DuasPilhasNumero;

PilhaNumero p1 = new();
PilhaNumero p2 = new();
PilhaNumero pAux = new();

p1.Push(new(503));
p1.Push(new(801));
p1.Push(new(200));
p1.Push(new(12));
p1.Push(new(901));

p2.Push(new(155));
p2.Push(new(156));
p2.Push(new(157));

p1.GetPares();
//int opc = 0, quantidadeLivros = 0, opcTransferir;
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
//          Console.WriteLine($"Maior valor: {p1.VerificarMaiorElementoPilha}()");
//          Console.WriteLine($"Menor valor: {p1.VerificarMaiorElementoPilha()}");
//          Console.WriteLine($"Média: {(p1.VerificarMaiorElementoPilha() + p1.VerificarMenorElementoPilha()) / 2}");
//            break;
//        case 3:
//          Console.WriteLine(Qual pilha deseja transferir para auxiliar? Opção 1 - para (p1 - pAux) | Opção 2 - para (p2 - pAux))
//          opcTransferir = int.Parse(Console.ReadLine())
//          TransferirPilha(opcTransferir)
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
    if (p1.VerificarTamanho() == p2.VerificarTamanho())
    {
        return "O tamanho das pilhas são iguais.";
    }
    else if (p1.VerificarTamanho() > p2.VerificarTamanho())
    {
        return "A pilha 1 é maior";
    }
    else
    {
        return "A pilha 2 é maior";
    }
}

void TransferirPilha(int opc)
{
    Numero aux = new(0);
    Numero aux2 = new(0);
    PilhaNumero p_temp = new();
    switch (opc)
    {
        case 1:
            aux = p1.Pop();
            p_temp.Push(aux);

            aux2 = p_temp.Pop();
            pAux.Push(aux);

            pAux.RunOver();
            break;
        case 2:
            aux = p2.Pop();
            p_temp.Push(aux);

            aux2 = p_temp.Pop();
            pAux.Push(aux);

            pAux.RunOver();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}