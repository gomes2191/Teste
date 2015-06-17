
using System;

class TesteBasis 
{

    static void Main() 
    {

        //Variavel que recebe o valor para o teste
        String texto = "((1+1)*2) + (10+2) + (((2-1)-1)*1)";

        int parenteses = 0;
        foreach (char c in texto)
        {
            if (c.Equals('('))
            {
                parenteses++;
            }
            else if (c.Equals(')'))
            {
                parenteses--;
            }

            if (parenteses < 0)
            {
                break;
            }
        }

       
        //Imprime resultado
        Console.WriteLine(parenteses == 0);

        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadKey();
    
    }


}