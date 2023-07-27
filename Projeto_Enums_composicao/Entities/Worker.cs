using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Enums_composicao.Entities.Enums;

namespace Projeto_Enums_composicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }// Nome do funcionario
        public WorkerLevel Level { get; set; }// Nivel do trabalhador (junior,pleno ou senior)
        public double BaseSalary { get; set; } // salario base

        public Department Department { get; set; }//departamentos da empresa

        public List<HourContract> ListContracts { get; set; } = new List<HourContract>();//Lista de contratos

        //CRIANDO CONSTRUTORES 
        public Worker()
        {

        }
        //criando construtor com argumentos

        public Worker(string name, WorkerLevel level, double salarioBase, Department departamento)
        {
            Name = name;
            Level = level;
            BaseSalary = salarioBase;
            Department = departamento;
        }
        //CRIANDO METODOS DA CLASS
        //1º metodo adicionar contrato 
        public void AddContract (HourContract listcontract)
        {
            ListContracts.Add(listcontract);
        }
        //2º metodo RemoverContrato
        public void RemoveContract (HourContract listcontract)
        {
            ListContracts.Remove(listcontract);
        }
        //3º metodo 
        public double Incame(int year,int month) 
        {
            double sum = BaseSalary;//salario pré fixado.
            foreach(HourContract listcontract in ListContracts)//vamos percorrer todos contratos
            {
                if (listcontract.Date.Year == year && listcontract.Date.Month == month)//Ano e Mes
                {
                    sum += listcontract.TotalValue();//operação do valor do contrato
                }
            }
            return sum;
        }
    }
}
