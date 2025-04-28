using System;
using System.Data;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Desafio
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Digite o salário Anual: ");
            double salarioAnual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite os valores de renda de prestações de serviço: ");
            double prestServico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite os valores de ganhos de capital: ");
            double ganhoCapital = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite os valores de gastos médicos: ");
            double gastosMedicos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite os valores de gastos educacionais: ");
            double gastosEducacionais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double rendaMensal = salarioAnual / 12;
            double impostoSalario = 0;
            double impostoServicos = 0;
            double impostoCapital = 0;
      
            //IMPOSTO SOBRE SALÁRIO
            if (rendaMensal <= 3000.0)
            {
                impostoSalario = 0.0;
            }
            else if (rendaMensal <= 5000.00)
            {
                impostoSalario = rendaMensal * 0.10 * 12;

            }
            else if (rendaMensal > 5000)
                impostoSalario = rendaMensal * 0.20 * 12;

            //IMPOSTO SOBRE SERVIÇOS
            if (prestServico >0)
            {
                impostoServicos = prestServico * 0.15;

            }
            //IMPOSTO SOBRE GANHO CAPITAL
            if (ganhoCapital >0)
            {
                impostoCapital = ganhoCapital * 0.20;

            }

            //DEDUÇÕES
            double maximodedutivel = (impostoSalario + impostoServicos + impostoCapital) * 0.30;
            double gastosdedutiveis = gastosMedicos + gastosEducacionais;

            //RESUMO
            double impostoTotal = impostoSalario + impostoServicos + impostoCapital;
            double abatimento;

            if (gastosdedutiveis < maximodedutivel)
            {
                abatimento = gastosdedutiveis;
            }
            else
            {
                abatimento = maximodedutivel;

            }

            double impostoDevido = impostoTotal - abatimento;





            Console.WriteLine("Renda anual com salário: " + salarioAnual.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Renda anual com prestação de serviços: " + prestServico.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Renda anual com ganho capital: " + ganhoCapital.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Gastos médicos: " + gastosMedicos.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Gastos educacionais: " + gastosEducacionais.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("RELATÓRIO DE IMPOSRTO DE RENDA");

            Console.WriteLine();

            Console.WriteLine("CONSOLIDADO DE RENDA");
            Console.WriteLine("Imposto sobre o salário: " + impostoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Imposto sobre o serviços: " + impostoServicos.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Imposto sobre o ganho capital: " + impostoCapital.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("DECUÇÕES");
            Console.WriteLine("Máximo dedutíveis: " + maximodedutivel.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Gastos dedutíveis: " + gastosdedutiveis.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("RESUMO"); 
            Console.WriteLine("Imposto bruto tatal: " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("abatimento: " + abatimento.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Imposto devido: " + impostoDevido.ToString("F2", CultureInfo.InvariantCulture));













        }
    }
}