using System;

namespace TSModel.Dominio.Consejeria
{
    public class Consejeria
    {
        public int Numero { get; set; }
        public int PacienteId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Residente1Id { get; set; }
        public int Residente2Id { get; set; }
        public string Observacion { get; set; }
    }
}
