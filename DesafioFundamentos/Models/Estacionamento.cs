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
            //Adiciona a placa do veiculo
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            
            string palcaVeiculo = Console.ReadLine();
            palcaVeiculo = palcaVeiculo.Replace(@"-", "");
            
            //Checa se placa é válida
            if (palcaVeiculo.Length == 7)
            {
                veiculos.Add(palcaVeiculo);
                Console.WriteLine("Veiculo cadastrado com sucesso!");
            }else
            {
                Console.WriteLine("Modelo de placa incorreta. Digite novamente.");
            }            

            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");            
            
            string placa = "";

            placa = Console.ReadLine();
            placa = placa.Replace(@"-", "");

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = 0;
                decimal valorTotal = 0; 
                
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);

                // Remove a placa do sistema
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                // Exibe os veículos estacionados                
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
