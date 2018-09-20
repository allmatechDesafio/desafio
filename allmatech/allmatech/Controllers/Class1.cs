using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using allmatech.DAL;

namespace allmatech.Controllers
{
    public class Class1
    {

      
            public class ClienteController : ApiController
            {
               

                // GET: api/Logradouro/5
                public string Get(int id)
                {
                    var clienteDal = new ClienteDAL();
                    var cliente = clienteDal.PesquisarClientePorid(id);
                    return JsonConvert.SerializeObject(cliente);
                }

                // POST: api/Logradouro
                public void Post([FromBody]string value)
                {
                    var cliente = JsonConvert.DeserializeObject<tbCliente>(value);
                    var clienteDal = new ClienteDAL();
                    clienteDal.InserirCliente(cliente);

                }

                // PUT: api/Logradouro/5
                public void Put([FromBody]string value)
                {

                    var cliente = JsonConvert.DeserializeObject<tbCliente>(value);

                    var clienteDal = new ClienteDAL();
                    clienteDal.AlterarCliente(cliente);

                }

                // DELETE: api/Logradouro/5
                 public void Delete(int codigo)
            {
                var clienteDal = new ClienteDAL();
                clienteDal.ExcluirCliente(codigo);
            }
            }
            }
        }
    
