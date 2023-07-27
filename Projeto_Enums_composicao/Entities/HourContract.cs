using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Enums_composicao.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; } //data trabalhada
        public double ValuePerHour { get; set;} //Valor ganho por hora
        public int Hours { get; set;} // Horas trabalhadas

        //contrutores da class Horas DO CONTRATO
        public HourContract()
        {

        }

        public HourContract(DateTime data, double valordahora, int horas)
        {
            Date = data;
            ValuePerHour = valordahora;
            Hours = horas;
        }
        //Criação de Metodos da class
        public double TotalValue() { return Hours * ValuePerHour; }
    }

}
