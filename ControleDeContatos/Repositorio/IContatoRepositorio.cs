using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscasTodos();
        ContatoModel Adicionar(ContatoModel contato);

        
    }
}
