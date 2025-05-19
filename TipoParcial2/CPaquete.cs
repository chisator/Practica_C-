using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoParcial2
{
    internal class CPaquete
    {
<<<<<<< HEAD
        private static float impuesto;
        public static float Impuesto
        {
            get => impuesto;
            set { 
                if(value < 0)
                    throw new ArgumentException("EL IMPUESTO NO PUEDE SER NEGATIVO");
                impuesto = value;
            } 
        }
        private ushort num_Paquete;
        public ushort Num_Paquete
        {
            get => num_Paquete;
            set => num_Paquete = value;
        }
        private string? detalle;
        public string? Detalle
        {
            get => detalle;
            set
            {
                    if (value == null|| value=="")
                        throw new ArgumentException("EL DETALLE NO PUEDE SER VACIO");
                    detalle = value;
            }
        }
        private float costo;
        public float Costo
        {
            get => costo;
            set => costo = value;
        }
        public static void SetImpuesto(float valor)
        {
            impuesto = valor;
        }
        public static float GetImpuesto()
        {
            return impuesto;
        }
        public void SetCosto(float valor)
        {
            costo = valor;
        }
        public float GetCosto()
        {
            return costo;
        }
        public float DarPrecio()
        {
            return Costo + (Costo * Impuesto / 100);
        }
        public float DarPrecio(sbyte cuotas)
        {
            float recargo = (cuotas - 1) * 0.10f;
            return DarPrecio() * (1 + recargo);
        }
        public string DarDatos()
        {
            return $"NUMERO DE PAQUETE {num_Paquete} " +
                $"DESCRIPCION {detalle} " +
                $"COSTO {costo} " +
                $"IMPUESTO {impuesto} " +
                $"VALOR FINAL {DarPrecio()}";
        } 
        public bool EsMásBaratoQue(CPaquete otroPaquete)
        {
            return this.DarPrecio() < otroPaquete.DarPrecio();            
        }
        public CPaquete(ushort num_paquete,string detalle)
        {
            if (detalle == null || detalle == "")
                throw new ArgumentException("EL DETALLE NO PUEDE SER VACIO");
            Num_Paquete = num_paquete;
            Detalle = detalle;
        }
=======
>>>>>>> d6440c635d63b9c68b0b4d981eaf63ed2c333f3b
    }
}
