namespace ProjetoIntroducao
{
    public class Carro
    {
        private string marca;
        private string modelo;
        private string tipoDeCombustivel;

        public string GetMarca ()
        {
            return this.marca;
        }

        public void SetMarca (string marca)
        {
            this.marca = marca;
        }

        public string GetModelo ()
        {
            return this.modelo;
        }

        public void SetModelo (string modelo)
        {
            this.modelo = modelo;
        }

        public string GetTipoDeCombustivel ()
        {
            return this.tipoDeCombustivel;
        }

        public void SetTipoDeCombustivel (string tipoDeCombustivel)
        {
            this.tipoDeCombustivel = tipoDeCombustivel;
        }
        public void Ligar ()
        {
            Console.WriteLine("Ligado!");
            
        }
        public void Buzinar ()
        {
            Console.WriteLine("Desligado");
        }
    }
}