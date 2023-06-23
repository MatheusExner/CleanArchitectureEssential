namespace ModeloAnemico
{
    public sealed class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public Cliente(int id, string nome, string endereco)
        {
            Validar(id, nome, endereco);
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        public void Validar(int id, string nome, string endereco)
        {
            if (id < 0)
                throw new InvalidOperationException("id inválido");

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(endereco))
                throw new InvalidOperationException("o nome e endereço são requeridos");

            if (nome.Length > 100)
                throw new ArgumentException("o nome excedeu 100 caracteres");
        }
    }
}