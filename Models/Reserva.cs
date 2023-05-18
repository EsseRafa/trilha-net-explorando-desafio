namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            
            if (Suite.Capacidade >= hospedes.Count )
            {
                Hospedes = hospedes;    
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
               throw new Exception("O número de hóspedes é superior à capacidade da Suite.");
            
                
            }            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int qtdHospedes = Hospedes.Count;
            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            int diasReservados = DiasReservados;
            decimal precoDiaria = Suite.ValorDiaria;
            decimal valor = diasReservados * precoDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (diasReservados >= 10)
            {
                decimal desconto = valor * Convert.ToDecimal(0.1);
                valor = valor - desconto;
            }

            return valor;
        }
    }
}