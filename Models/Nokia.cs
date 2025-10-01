namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor herdado
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {

        }

                // Sobrescrevendo método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia via loja oficial Nokia Store...");
        }
    }
    

}