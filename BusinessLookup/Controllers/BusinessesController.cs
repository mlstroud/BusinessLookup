using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessLookup.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusinessLookup.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/1.0/businesses")]
  [ApiController]
  public class BusinessesV1Controller : ControllerBase
  {
    private BusinessLookupContext _db;

    public BusinessesV1Controller(BusinessLookupContext db)
    {
      _db = db;
    }

    // GET api/businesses
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get()
    {
      return _db.Businesses.ToList();
    }

    // GET api/businesses/1
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id)
    {
      return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }

    // POST api/businesses
    [HttpPost]
    public void Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    // PUT api/businesses/1
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Business business)
    {
      business.BusinessId = id;
      _db.Entry(business).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/businesses/1
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var business = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
      _db.Businesses.Remove(business);
      _db.SaveChanges();
    }
  }

  [ApiVersion("2.0")]
  [Route("api/2.0/businesses")]
  [ApiController]
  public class BusinessesV2Controller : ControllerBase
  {

    private BusinessLookupContext _db;

    public BusinessesV2Controller(BusinessLookupContext db)
    {
      _db = db;
    }

    // GET api/businesses
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get(string name, string category, string city)
    {
      var query = _db.Businesses.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }

      if (city != null)
      {
        query = query.Where(entry => entry.Address.Contains(city));
      }

      return query.ToList();
    }

    // GET api/businesses/ranndom
    [HttpGet("random")]
    public ActionResult<Business> Random()
    {
      Random rand = new Random();
      int toSkip = rand.Next(0, _db.Businesses.Count());
      return _db.Businesses.OrderBy(entry => Guid.NewGuid()).Skip(toSkip).Take(1).First();
    }
  }
}