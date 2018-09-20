using allmatech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using allmatech.DAL;

namespace allmatech.DAL
{
    public class ClienteDAL
    {
        //Retorna todos os registros da tabela TA_LOGRADOURO_TESTE
        public IList<tbCliente> Listar()
        { 
            var ClientesDB = new DBclienteEntities();
            var cliente = ClientesDB.tbCliente.ToList();//retorna todos os elementos da tabela
            return cliente ;
        }
        //Retorna um registro pelo codigo os registros da tabela TA_LOGRADOURO_TESTE
        public tbCliente PesquisarClientePorid(int id)
        {
            var ClientesDB = new DBclienteEntities();
            var cliente = ClientesDB.tbCliente.Where(l => l.id== id).FirstOrDefault();//Ele retorna nulo ou o objeto pesquisado.
            return cliente;

        }
        //Retorna uma lista de logradouros pesquisados pela descrição
        public IList<tbCliente> PesquisarCLientePorid(string nome)
        {
            var ClientesDB = new DBclienteEntities( );
            var ListaClientes = ClientesDB.tbCliente.Where(l => l.nome.Contains(nome)).ToList();//Retorna um ou mais registros
            return ListaClientes;
        }
        public void InserirCliente(tbCliente ClienteNovo)//cliente são os parametros que eu quero inserir na tabela de logradouro
        {
            var ClientesDB = new DBclienteEntities();
            ClientesDB.tbCliente.Add(ClienteNovo);// INCLUIR
            ClientesDB.SaveChanges();

        }

        public void AlterarCliente(tbCliente cliente)//cliente é um objet
        {
            var ClientesDB = new DBclienteEntities();
            var logespecifico = ClientesDB.tbCliente.Attach(cliente);//Retorna os objetos da tabela que correspondem ao codigo informado.
            ClientesDB.SaveChanges();

        }

        public void ExcluirCliente(int id)
        {
            var ClientesDB = new DBclienteEntities();
            var logespecifico = ClientesDB.tbCliente.Where(l => l.id == id).FirstOrDefault();
            ClientesDB.tbCliente.Remove(logespecifico);
            ClientesDB.SaveChanges();

        }
    }
}
    
