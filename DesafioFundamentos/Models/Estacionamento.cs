namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal PreçoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private decimal horasEstacionado;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.PreçoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            Console.WriteLine("Digite a placa do carro:");
             string placa = "";
                 {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placaRemover = Console.ReadLine();

        if (placa == placaRemover)
        {
            placa = ""; 
            Console.WriteLine("Placa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("A placa digitada não corresponde à placa armazenada.");
        }
        }

        
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                if (int.TryParse(Console.ReadLine(), out int horasEstacionado))
                {
                    // Aqui você pode fazer algo com a variável horasEstacionado
                    Console.WriteLine($"O veículo permaneceu estacionado por {horasEstacionado} horas.");
                }
                else
                {
                    Console.WriteLine("Por favor, digite um valor válido para as horas.");
                }
                int valorTotal = 0; 
                int PreçoPorHora = +2;
                int precoInicial = 5;

                

                 if (int.TryParse(Console.ReadLine(), out horasEstacionado))
        {
            valorTotal = precoInicial + (PreçoPorHora * horasEstacionado);
            Console.WriteLine($"O valor total a pagar pelo veículo com placa {placa} é: {valorTotal}");
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido de horas.");
        }

                // Já realizado acima remover a placa da lista

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Verifique se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
         if (veiculos.Count > 0)
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (string placa in veiculos)
            {
                Console.WriteLine(placa); 
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
        }
    }
}
