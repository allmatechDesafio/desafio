using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace allmatech.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string carromarca { get; set; }
        public string carromodelo { get; set; }
        

        public List<Cliente> listarCliente()
        {
            /*  vai pegar o arquivo json , vai transferir o texto jason para variavel json , 
             *  pega a variavel e deserializa passando para lista jason e retorna uma lisa de alunos  
             */

            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data\Base.json");

            var Json = File.ReadAllText(caminhoArquivo);

            var listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(Json);

            return listaClientes; 

        }

        public bool RescreverArquivo(List<Cliente> listaClientes)
        {
            /* Pega o arquivo  , serializa, para que o objeto : Lista de clientes seja transformado em texto 
             * e logo depois passando para dentro de json 
             */

            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data\Base.json");

            var json = JsonConvert.SerializeObject(listaClientes, Formatting.Indented);

            File.WriteAllText(caminhoArquivo, json);

            return true;
        }

        public Cliente Inserir (Cliente cliente)
            {

             /* Listaraluno vai para variavel listaalunos
             * O max vai buscar o maior Id na lista de alunos e somar mais 1 e vai adiciona-lo
             * e depois vai passar para o método rescrever arquivo
             */

                var listaClientes = this.listarCliente();

                var maxId = listaClientes.Max(p => p.id);
                cliente.id = maxId + 1;
                listaClientes.Add(cliente);

                RescreverArquivo(listaClientes);
                return cliente;

            }

        public Cliente Atualizar(int id, Cliente cliente )
        {
            /*  Passa o Id que vai ser buscado , vai na lista deserializada 
             *  vai buscar , se encontrar o id  na lista vai certificar se o id é o que esta no parametro 
             *  e vai ser possivel atualizar pelo ItemIndex
             */

            var listaClientes = this.listarCliente();

            var itemIndex = listaClientes.FindIndex(P => P.id == id);
            if (itemIndex >= 0)
            {
                cliente.id = id;
                listaClientes[itemIndex] = cliente;

            }
            else
            {
                return null;
          
            }

            RescreverArquivo(listaClientes);
            return cliente;
        }


        public bool Deletar (int id)
        {

            /* vai locarlizar o cliente pelo id 
             * e vai poder excluir 
             */

            var listaClientes = this.listarCliente();

            var itemIndex = listaClientes.FindIndex(p => p.id == id);
            if (itemIndex >= 0)
            {
                listaClientes.RemoveAt(itemIndex);
            }
            else
            {
                return false;

            }

            RescreverArquivo(listaClientes);
            return true;
        }














        }
    }
