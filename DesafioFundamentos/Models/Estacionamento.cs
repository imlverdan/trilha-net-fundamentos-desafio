namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            string placa = Console.ReadLine();  //Usuario digita placa para adicionar na lista "veiculos"
            veiculos.Add(placa); //Comando para adicionar placa na lista 
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            
            
        }

        public void RemoverVeiculo()
        {
            string placa = Console.ReadLine(); //Usuario digita e armazena placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                              
                int horas = int.Parse(Console.ReadLine()); //Usuario digita quantidade de horas utilizadas
                decimal valorTotal = precoInicial + precoPorHora * horas; //realiza calculo de preços  horas para valorTotal

                
                veiculos.Remove(placa); //comando para remover placa da lista "veiculos"
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
            foreach(var veiculo in veiculos) //laço de repetição
            {
                Console.WriteLine(veiculo); //existe veiculos estacionados
            }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
