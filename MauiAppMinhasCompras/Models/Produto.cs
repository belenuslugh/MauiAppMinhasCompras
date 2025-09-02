using SQLite; // Importa o namespace SQLite 

namespace MauiAppMinhasCompras.Models
{
    
    public class Produto
    {
        // Campo privado para armazenar a descrição
        string _descricao;

        // Define a propriedade Id como chave primária e autoincremento no banco de dados
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Descricao
        {
            get => _descricao; // Retorna o valor da descrição
            set
            {
                // Verifica se o valor é nulo
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }

                // Atribui o valor à variável privada _descricao
                _descricao = value;
            }
        }

        //  Quantidade para armazenar a quantidade do produto
        public double Quantidade { get; set; }

        //  Preco para armazenar o preço do produto
        public double Preco { get; set; }

        //  Total que calcula o total com base na quantidade e no preço
        public double Total { get => Quantidade * Preco; }
    }
}
