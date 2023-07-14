using hospital.integracion.Data;
using hospital.webApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace hospital.integracion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebController : Controller
    {
        private readonly WebAPIDbContext webAPIDbContext;

        public WebController(WebAPIDbContext webAPIDbContext)
        {
            this.webAPIDbContext = webAPIDbContext;
        }

        [HttpGet("AllClientes")]
        public ActionResult AllClientes()
        {
            var result = webAPIDbContext.Cliente.ToList();
            return Ok(result);
        }

        [HttpGet("Cliente")]
        public ActionResult Cliente(int? id)
        {
            var cliente = webAPIDbContext.Cliente.Find(id);
            if (id == null)
            {
                return BadRequest("Inserte un Id");
            }
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost("CreateCliente")]
        public ActionResult CreateCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                webAPIDbContext.Cliente.Add(cliente);
                webAPIDbContext.SaveChanges();
            }

            return Ok(cliente);
        }

        [HttpPost("EditCliente")]
        public ActionResult EditCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                webAPIDbContext.Entry(cliente).State = EntityState.Modified;
                webAPIDbContext.SaveChanges();
            }
            return Ok(cliente);
        }


        [HttpPost("DeleteCliente")]
        public ActionResult DeleteCliente(int id)
        {
            Cliente cliente = webAPIDbContext.Cliente.Find(id);
            webAPIDbContext.Cliente.Remove(cliente);
            webAPIDbContext.SaveChanges();

            return Ok(cliente);
        }

        //-------------------------------------------------------CITAS-------------------------------------------------------

        [HttpGet("Citas")]
        public ActionResult Citas()
        {
            var result = webAPIDbContext.Cita.ToList();
            return Ok(result);
        }

        [HttpGet("Cita")]
        public ActionResult Cita(int? id)
        {
            var cita = webAPIDbContext.Cita.Find(id);
            if (id == null)
            {
                return BadRequest("Inserte un Id");
            }
            if (cita == null)
            {
                return NotFound();
            }
            return Ok(cita);
        }

        [HttpPost("CreateCita")]
        public ActionResult CreateCita(Cita cita)
        {
            if (ModelState.IsValid)
            {
                webAPIDbContext.Cita.Add(cita);
                webAPIDbContext.SaveChanges();
            }

            return Ok(cita);
        }

        [HttpPost("EditCita")]
        public ActionResult EditCita(Cita cita)
        {
            if (ModelState.IsValid)
            {
                webAPIDbContext.Entry(cita).State = EntityState.Modified;
                webAPIDbContext.SaveChanges();
            }
            return Ok(cita);
        }


        [HttpPost("DeleteCita")]
        public ActionResult DeleteCita(int id)
        {
            Cita cita = webAPIDbContext.Cita.Find(id);
            webAPIDbContext.Cita.Remove(cita);
            webAPIDbContext.SaveChanges();

            return Ok(cita);
        }

        //-------------------------------------------------------Transacciones-------------------------------------------------------

        [HttpGet("Transacciones")]
        public ActionResult Transacciones()
        {
            var result = webAPIDbContext.Transaccion.ToList();
            return Ok(result);
        }

        [HttpGet("Transaccion")]
        public ActionResult Transaccion(int? id)
        {
            var transaccion = webAPIDbContext.Transaccion.Find(id);
            if (id == null)
            {
                return BadRequest("Inserte un Id");
            }
            if (transaccion == null)
            {
                return NotFound();
            }
            return Ok(transaccion);
        }

        [HttpPost("CreateTransaccion")]
        public ActionResult CreateTransaccion(Transaccion transaccion)
        {
            if (ModelState.IsValid)
            {
                webAPIDbContext.Transaccion.Add(transaccion);
                webAPIDbContext.SaveChanges();
            }

            return Ok(transaccion);
        }

        [HttpPost("EditTransaccion")]
        public ActionResult EditTransaccion(Transaccion transaccion)
        {
            if (ModelState.IsValid)
            {
                webAPIDbContext.Entry(transaccion).State = EntityState.Modified;
                webAPIDbContext.SaveChanges();
            }
            return Ok(transaccion);
        }


        [HttpPost("DeleteTransaccion")]
        public ActionResult DeleteTransaccion(int id)
        {
            Transaccion transaccion = webAPIDbContext.Transaccion.Find(id);
            webAPIDbContext.Transaccion.Remove(transaccion);
            webAPIDbContext.SaveChanges();

            return Ok(transaccion);
        }
    }
}
