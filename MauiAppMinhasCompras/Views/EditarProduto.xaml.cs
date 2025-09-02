using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.Views;

public partial class EditarProduto : ContentPage
{
    // Construtor da classe EditarProduto
    public EditarProduto()
    {
        InitializeComponent(); 
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Obt�m o produto anexado ao contexto de dados (BindingContext)
            Produto produto_anexado = BindingContext as Produto;

            // Cria um novo objeto Produto com os valores dos campos de texto
            Produto p = new Produto
            {
                Id = produto_anexado.Id, // Mant�m o mesmo Id do produto anexado
                Descricao = txt_descricao.Text, // Obt�m a descri��o do campo de texto
                Quantidade = Convert.ToDouble(txt_quantidade.Text), // Converte a quantidade do campo de texto para double
                Preco = Convert.ToDouble(txt_preco.Text) // Converte o pre�o do campo de texto para double
            };

            // Atualiza o produto no banco de dados
            await App.Db.Update(p);
            await DisplayAlert("Sucesso!", "Registro Atualizado", "OK");
            // Retorna para a p�gina anterior na navega��o
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
           
        } await DisplayAlert("Ops", ex.Message, "OK");
    }
}