using Livraria.MVVM.ModelView;

namespace Livraria;

public partial class TelaCadastro : ContentView
{
	public TelaCadastro()
	{
		InitializeComponent();
		BindingContext = CadastrarLivraria;
	}
}