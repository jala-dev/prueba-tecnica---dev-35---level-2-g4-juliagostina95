using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class UserReceivableView
    {
        public InputData RequestData()
        {
            return this.GetData();
        }

        private InputData GetData()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el codigo del socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
            return input;
        }

        public void ShowResult(double total)
        {
            Member entity = new Member();
            Consumption entity2 = new Consumption();
            if (entity.ID == null)
            {
                Console.WriteLine("el codigo ingresado no existe en el sistema");
            }
            Console.WriteLine("R. El consumo del socio {entity.ID} es de {entity2.Value} cubos. La deuda actual es de {2} Bs.");
            Console.WriteLine("======================================");
        }
    }
}
