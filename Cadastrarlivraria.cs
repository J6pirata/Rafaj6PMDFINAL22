using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Livraria.Services;
using Microsoft.Maui.Controls.Platform.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.MVVM.ModelView
{
    internal class CadastrarLivraria : ObservableObject
    {
        private readonly ILivrariaService _livrariaService;

        [ObservableProperty]
        private string _nomeDoLivro;
        [ObservableProperty]
        private string _nomeDoAutor;
        [ObservableProperty]
        private string _emailDoAutor;
        [ObservableProperty]
        private string _livroEmprestadoPara;

        public CadastrarLivriara(IlivrariaService livrariaService)
        {
            _livrariaService = livrariaService;

        }
        [RelayCommand]
        private async Task CadastrarLivro()
        {
            try
            {
                if (!string.IsNullOrEmpty(NomeDoAutor))
                {
                    Livraria livro = new()
                    {
                        nomedolivro = NomeDoLivro,
                        nomedoautor = NomeDoAutor,
                        emaildoautor = EmailDoAutor,
                        ISBN = isbn;
                    };

                    await _livrariaService.InitializeAsync();
                    await _livrariaService.CriaLivroAsync(livro);

                    await Shell.Current.GoToAsync("..");
                    MainPage mainPage = new();
                    mainPage = new NavigationPage(new TelaCadastro());
                }

            public  async Task ExcluirLivro()
            {

            }
            }
}
