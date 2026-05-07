using System;
using System.Globalization;

namespace hyannebeta3
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - imposto;
        }
        public void AumentoSalario(double porcentagem )
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }
        public override string ToString()
        {
            return Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
