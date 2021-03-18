using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDesacoplamentoComInterfaces
{
    interface IColecoes
    {
        string Procura(ICollection<Object> colecao, Object objeto);
        void Adiciona (ICollection<Object> colecao, Object objeto);
        void Troca(ICollection<Object> colecaoAntiga, ICollection<Object> colecaoNova, Object objeto);
        void Remove(ICollection<Object> colecao, Object objeto);
        string ListaElementos(ICollection<Object> colecao);
    }
}
