using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Enums_composicao.Entities
{
    internal class Department
    {//criando class departamento
        public string Name { get; set; }
        //construtores da class
        public Department()
        {

        }
        public Department(string nome)
        {
            Name = nome;
        }
    }
}
