using System;

namespace TipoParcial2
{
    public class CEjecutora
    {
        private static float impuesto;
        public static float Impuesto
        {
            get => impuesto;
            set=> impuesto = value;
        }
        public static void SetImpuesto(float valor)
        {
            impuesto = valor;
        }
        public static float GetImpuesto()
        {
            return impuesto;
        }
        public CEjecutora()
        {
            
        }
    }
}
