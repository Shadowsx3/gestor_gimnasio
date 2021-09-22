using System;
using System.Collections.Generic;

namespace gestor_gimnasio
{
    public class Cliente
    {
        #region "Clase"
        private uint _idSocio;
        private string _nombre;
        private string _apellido;
        private float _peso;
        private float _altura;
        private bool _deuda;
        private string _ultimoEjercicio;

        public string UltimoEjercicio
        {
            get => _ultimoEjercicio;
            set => _ultimoEjercicio = value;
        }
        private List<Cuota> _cuotas;

        public List<Cuota> Cuotas
        {
            get => _cuotas;
            set => _cuotas = value;
        }

        public uint IdSocio
        {
            get => _idSocio;
            set => _idSocio = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public float Peso
        {
            get => _peso;
            set => _peso = value;
        }

        public float Altura
        {
            get => _altura;
            set => _altura = value;
        }

        public bool Deuda
        {
            get => _deuda;
            set => _deuda = value;
        }

        public Cliente(uint xidSocio, string xnombre, string xapellido, ushort xpeso, float xaltura)
        {
            IdSocio = xidSocio;
            Nombre = xnombre;
            Apellido = xapellido;
            Peso = xpeso;
            Altura = xaltura;
            Deuda = false;
        }
        #endregion
        #region "Funciones"

        public void PagarCuota(ushort mes)
        {
            if (1 > mes || mes > 12)
            {
                return;
            }
            foreach(Cuota c in Cuotas)
            {
                if (c.Fecha.Month == mes && c.Fecha.Year == DateTime.Now.Year)
                {
                    c.Pendiente = false;
                }
            }
        }
        public void PagarCuota(DateTime fecha)
        {
            foreach(Cuota c in Cuotas)
            {
                if (c.Fecha == fecha)
                {
                    c.Pendiente = false;
                }
            }
        }
        
        public float Imc()
        {
            return Peso * (Altura * Altura);
        }

        public void CambiarPeso(float nuevoPeso)
        {
            Peso = nuevoPeso;
        }

        public void Ejercitarse(string nombreEjercicio)
        {
            UltimoEjercicio = nombreEjercicio;
        }
        #endregion
    }
}