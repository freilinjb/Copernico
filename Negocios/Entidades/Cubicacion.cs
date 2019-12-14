using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Cubicacion
    {
        public int IdMaquinaria;
        public float CajonLargo;
        public float CajonAncho;
        public float CajonAlto;
        public float TablonLargo;
        public float TablonAncho;
        public float TablonAlto;
        public float BotellaLargo;
        public float BotellaAncho;
        public float BotellaAlto;
        public float CapacidadFacturar;

        public Cubicacion(int idMaquinaria, float cajonLargo, float cajonAncho, float cajonAlto, float tablonLargo, float tablonAncho, float tablonAlto, float botellaLargo, float botellaAncho, float botellaAlto, float capacidadFacturar)
        {
            IdMaquinaria = idMaquinaria;
            CajonLargo = cajonLargo;
            CajonAncho = cajonAncho;
            CajonAlto = cajonAlto;
            TablonLargo = tablonLargo;
            TablonAncho = tablonAncho;
            TablonAlto = tablonAlto;
            BotellaLargo = botellaLargo;
            BotellaAncho = botellaAncho;
            BotellaAlto = botellaAlto;
            CapacidadFacturar = capacidadFacturar;
        }

        public string getGuardar()
        {
            return $"EXEC RegistrarCubicacion {IdMaquinaria},{CajonLargo},{CajonAncho},{CajonAlto},{TablonLargo},{TablonAncho},{TablonAlto},{BotellaLargo},{BotellaAncho},{BotellaAlto},{CapacidadFacturar}";
        }
    }
}
