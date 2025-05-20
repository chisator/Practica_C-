namespace TipoParcial2
{
    public class CEjecutora
    {

        public static void Main()
        {
            List<CPaquete> listaPaquetes = new List<CPaquete>();
            CPaquete p1 = new CPaquete(101, "Bariloche – 10 días y 8 noches – Bus – Hotel Pucón – Pensión Completa");
            p1.SetCosto(8978.50f);
            listaPaquetes.Add(p1);

            CPaquete p2 = new CPaquete(202, "Mendoza – 7 días y 5 noches – Avión – Hotel Sol – Media Pensión");
            p2.SetCosto(10500.00f);
            listaPaquetes.Add(p2);

            CPaquete p3 = new CPaquete(303, "Cataratas – 5 días y 4 noches – Bus – Hotel Selva – Desayuno");
            p3.SetCosto(7500.00f);
            listaPaquetes.Add(p3);

            CPaquete p4 = new CPaquete(404, "Salta – 8 días y 6 noches – Avión – Hotel Norte – Pensión Completa");
            p4.SetCosto(9500.00f);
            listaPaquetes.Add(p4);
            
            //1) Solicitar impuesto
            Console.WriteLine("Ingrese impuesto único:");
            float impuesto = float.Parse(Console.ReadLine());
            CPaquete.SetImpuesto(impuesto);
            // 2) Carga iterativa
            Console.WriteLine("Ingrese el número de paquete:");
            ushort num_paquete = ushort.Parse(Console.ReadLine());
            while (num_paquete != 0)
            {    
                Console.WriteLine("Ingrese la descripción del paquete:");
                string? detalle = Console.ReadLine();
                CPaquete paquete = new CPaquete(num_paquete, detalle);
                Console.WriteLine("Ingrese el costo del paquete:");
                paquete.SetCosto(float.Parse(Console.ReadLine()!));
                Console.WriteLine("Paquete ingresado --> " + paquete.DarDatos());
                listaPaquetes.Add(paquete);
                Console.Write("\nIngrese Nro. de Paquete (0 para finalizar): ");
                num_paquete = ushort.Parse(Console.ReadLine());
            }
            if(listaPaquetes.Count == 0)
            {
                Console.WriteLine("No se ingresaron paquetes turísticos válidos.");
                return;
            }
            CPaquete masBarato = listaPaquetes.OrderBy(p => p.DarPrecio()).First();
            Console.WriteLine($"PAQUETE MAS ECONOMICO : {masBarato.DarDatos()}");
            
            return;
        }
    }
}
