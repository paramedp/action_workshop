using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using workshop.Model.Entities;

namespace workshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {

        /// <summary>
        /// API สำหรับ ************************************************************************
        /// </summary>
        /// <remarks>
        ///  demo [{OrganizationID:0,BudgetYear:0,BudgetName:0,BudgetCode:0,BudgetReferenceCode:0} , {OrganizationID:0,BudgetYear:0,BudgetName:0,BudgetCode:0,BudgetReferenceCode:0} ]
        /// </remarks>
        [HttpGet("v1/User")]
        [ProducesResponseType(typeof(UserEntity), (int)HttpStatusCode.OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> getUser()
        {


            UserEntity userEntity = new();
            userEntity.FullName = "Test t est ests t";

            return Ok(userEntity);
        }

    }



}
