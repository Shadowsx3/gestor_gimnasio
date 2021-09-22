using System;

namespace gestor_gimnasio
{
    public class Cuota
    {
        private uint _monto;
        private DateTime _fecha;
        private bool _pendiente;

        public uint Monto
        {
            get => _monto;
            set => _monto = value;
        }

        public DateTime Fecha
        {
            get => _fecha;
            set => _fecha = value;
        }

        public bool Pendiente
        {
            get => _pendiente;
            set => _pendiente = value;
        }
    }
}