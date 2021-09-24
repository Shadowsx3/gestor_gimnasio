using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_gimnasio.clase
{
    class Gimnasio
    {
        private List<Cliente> Socios = new List<Cliente>();
        public string IngresarSocio(string Numero, string Nombre, string Apellido, string Peso, string Altura)
        {
            uint xNumero = (uint)Int32.Parse(Numero);
            float xPeso = float.Parse(Peso);
            float xAltura = float.Parse(Altura);
            Cliente nuevocliente = new Cliente(xNumero, Nombre, Apellido, xPeso, xAltura);
            foreach (Cliente c in Socios)
            {
                if (c.IdSocio == xNumero)
                {
                    return "Ya existe el id";
                }
            }
            Socios.Add(nuevocliente);
            return "Agregado correctamente";
        }
        public float CalcularImc(uint Id)
        {
            foreach (Cliente c in Socios)
            {
                if (c.IdSocio == Id)
                {
                    return c.Imc();
                }
            }
            return 0;
        }
        public void PagarCuota(uint Id, string fecha)
        {
            foreach (Cliente c in Socios)
            {
                if (c.IdSocio == Id)
                {
                    c.PagarCuota(DateTime.Parse(fecha));
                }
            }
        }
        public void Ejercitarse(uint Id, string ejercicio)
        {
            foreach (Cliente c in Socios)
            {
                if (c.IdSocio == Id)
                {
                    c.Ejercitarse(ejercicio);
                }
            }
        }
        public void ActualizarPeso(uint Id, string nuevopeso)
        {
            foreach (Cliente c in Socios)
            {
                if (c.IdSocio == Id)
                {
                    c.CambiarPeso(float.Parse(nuevopeso));
                }
            }
        }
        public void Eliminar(uint Id)
        {
            foreach (Cliente c in Socios)
            {
                if (c.IdSocio == Id)
                {
                    Socios.Remove(c);
                    break;
                }
            }
        }
        public List<Cliente> Listado()
        {
            return Socios;
        }


    }
}
