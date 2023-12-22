using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Update_2023
{
    public class Interfaces
    {
        public interface IBebidaAlcoholica
        {
            public int Alcohol { get; set; }
            public void MaxRecomendado();
        }
    }
}
