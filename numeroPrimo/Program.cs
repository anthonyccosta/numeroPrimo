using System;
        double numero;
        int contador = 0; // contador para diferentes de 1 e o próprio número


        Console.WriteLine("Digite um número inteiro: ");
        numero = Double.Parse(Console.ReadLine());

        // verificação inicial (menor ou igual a 1)
        if (numero <= 1)
        {
            contador = 2; // Não primo (conta 1 e o próprio número)
        }
        else
        {
            // loop para verificar divisores (de 2 até a raiz quadrada do número)
            int divisor = 2;
            while (divisor * divisor <= numero)
            {
                // verificar se o número é divisível pelo divisor atual
                if (numero % divisor == 0)
                {
                    contador++; // Encontrou um divisor (além de 1 e o próprio número)
                    if (contador > 1)
                    {
                        break; // Sai do loop se encontrou mais de 1 divisor (não primo)
                    }
                }
                divisor++;
            }
        }
        // exibir o resultado (primo ou não primo)
        if (contador <= 1)
        {
            Console.WriteLine("{0} é um número primo!", numero);
        }
        else
        {
            Console.WriteLine("{0} não é um número primo.", numero);
        }