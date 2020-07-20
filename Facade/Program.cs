using System;
using Subsistema;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamo al objeto fachada que internamente tiene privado las otras clases
            Fachada obj = new Fachada();

            //Solo veo la acción principal. Las subacciones las lleva a cabo internamente
            obj.Hacer();
        }
    }
}
