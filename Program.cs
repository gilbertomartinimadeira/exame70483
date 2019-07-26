using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace GERAIS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo 1-1  Usando o Parallel.Invoke ( vários métodos numa chamada só )

            //Parallel.Invoke(Task1, Task2);        


            #endregion

            #region Exemplo 1-2 Usando o Parallel.ForEach ( implementação de paralelismo do loop foreach )

            //var items = Enumerable.Range(0, 50);


            //Parallel.ForEach(items, item => {
            //    WorkOnItem(item);
            //});


            #endregion

            #region Exemplo 1-3 Usando o Parallel.For ( Implementação de paralelismo no loop for)

            //var items = Enumerable.Range(0, 50).ToArray();

            //Parallel.For(0, items.Length, i => {
            //    WorkOnItem(items[i]);
            //});

            #endregion

            #region Exemplo 1-4 Usando o ParallelLoopState para controlar os loops paralelos e o ParallelLoopResult para mostrar informações sobre o resultado

            //var items = Enumerable.Range(0, 200).ToArray();

            //ParallelLoopResult result = Parallel.For(0, items.Count(), (i, loopState) => {

            //    if(i == 50)
            //    {
            //        loopState.Stop();
            //    }                                   

            //    WorkOnItem(i);

            //});

            //Console.WriteLine($"Completed: {result.IsCompleted}");

            //Console.WriteLine($"LowestBreakIteration: {result.LowestBreakIteration}");

            #endregion

            #region Exemplo 1-5 Usando o AsParallel() em uma coleção de itens

            //var rio = "Rio de Janeiro";
            //var pessoas = new List<Pessoa>()
            //{

            //    new Pessoa() { Nome = "Ezequiel", Cidade = "Belford Roxo"},
            //    new Pessoa() { Nome = "Kelly", Cidade = rio},
            //    new Pessoa() { Nome = "Claudio", Cidade = "Berlim"},
            //    new Pessoa() { Nome = "Ricardo", Cidade = rio},
            //    new Pessoa() { Nome = "Evio", Cidade = "Berlim"},
            //    new Pessoa() { Nome = "Felipe", Cidade = rio},               
            //    new Pessoa() { Nome = "Guilherme", Cidade = rio},
            //    new Pessoa() { Nome = "Pedro", Cidade = "Duque de Caxias"},
            //    new Pessoa() { Nome = "Vinicius", Cidade = "Blumenau"},
            //    new Pessoa() { Nome = "Natalia", Cidade = "Blumenau"},
            //    new Pessoa() { Nome = "Liam", Cidade = "Blumenau"},
            //    new Pessoa() { Nome = "Priscila", Cidade = "Duque de Caxias"},               
            //    new Pessoa() { Nome = "Joselia", Cidade = "Duque de Caxias"},
            //    new Pessoa() { Nome = "Vanessa", Cidade = "Denver"},
            //    new Pessoa() { Nome = "Livia", Cidade = "Niteroi"},
            //    new Pessoa() { Nome = "Eduardo", Cidade = rio},
            //    new Pessoa() { Nome = "Gilberto", Cidade = rio},
            //    new Pessoa() { Nome = "Thiago", Cidade = "Niteroi"},
            //    new Pessoa() { Nome = "Cristiane", Cidade = "Duque de Caxias"}
            //};

            //Stopwatch sw = new Stopwatch();

            //sw.Start();

            //var cariocas = from pessoa 
            //                 in pessoas.AsParallel()
            //              where pessoa.Cidade == rio
            //             select pessoa;

            //sw.Stop();


            //Console.WriteLine($"Tempo gasto em ms: {sw.ElapsedMilliseconds}");

            //foreach (var pessoa in cariocas)
            //{
            //    Console.WriteLine(pessoa.Nome);
            //}

            #endregion

            #region Exemplo 1-6 Informando o paralelismo


            //var rio = "Rio de Janeiro";
            //var pessoas = new List<Pessoa>()
            //{

            //    new Pessoa() { Nome = "Ezequiel", Cidade = "Belford Roxo"},
            //    new Pessoa() { Nome = "Kelly", Cidade = rio},
            //    new Pessoa() { Nome = "Claudio", Cidade = "Berlim"},
            //    new Pessoa() { Nome = "Ricardo", Cidade = rio},
            //    new Pessoa() { Nome = "Evio", Cidade = "Berlim"},
            //    new Pessoa() { Nome = "Felipe", Cidade = rio},
            //    new Pessoa() { Nome = "Guilherme", Cidade = rio},
            //    new Pessoa() { Nome = "Pedro", Cidade = "Duque de Caxias"},
            //    new Pessoa() { Nome = "Vinicius", Cidade = "Blumenau"},
            //    new Pessoa() { Nome = "Natalia", Cidade = "Blumenau"},
            //    new Pessoa() { Nome = "Liam", Cidade = "Blumenau"},
            //    new Pessoa() { Nome = "Priscila", Cidade = "Duque de Caxias"},
            //    new Pessoa() { Nome = "Joselia", Cidade = "Duque de Caxias"},
            //    new Pessoa() { Nome = "Vanessa", Cidade = "Denver"},
            //    new Pessoa() { Nome = "Livia", Cidade = "Niteroi"},
            //    new Pessoa() { Nome = "Eduardo", Cidade = rio},
            //    new Pessoa() { Nome = "Gilberto", Cidade = rio},
            //    new Pessoa() { Nome = "Thiago", Cidade = "Niteroi"},
            //    new Pessoa() { Nome = "Cristiane", Cidade = "Duque de Caxias"}
            //};

            //Stopwatch sw = new Stopwatch();

            //sw.Start();

            //var cariocas = from pessoa
            //                 in pessoas.AsParallel().WithDegreeOfParallelism(4).WithExecutionMode( ParallelExecutionMode.ForceParallelism )
            //               where pessoa.Cidade == rio
            //               select pessoa;

            //sw.Stop();


            //Console.WriteLine($"Tempo gasto em ms: {sw.ElapsedMilliseconds}");

            //foreach (var pessoa in cariocas)
            //{
            //    Console.WriteLine(pessoa.Nome);
            //}
            #endregion

            #region  Exemplo 1-7 Usando AsOrdered para preservar a ordem da saída conforme a ordem da entrada de dados

            //var rio = "Rio de Janeiro";
            //var blumenau = "Blumenau";
            //var niteroi = "Niteroi";
            //var teresopolis = "Teresópolis";

            //var pessoas = new List<Pessoa>()
            //{

            //    new Pessoa() { Nome = "Ezequiel", Cidade = rio},
            //    new Pessoa() { Nome = "Kelly", Cidade = rio},               
            //    new Pessoa() { Nome = "Gallas", Cidade = rio},              
            //    new Pessoa() { Nome = "Felipe", Cidade = rio},
            //    new Pessoa() { Nome = "Guilherme", Cidade = rio},
            //    new Pessoa() { Nome = "Pedro", Cidade = teresopolis},
            //    new Pessoa() { Nome = "Vinicius", Cidade = blumenau},
            //    new Pessoa() { Nome = "Natalia", Cidade = blumenau},
            //    new Pessoa() { Nome = "Liam", Cidade = blumenau},
            //    new Pessoa() { Nome = "Priscila", Cidade = teresopolis},
            //    new Pessoa() { Nome = "Joselia", Cidade = teresopolis},               
            //    new Pessoa() { Nome = "Livia", Cidade = niteroi},
            //    new Pessoa() { Nome = "Eduardo", Cidade = rio},
            //    new Pessoa() { Nome = "Gilberto", Cidade = rio},
            //    new Pessoa() { Nome = "Thiago", Cidade = niteroi},
            //    new Pessoa() { Nome = "Cristiane", Cidade = teresopolis}
            //};

            //Stopwatch sw = new Stopwatch();

            //sw.Start();

            //var cariocas = from pessoa
            //                 in pessoas.AsParallel().AsOrdered()
            //               where pessoa.Cidade == rio
            //               select pessoa;

            //sw.Stop();


            //Console.WriteLine($"Tempo gasto em ms: {sw.ElapsedMilliseconds}");

            //foreach (var pessoa in cariocas)
            //{
            //    Console.WriteLine(pessoa.Nome);
            //}
            #endregion

            #region Exemplo 1-8 Identificando elementos de uma query paralela como sequencial

            //var rio = "Rio de Janeiro";
            //var blumenau = "Blumenau";
            //var niteroi = "Niteroi";
            //var teresopolis = "Teresópolis";

            //var pessoas = new List<Pessoa>()
            //{

            //    new Pessoa() { Nome = "Gallas", Cidade = rio},
            //    new Pessoa() { Nome = "Fernanda", Cidade = rio},                       
            //    new Pessoa() { Nome = "Anna", Cidade = rio},
            //    new Pessoa() { Nome = "Pedro", Cidade = teresopolis},
            //    new Pessoa() { Nome = "Vinicius", Cidade = blumenau},
            //    new Pessoa() { Nome = "Jessica", Cidade = teresopolis},
            //    new Pessoa() { Nome = "Ezequiel", Cidade = rio},
            //    new Pessoa() { Nome = "Liam", Cidade = blumenau},
            //    new Pessoa() { Nome = "Eduardo", Cidade = rio},
            //    new Pessoa() { Nome = "Gilberto", Cidade = rio},
            //    new Pessoa() { Nome = "Rita", Cidade = teresopolis},
            //    new Pessoa() { Nome = "Joselia", Cidade = teresopolis},
            //    new Pessoa() { Nome = "Laura", Cidade = niteroi},
            //    new Pessoa() { Nome = "Thiago", Cidade = niteroi},
            //    new Pessoa() { Nome = "Cristiane", Cidade = teresopolis}
            //};

            //Stopwatch sw = new Stopwatch();

            //sw.Start();

            //var cariocas = (from pessoa
            //                 in pessoas.AsParallel()
            //                where pessoa.Cidade == rio
            //                orderby pessoa.Nome
            //                select new { Nome = pessoa.Nome }).AsSequential() // sem isso, a ordem de retirada no take pode ser afetada pelo paralelismo
            //                .Take(5);

            //sw.Stop();


            //Console.WriteLine($"Tempo gasto: {sw.ElapsedMilliseconds} ms");

            //foreach (var pessoa in cariocas)
            //{
            //    Console.WriteLine(pessoa.Nome);
            //}



            #endregion

            #region Exemplo 1-9 Usando o método ForAll

            //var rio = "Rio de Janeiro";
            //var blumenau = "Blumenau";
            //var niteroi = "Niteroi";
            //var teresopolis = "Teresópolis";

            //var pessoas = new List<Pessoa>()
            //{

            //    new Pessoa() { Nome = "Gallas", Cidade = rio},
            //    new Pessoa() { Nome = "Fernanda", Cidade = rio},
            //    new Pessoa() { Nome = "Anna", Cidade = rio},
            //    new Pessoa() { Nome = "Pedro", Cidade = teresopolis },
            //    new Pessoa() { Nome = "Vinicius", Cidade = blumenau },
            //    new Pessoa() { Nome = "Jessica", Cidade = teresopolis },
            //    new Pessoa() { Nome = "Ezequiel", Cidade = rio },
            //    new Pessoa() { Nome = "Liam", Cidade = blumenau },
            //    new Pessoa() { Nome = "Eduardo", Cidade = rio },
            //    new Pessoa() { Nome = "Gilberto", Cidade = rio },
            //    new Pessoa() { Nome = "Rita", Cidade = teresopolis },
            //    new Pessoa() { Nome = "Joselia", Cidade = teresopolis },
            //    new Pessoa() { Nome = "Laura", Cidade = niteroi },
            //    new Pessoa() { Nome = "Thiago", Cidade = niteroi },
            //    new Pessoa() { Nome = "Ines", Cidade = teresopolis }
            //};

            //var result = from pessoa in pessoas.AsParallel() where pessoa.Cidade == rio select pessoa;

            //result.ForAll(p => Console.WriteLine(p.Nome));



            #endregion

            #region Exemplo 1-10 Exceptions no PLINQ

            //var rio = "Rio de Janeiro";
            //var blumenau = "Blumenau";
            //var niteroi = "Niteroi";
            //var teresopolis = " ";

            //var pessoas = new List<Pessoa>()
            //{

            //    new Pessoa() { Nome = "Gallas", Cidade = rio},
            //    new Pessoa() { Nome = "Fernanda", Cidade = rio},
            //    new Pessoa() { Nome = "Anna", Cidade = rio},
            //    new Pessoa() { Nome = "Pedro", Cidade = teresopolis },
            //    new Pessoa() { Nome = "Vinicius", Cidade = blumenau },
            //    new Pessoa() { Nome = "Jessica", Cidade = teresopolis },
            //    new Pessoa() { Nome = "Ezequiel", Cidade = rio },
            //    new Pessoa() { Nome = "Liam", Cidade = blumenau },
            //    new Pessoa() { Nome = "Eduardo", Cidade = rio },
            //    new Pessoa() { Nome = "Gilberto", Cidade = rio },
            //    new Pessoa() { Nome = "Rita", Cidade = teresopolis },
            //    new Pessoa() { Nome = "Joselia", Cidade = teresopolis },
            //    new Pessoa() { Nome = "Laura", Cidade = niteroi },
            //    new Pessoa() { Nome = "Thiago", Cidade = niteroi },
            //    new Pessoa() { Nome = "Ines", Cidade = teresopolis }
            //};

            //var result = from pessoa in pessoas.AsParallel() where VerificaCidade(pessoa.Cidade) select pessoa;


            //try
            //{
            //    result.ForAll(p => Console.WriteLine(p.Nome));
            //}
            //catch(AggregateException agex) when (agex.InnerExceptions.Count > 1)
            //{
            //    Console.WriteLine($"Quantidade de Exceptions geradas internamente: {agex.InnerExceptions.Count}");
            //    agex.InnerExceptions.AsParallel().ForAll(e => Console.WriteLine(e.Message));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}

                         #endregion



            Console.WriteLine("All Tasks are complete, press any key to end");
            Console.ReadLine();
        }
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Working on item " + item);
        }

        public static bool VerificaCidade(string nomeCidade)
        {
            if (nomeCidade == " ") throw new ArgumentException("Nome inválido");

            return nomeCidade == "Rio de Janeiro";
        }

        






        #region Exemplo de Parallel.Invoke
        static void Task1() {
            Console.WriteLine("Starting task 1");

            Thread.Sleep(4000);
            Console.WriteLine("Finishing task 1");
        }
        static void Task2() {
            Console.WriteLine("Starting task 2");
            Thread.Sleep(2000);
            Console.WriteLine("Finishing task 2");
        }

        #endregion






    }

    
}

