using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDesacoplamentoComInterfaces
{
    class ControladorDeTurno : IColecoes
    {
        #region Elementos da Interface IColecoes
        public void Adiciona(ICollection<object> colecao, object objeto)
        {
            try
            {
                colecao.Add(objeto);
            }
            catch
            {
                throw new Exception("Não foi possível adicionar esse elemento na coleção. Verifique se seu tipo coincide com o da coleção!");
            }
        }

        public string Procura(ICollection<object> colecao, object objeto)
        {
            var output = "";

            foreach (string item in colecao)
            {
                if (item.ToString() == objeto.ToString())
                    output += item + "\n";
            }

            if (output != "")
            {
                return output;
            }
            else 
            {
                throw new Exception("Não foi possível encontrar dados nessa coleção!");
             }
        }

         public void Remove(ICollection<object> colecao, object objeto)
        {
            try 
            {
                colecao.Remove(objeto);
            }
            catch
            { 
                throw new Exception ("Não foi possível deletar esse elemento na coleção. Verifique se ele existe!");
            }
        }

         public void Troca(ICollection<object> colecaoAntiga, ICollection<object> colecaoNova, object objeto)
        {
            Adiciona(colecaoNova, objeto);
            Remove(colecaoAntiga, objeto);
        }

         public string ListaElementos(ICollection<object> colecao)
        {
            string output = "";
            
            foreach(string itens in colecao)
                output +=  itens + "\n";

            return output;
        }
        #endregion
    }
}
