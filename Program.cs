using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDesacoplamentoComInterfaces
{
    class Program
    {
        public static ControladorDeTurno controladorDeTurno = new ControladorDeTurno();

        static void Main(string[] args)
        { 
            Console.WriteLine("Turno do Dia:");
            Console.WriteLine(controladorDeTurno.ListaElementos(TurnosDia.lista));
            Console.WriteLine("Turno da Noite:");
            Console.WriteLine(controladorDeTurno.ListaElementos(TurnosNoite.lista));

            Console.Write("Digite um dos nomes Listados acima: ");
            string nome = Console.ReadLine().Trim();
            Console.Clear();

           //ResuldadosComVetor(nome);
            ResuldadosComLista(nome);
            ResuldadosComHashSet(nome);

            Console.ReadLine();
        }

        #region Resultados
        public static void ResuldadosComLista(string nome)
        {
            Console.WriteLine("\n\nAssim fica a simulação passando uma List como referência: \n");

            ResultadoProcuraGenerico(TurnosDia.lista, TurnosNoite.lista, nome);
            ResultadoAdicionaGenerico(TurnosDia.lista, TurnosNoite.lista, nome);
            ResultadoRemoveGenerico(TurnosDia.lista, TurnosNoite.lista, nome);
            ResultadoTrocaGenerico(TurnosDia.lista, TurnosNoite.lista, nome);

        }

        public static void ResuldadosComHashSet(string nome)
        {
            Console.WriteLine("\n\nAssim fica a simulação passando uma HashSet como referência: \n");

            ResultadoProcuraGenerico(TurnosDia.hashSet, TurnosNoite.hashSet, nome);
            ResultadoAdicionaGenerico(TurnosDia.hashSet, TurnosNoite.hashSet, nome);
            ResultadoRemoveGenerico(TurnosDia.hashSet, TurnosNoite.hashSet, nome);
            ResultadoTrocaGenerico(TurnosDia.hashSet, TurnosNoite.hashSet, nome);

        }

        /* public static void ResuldadosComVetor(string nome)
        {
            Console.WriteLine("\n\nAssim fica a simulação passando um Vetor como referência:\n");

            ResultadoProcuraGenerico(TurnosDia.vector, TurnosNoite.vector, nome);
            ResultadoAdicionaGenerico(TurnosDia.vector, TurnosNoite.vector, nome);
            ResultadoRemoveGenerico(TurnosDia.vector, TurnosNoite.vector, nome);
            ResultadoTrocaGenerico(TurnosDia.vector, TurnosNoite.vector, nome);

        }*/
        #endregion

        #region Ações Genéricas
        public static void ResultadoRemoveGenerico(ICollection<object> colecaoDia, ICollection<object> colecaoNoite, string nome)
        {
            try
            {
                Console.Write("\nRemovendo o nome digitado do turno de dia: ");
                controladorDeTurno.Remove(colecaoDia , nome);
                Console.WriteLine(controladorDeTurno.ListaElementos(colecaoDia));
            }
            catch (Exception erro)
            {
                Console.WriteLine("ERRO: " + erro.Message);
            }

            try
            {
                Console.Write("\nRemovendo o nome digitado do turno de noite: ");
                controladorDeTurno.Remove(colecaoNoite, nome);
                Console.WriteLine(controladorDeTurno.ListaElementos(colecaoNoite));
            }
            catch (Exception erro)
            {
                Console.WriteLine("ERRO: " + erro.Message);
            }

            PausaEntreAcoes();
        }

        public static void ResultadoAdicionaGenerico(ICollection<object> colecaoDia, ICollection<object> colecaoNoite, string nome)
        {
            try
            {
                Console.Write("\nAdicionando o nome digitado do turno de dia: \n");
                controladorDeTurno.Adiciona(colecaoDia, nome);
                Console.WriteLine(controladorDeTurno.ListaElementos(colecaoDia));
            }
            catch (Exception erro)
            {
                Console.WriteLine("ERRO: " + erro.Message);
            }

            try
            {
                Console.Write("\nAdicionando o nome digitado do turno de noite: \n");
                controladorDeTurno.Adiciona(colecaoNoite, nome);
                Console.WriteLine(controladorDeTurno.ListaElementos(colecaoNoite));
            }
            catch (Exception erro)
            {
                Console.WriteLine("ERRO: " + erro.Message);
            }

            PausaEntreAcoes();
        }

        public static void ResultadoProcuraGenerico(ICollection<object> colecaoDia, ICollection<object> colecaoNoite, string nome)
        {
            try
            {
                Console.Write("\nProcurando o nome digitado do turno de dia: ");
               
                Console.WriteLine(controladorDeTurno.Procura(colecaoDia, nome));
            }
            catch (Exception erro)
            {
                Console.WriteLine("ERRO: " + erro.Message);
            }

            try
            {
                Console.Write("\nProcurando o nome digitado do turno de noite: ");

                Console.WriteLine(controladorDeTurno.Procura(colecaoNoite, nome));
            }
            catch (Exception erro)
            {
                Console.WriteLine("ERRO: " + erro.Message);
            }

            PausaEntreAcoes();
        }

        public static void ResultadoTrocaGenerico(ICollection<object> colecaoDia, ICollection<object> colecaoNoite, string nome)
        {
            try
            {
                Console.Write("\nTrocando nome digitado do turno de dia para o da noite: ");
                controladorDeTurno.Troca(colecaoDia, colecaoNoite, nome);
                Console.WriteLine("\nTurno de dia:");
                Console.WriteLine(controladorDeTurno.ListaElementos(colecaoDia));
                Console.WriteLine("\nTurno da noite:");
                Console.WriteLine(controladorDeTurno.ListaElementos(colecaoNoite));
            }
            catch (Exception erro)
            {
                Console.WriteLine("ERRO: " + erro.Message);
            }

            try
            {
                Console.WriteLine("\nTrocando nome digitado do turno da noite para o da dia: \n");
                controladorDeTurno.Troca(colecaoNoite, colecaoDia, nome);
                Console.WriteLine("\nTurno de dia:");
                Console.WriteLine(controladorDeTurno.ListaElementos(colecaoDia));
                Console.WriteLine("\nTurno da noite:");
                Console.WriteLine(controladorDeTurno.ListaElementos(colecaoNoite));
            }
            catch (Exception erro)
            {
                Console.WriteLine("ERRO: " + erro.Message);
            }

            PausaEntreAcoes();
        }

        public static void PausaEntreAcoes()
        {
            Console.Write("\nDigite enter para ir para o próximo passo:");
            Console.ReadLine();
            Console.Clear();
        }
        #endregion
    }

}