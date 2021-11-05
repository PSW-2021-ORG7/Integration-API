﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Integration_Class_Library.Models;
using Integration_Class_Library.PharmacyEntity.DAL;
using Integration_Class_Library.PharmacyEntity.Interfaces;

namespace Integration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmaciesController : Controller
    {

        private readonly IPharmacyRepository _pharmacies;
        public PharmaciesController(IPharmacyRepository pharmacies)
        {
            _pharmacies = pharmacies;
        }

          // GET: api/pharmacies/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Pharmacy>> GetPharmacyById(String id)
        {
            return Ok(await _pharmacies.GetPharmacyById(id));
        }

        // GET: Pharmacies/
        public async Task<IActionResult> GetPharmacies()
        {
            return Ok(await _pharmacies.GetAllPharmacies());
        }

        // POST: api/pharmacies
        [HttpPost]
        public async Task<ActionResult<Pharmacy>> PostPharmacy([FromBody] Pharmacy pharmacy)
        {
            return Ok(await _pharmacies.CreatePharmacy(pharmacy));
        }

        // PUT: api/pharmacies/id
        [HttpPut("{id}")]
        public async Task<int> PutPharmacy(String id, Pharmacy pharmacy)
        {
           return (await _pharmacies.PutPharmacy(id, pharmacy));
        }

        // DELETE: api/pharmacies/id
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pharmacy>> DeletePharmacy(String id)
        {
            return ( await _pharmacies.DeletePharmacy(id));
        }

    }
}
