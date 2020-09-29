using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GasPump;
using GasPumpWebService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GasPumpWebService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GasPumpController : ControllerBase
    {
        private GasPumpContext _context;
        private Pump gasPump;

        public GasPumpController(GasPumpContext _context)
        {
            this.gasPump = new Pump();
            this._context = _context;

            if (_context.Refils.Count() == 0)
            {
                _context.Refils.Add(new Refil { id = 0, date = DateTime.Now});
                _context.SaveChanges();
            }
            if (_context.CapacityLowerings.Count() == 0)
            {
                _context.CapacityLowerings.Add(new CapacityLowering { id = 0, amount=0 });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        [Route("CostOfFullTank")]
        public double GetCostOfFullTank([FromQuery(Name = "size")] double size)
        {
            return gasPump.CostOfFullTank(size);
        }

        [HttpGet]
        [Route("FillTank")]
        public double GetFillTank([FromQuery(Name = "amount")] double amount)
        {
            if(gasPump.capacityLiters < amount)
            {
                return -1;
            }
            else
            {
                double tankCapacityBefore = gasPump.capacityLiters;
                double price = gasPump.FillTank(amount);
                if (tankCapacityBefore > gasPump.capacityLiters)
                {
                    double gasTaken = tankCapacityBefore - gasPump.capacityLiters;
                    Random r = new Random();
                    int rInt = r.Next(0, 10000);
                    CapacityLowering newLowering = new CapacityLowering { id = rInt, amount = gasTaken };
                    _context.CapacityLowerings.Add(newLowering);
                    _context.SaveChanges();
                }
                return gasPump.CostOfFullTank(amount);
            }
        }

        [HttpPost]
        [Route("FillPump")]
        public IActionResult PostFillPump()
        {
            Random r = new Random();
            int rInt = r.Next(0, 10000);
            DateTime dateOfRefil = gasPump.FillPump();
            Refil newRefil = new Refil { id = rInt, date = dateOfRefil };
            _context.Refils.Add(newRefil);
            _context.SaveChanges();
            Console.WriteLine("did this work?");
            return Ok();
        }

        [HttpGet]
        [Route("Refils")]
        public IEnumerable<Refil> GetAllRefils()
        {
            return _context.Refils;
        }
    }
}