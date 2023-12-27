namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica específica para a instalação de aplicativos em um Nokia
            // Pode incluir interações específicas do sistema operacional, armazenamento, etc.
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' em um Nokia.");
        }
    }
}