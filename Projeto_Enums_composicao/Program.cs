using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Enums_composicao.Entities;
using Projeto_Enums_composicao.Entities.Enums;


namespace Projeto_Enums_composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento : ");
            string NomeDerp = Console.ReadLine();
            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nivel do funcionario: Junior - Pleno - Senior :");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Digite salario base :");
            double salarioBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //instanciar objetos departamento e trabalhador
            Department dept = new Department(NomeDerp);//departamento
            Worker worker = new Worker(name,level,salarioBase,dept);

            //perguntas
            Console.Write("Quantos contratatos ficaram com Trabalhador: ");
            int N = int.Parse(Console.ReadLine());

            for (int i= 1; i <= N; i++)
            {
                Console.Write($"Entre #{i} contrato: ");
                Console.Write("Data (DD/MM/YYYY) : ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double ValorPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Digite quantidade de Horas: ");
                int hours = int.Parse(Console.ReadLine());

                //instanciando contrato
                HourContract contract = new HourContract (data,ValorPorHora,hours);

                //adicionar contrato ao trabalhador ( iremos usar os metodos criados de adicionar)
                
                worker.AddContract(contract);



            }
            Console.WriteLine();
            Console.Write("Entre com o mês & ano no formato: (MM/YYYY) : ");
            string MesAno = Console.ReadLine();

            //utilizando substring
            int mes = int.Parse(MesAno.Substring(0, 2));
            int Ano = int.Parse(MesAno.Substring(3));

            Console.WriteLine("Nome: " + name);
            Console.WriteLine("Departamento : " + worker.Department.Name);
            Console.WriteLine("Mes e ano : " + MesAno + ": " + worker.Incame(Ano,mes).ToString("F2",CultureInfo.InvariantCulture));





        }
    }
}
