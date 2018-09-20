using allmatech.DAL;
using allmatech.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace allmatech.Controllers
{
    [EnableCors("*","*","*")]
    public class ClienteController : ApiController
    {
        //// GET: api/Cliente/5
        public string Get(int id)

        {
            var clienteDal = new ClienteDAL();



            var cliente = clienteDal.PesquisarClientePorid(id);



            return JsonConvert.SerializeObject(cliente);
        }

        // POST: api/Cliente
        public void Post([FromBody]string value)
        {
            var cliente = JsonConvert.DeserializeObject<tbCliente>(value);
            var clienteDal = new ClienteDAL();
            clienteDal.InserirCliente(cliente);

        }

        // PUT: api/Cliente/5
        public void Put([FromBody]string value)
        {

            var cliente = JsonConvert.DeserializeObject<tbCliente>(value);

            var clienteDal = new ClienteDAL();
            clienteDal.AlterarCliente(cliente);

        }

        // DELETE: api/Cliente/5
        public void Delete(int codigo)
        {
            var clienteDal = new ClienteDAL();
            clienteDal.ExcluirCliente(codigo);
        }
    }
    //// GET: api/Cliente
    //public IEnumerable<Cliente> Get()
    //{
    //    //using ( ctrl + p)
    //    Cliente cliente = new Cliente();

    //    return cliente.listarCliente();
    //}

    //// GET: api/Cliente/5
    //public Cliente Get(int id)

    //{
    //    //using ( ctrl + p)
    //    Cliente cliente = new Cliente();

    //    return cliente.listarCliente().Where(x => x.id == id).FirstOrDefault();



    //}

    //// POST: api/Cliente
    //    public List<Cliente>Post(Cliente cliente)
    //{

    //    Cliente _cliente = new Cliente();

    //    _cliente.Inserir(cliente);

    //    return _cliente.listarCliente();



    //}

    //// PUT: api/Cliente/5
    //public Cliente Put(int id, [FromBody]Cliente cliente)
    //{
    //    Cliente _cliente = new Cliente();

    //    _cliente.Atualizar(id, cliente);

    //    return _cliente.Atualizar(id, cliente);
    //}

    //// DELETE: api/Cliente/5
    //public void Delete(int id)
    //{
    //    Cliente _cliente = new Cliente();

    //    _cliente.Deletar(id);

    //}
}

