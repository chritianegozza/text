using System;
using Colecoes.Helper;
using System.Collections.Generic;


namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
          
          //Dicionário

          Dictionary<string, string> estados = new Dictionary<string, string>();

          estados.Add("SP", "São Paulo");
          estados.Add("MG", "Minas Gerais");
           estados.Add("AM", "Amazonas");
            estados.Add("CE", "Ceará");
            estados.Add("Ba", "Bahia");
            estados.Add("RJ", "Rio de Janeiro");
            estados.Add("AP", "Amapá");
            estados.Add("DF", "Distrito Federal");

            foreach (KeyValuePair<string, string> item in estados)
            {
                System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }


            //Acessando um valor
            string valorProcurado = "BA";
      
            //var teste = estados["SC"];

            // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            //{
           //     System.Console.WriteLine(estadoEncontrado);
           // }
           // else
           // {
           //   System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário ");
           // }


             
            System.Console.WriteLine($"Removendo o valor: {valorProcurado}");
            
            estados.Remove(valorProcurado);

           foreach (KeyValuePair<string, string> item in estados)
            {
                System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
           }

   


            // System.Console.WriteLine("Valor original:");
            //System.Console.WriteLine(estados[valorProcurado]);
        
            //estados[valorProcurado] = "BA - teste atualização";   
            //System.Console.WriteLine("Valor atualizado:");
            //System.Console.WriteLine(estados[valorProcurado]);





          //Pilha
          //Stack<string> pilhaLivros = new Stack<string>();

          //pilhaLivros.Push(".NET");
          //pilhaLivros.Push("");
          //pilhaLivros.Push("POO");
          //pilhaLivros.Push("Código limpo");
          //pilhaLivros.Push("Programadora top");
          //pilhaLivros.Push("Me contrata, estágiaria");

          //  System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
          // while (pilhaLivros.Count > 0)
          //  {
          //       System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
          //       System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
          //  }
             
          //  System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}"); 


          //Filas na prática
          //Queue<string> fila = new Queue<string>();

         // fila.Enqueue("Christiane");
         // fila.Enqueue("Arthur");
         // fila.Enqueue("Caio");
         // fila.Enqueue("Pedro");
         // fila.Enqueue("Alex");
         // fila.Enqueue("Bela");
          
         // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

        //  while (fila.Count > 0)
         // {
          //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
          //     System.Console.WriteLine($"{fila.Dequeue()}");
         // }
          
        //  System.Console.WriteLine($"Pessoas na fila: {fila.Count}");


          //Listas 
          //OperacoesLista opLista = new OperacoesLista();
         // List<string> estados = new List<string> {"SP", "MG", "BA", "MS"};
          //string[] estadosArray = new string[2] { "SC", "AM"};



          //estados.Add("SP");
          //estados.Add("MG");
          //estados.Add("MS");
         // estados.Add("BA");

          //System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

         //opLista.ImprimirListaString(estados);

          //System.Console.WriteLine("Removendo o elemento");
          
         // estados.Remove("MG");

    
          //estados.AddRange(estadosArray);
          
          //estados.Insert(1, "RJ");

          //opLista.ImprimirListaString(estados);

         
           //Ordenando via bubble sort
           //OperacoesArray op = new OperacoesArray();

           //int[] array = new int[5] { 6, 3, 8, 1, 9 };
           //int[] arrayCopia = new int[10];

           //int valorProcurado = 5;
           
           //bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

           //if (todosMaiorQue)
          // {
            //   System.Console.WriteLine("Todos os valores são maior que  (0)", valorProcurado);
           //}
          // else
          //{
           //    System.Console.WriteLine("Existe valores que não são maiores do que (0)", valorProcurado);
          // }
           
           //bool existe = op.Existe(array, valorProcurado);

           //if (existe)
          // {
           //   System.Console.WriteLine("Encontrei o valor (0)", valorProcurado); 
          // }
          // else
          // {
          //     System.Console.WriteLine("Não encontrei o valor: (0)", valorProcurado);
           //}

           //System.Console.WriteLine("Array original:");
           //op.ImprimirArray(array);

           //op.OrdenarBubbleSort(ref array);
          // op.Ordenar(ref array);

          // System.Console.WriteLine("Array ordenado:");
           //op.ImprimirArray(array);

           //System.Console.WriteLine("Array antes da cópia:");
           //op.ImprimirArray(arrayCopia);

           //op.Copiar(ref array, ref arrayCopia);
           //System.Console.WriteLine("Array após a cópia:");
           //op.ImprimirArray(arrayCopia);
         


           //Array multidimensional = matriz
           //int[,] matriz = new int[4, 2]
           //{
           //    { 8, 8 },
           //    { 10, 20 },
           //    { 50, 100 },
           //    { 90, 200 }
               
         //   };

           // for (int i = 0; i < matriz.GetLength(0); i++)
           // {
           //     for (int j = 0; j < matriz.GetLength(1); j++)
           //     {
            //        System.Console.WriteLine(matriz[i, j]);
            //    }
           // }


           



            //arrays 
              //int[] arrayInteiros = new int[3];

              //arrayInteiros[0] = 10;
              //arrayInteiros[1] = 20;
              //arrayInteiros[2] = 30;

              // System.Console.WriteLine("Percorrendo o array pelo for");
              // for (int i = 0; i < arrayInteiros.Length; i++)
               
             // {     System.Console.WriteLine(arrayInteiros[i]);
             //  }

               //System.Console.WriteLine("Percorrendo o array pelo forEach");
               //foreach (int item in arrayInteiros)
               //{
               //    System.Console.WriteLine(item); 
              // }
        }
    }
}    






