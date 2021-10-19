using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace Controllers
{

    
    [ApiController]
    [Route("api/[controller]")]
    
    public class PersonController : ControllerBase
    {
        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        }

        [HttpGet, Route("GetFullName")]
        public IActionResult GetFullName()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFullName();
            return Ok(persons);
        }

        [HttpGet, Route("GetGender/{gender}")]
        public IActionResult GetGender(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetGender(gender);
            return Ok(persons);
        }

        [HttpGet,Route("GetVeinteYTreinta/{age}/{agee}")]
        public IActionResult GetVeinteYTreinta(int age, int agee)
        {
            var repository = new PersonRepository();
            var persons = repository.GetVeinteYTreinta(age, agee);
            return Ok(persons);
        }

        [HttpGet, Route("AllJobs")]
        public IActionResult AllJobs()
        {
            var repository = new PersonRepository();
            var jobs = repository.AllJobs();
            return Ok(jobs);
        }
        [HttpGet, Route("FindWord/{word}")]
        public IActionResult FindWord(string word)
        {
            var repository = new PersonRepository();
            var persons = repository.FindWord(word);
            return Ok(persons);
        }

        [HttpGet, Route("GetByAges")]
        public IActionResult GetByAges(List<int> ages)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAges(ages);
            return Ok(persons);
        }

        [HttpGet, Route("GetByAgees/{age}")]
        public IActionResult GetByAgees(int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAgees(age);
            return Ok(persons);
        }
        
        [HttpGet, Route("GetListOrdered/{minAge},{maxAge},{gender}")]
        public IActionResult GetListOrdered(int minAge, int maxAge, char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetListOrdered(minAge, maxAge, gender);
            return Ok(persons);
        }

        [HttpGet, Route("CountGender/{gender}")]
        public IActionResult CountGender(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountGender(gender);
            return Ok(persons);
        }

        [HttpGet, Route("AnyPerson/{lastName}")]
        public IActionResult AnyPerson(string lastName)
        {
            var repository = new PersonRepository();
            var persons = repository.AnyPerson(lastName);
            return Ok(persons);
        }

        [HttpGet, Route("GetJobSoftware/{age}/{job}")]
        public IActionResult GetJobSoftware(int age,string job)
        {
            var repository = new PersonRepository();
            var person = repository.GetJobSoftware(age, job);
            return Ok(person);
        }

        [HttpGet, Route("TakeJobs/{job}/{take}")]
        public IActionResult TakeJobs(string job, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.TakeJobs(job, take);
            return Ok(persons);
        }

        [HttpGet, Route("Skipjobs/{job}/{take}/{skip}")]
        public IActionResult Skipjobs(string job, int take, int skip)
        {
            var repository = new PersonRepository();
            var persons = repository.Skipjobs(job, take, skip);
            return Ok(persons);
        }
    }
}