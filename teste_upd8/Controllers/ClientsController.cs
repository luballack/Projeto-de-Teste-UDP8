using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Reflection;
using System.Xml.Linq;
using teste_upd8.Data;
using teste_upd8.Models;
using teste_upd8.Models.Domain;

namespace teste_upd8.Controllers
{
    public class ClientsController : Controller
    {
        private readonly UPD8DbContext upd8DbContext;

        public ClientsController(UPD8DbContext upd8DbContext)
        {
            this.upd8DbContext = upd8DbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// Redirect para View de Clientes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index() 
        { 
            var clients = await upd8DbContext.Clients.ToListAsync();
            return View(clients);
        }

        /// <summary>
        /// Cadastro de Cliente
        /// </summary>
        /// <param name="model">{Name, CPF, Address, DateOfBirth, Gender, City, State}</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(AddClientViewModel addClientRequest)
        {
            var Client = new Client()
            {
                Id = Guid.NewGuid(),
                Name = addClientRequest.Name,
                CPF = addClientRequest.CPF,
                Address = addClientRequest.Address,
                DateOfBirth = addClientRequest.DateOfBirth,
                Gender = addClientRequest.Gender,
                City = addClientRequest.City,
                State = addClientRequest.State

            };
            await upd8DbContext.Clients.AddAsync(Client);
            await upd8DbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Redirect para View de Edição de Cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var client = await upd8DbContext.Clients.FirstOrDefaultAsync(c => c.Id == id);
            if(client != null)
            {
                var updatedclient = new UpdateClientViewModel()
                {
                    Id = client.Id,
                    Name = client.Name,
                    CPF = client.CPF,
                    Address = client.Address,
                    DateOfBirth = client.DateOfBirth,
                    Gender = client.Gender,
                    City = client.City,
                    State = client.State
                };

                return View(updatedclient);
            }
            
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Edição de Cliente
        /// </summary>
        /// <param name="model">{Name, CPF, Address, DateOfBirth, Gender, City, State}</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Update(UpdateClientViewModel model)
        {
            var client = await upd8DbContext.Clients.FindAsync(model.Id);

            if(client != null)
            {
                client.Name = model.Name;
                client.CPF = model.CPF;
                client.Address = model.Address;
                client.DateOfBirth = model.DateOfBirth;
                client.Gender = model.Gender;
                client.City = model.City;
                client.State = model.State;

                await upd8DbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Cadastro de Cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        { 
            var cliente = await upd8DbContext.Clients.FindAsync(id);
            if (cliente != null)
            { 
                upd8DbContext.Clients.Remove(cliente);
                await upd8DbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
