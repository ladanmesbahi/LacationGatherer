using LacationGatherer.Server.Persistence.UnitOfWorks.Abstractions;
using LacationGatherer.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace LacationGatherer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonUnitOfWork _unitOfWork;

        public PersonController(IPersonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Person person)
        {
            try
            {
                await _unitOfWork.People.Add(person);
                await _unitOfWork.Complete();
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAll()
        {
            try
            {
                return Ok(await _unitOfWork.People.GetAll());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
