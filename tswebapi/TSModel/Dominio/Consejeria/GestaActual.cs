﻿using System;

namespace TSModel.Dominio.Consejeria
{
    public class GestaActual
    {
        public int ConsejeriaId { get; set; }
        public Consejeria Consejeria { get; set; }

        public bool EnteroPorTestOrina { get; set; }
        public bool EnteroPorTestSangre { get; set; }
        public bool EnteroPorEcografia{ get; set; }
        public DateTime EnteroFecha { get; set; }
        public string FUM { get; set; }
        public string EGFUM { get; set; }
        public bool IntentoSuprimir { get; set; }
        public string IntentoSuprimirObservaciones { get; set; }
        public bool Lactancia { get; set; }
        public bool LoComento { get; set; }
        public string LoComentoAQuien { get; set; }
        public bool ILE { get; set; }
        public bool CausaViolacion { get; set; }
        public bool CausaSaludFisica{ get; set; }
        public bool CausaSaludPSI { get; set; }
        public bool CausaSaludSocial { get; set; }
        public bool CausaSinVE { get; set; }

        public bool CUMSPACO { get; set; }
        public bool CUMSPDisfuncionHepaticaSevera { get; set; }
        public bool CUMSPEmbarazoEctopico { get; set; }
        public bool CUMSPAlergiaMisoDiclo { get; set; }

        public bool FactorRiesgoHb7 { get; set; }
        public bool FactorRiesgoCardiopatia { get; set; }
        public bool FactorRiesgoDIU { get; set; }
        public bool FactorRiesgoCardiovascular { get; set; }
        public bool FactorRiesgoCorticoterapia { get; set; }
    }
}
