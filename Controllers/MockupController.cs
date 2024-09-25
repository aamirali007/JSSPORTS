using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.DTOs;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MockupController : ControllerBase
    {
        private readonly IMockupService _mockupService;
        public MockupController(IMockupService mockupService) 
        {
            _mockupService = mockupService;
        }

        #region POST
        [HttpPost("addNewMockup")]
        public IActionResult AddNewMockup([FromBody] List<AddNewMockup> addNewMockups)
        {
            if (addNewMockups == null || !addNewMockups.Any())
            {
                return BadRequest("Invalid mockup data. The array is empty or null.");
            }

            try
            {
                // Access the custom header (for example, 'Authorization' or any custom header)
                if (Request.Headers.TryGetValue("Authorization", out var headerValue))
                {
                    // Process the header value
                    Console.WriteLine("Custom Header Value: " + headerValue);
                }
                else
                {
                    return BadRequest("Required header not found.");
                }
                foreach (var mockup in addNewMockups)
                {
                    _mockupService.AddNewMockup(mockup);
                }
                
                return Ok("All mockups submitted successfully.");
            }
            catch (Exception ex)
            {
                // Log the exception (if necessary)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        #endregion

        #region GET
        [HttpGet("getMockupsClientRequest")]
        public IActionResult GetMockupsClientRequest()
        {
            var mockups = _mockupService.GetMockupsClientRequest();
            return Ok(mockups);
        }

        [HttpGet("getMockupsMoveToDesignDept")]
        public IActionResult GetMockupsMoveToDesigningDepartment()
        {
            var mockups = _mockupService.MoveToDesigningDepartment();
            return Ok(mockups);
        }

        [HttpGet("getMockupsAssignToDesigner")]
        public IActionResult GetMockupsAssignToDesigner()
        {
            var mockups = _mockupService.getMockupsAssignToDesigner();
            return Ok(mockups);
        }

        [HttpGet("getApprovedMockups")]
        public IActionResult GetApprovedMockups()
        {
            var mockups = _mockupService.GetApprovedMockups(2);
            return Ok(mockups);
        }
        #endregion
    }
}
