using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System;
using Library_BookAPI.Models;
using Library_BookAPI.Models.Dto;
using Library_BookAPI.Data;

namespace Library_BookAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/BookAPI")]
    [ApiController]
    // Automatic Model Validation: When a controller is marked with [ApiController], it enables automatic model validation.
    // This means that the framework will automatically validate incoming model data (e.g., from request bodies)
    // and return appropriate validation error responses without the need for explicit validation code.

    // Binding Source: It specifies that the controller should use the[FromBody] attribute as the default binding source
    // for complex types in action parameters.This means that complex objects are expected to be part of the request body by default.

    // Error Handling: It also configures the controller to return problem details in response to common error scenarios,
    // such as 400 Bad Request for model validation errors and 500 Internal Server Error for unhandled exceptions.
    public class BookAPIClass : ControllerBase
    // ControllerBase: provides a set of methods and properties that
    // simplify the implementation of controller actions.
    {
        [HttpGet] // GET endpoint ! RETURNS 1 RECORD
        public ActionResult<IEnumerable<BookDTO>> GetBooks()
        {
            return Ok(BookStore.bookList);
        }
        
        [HttpGet("{id:int}")] // GET endpoint ! RETURNS MULTIPLE RECORD
        [ProducesResponseType(StatusCodes.Status200OK)] // DEFINE RESPONSES
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
//      [ProducesResponseType(200, Type = typeof(BookDTO))] // DEFINE RESPONSES

        public ActionResult<BookDTO> GetBook(int id)
        {
            if(id==0)
            {
                return BadRequest(); // response status is 400 = BAD REQUEST
            }
            var book = BookStore.bookList.FirstOrDefault(u => u.Id == id);
            if (book == null)
                return NotFound(); // response status is 404 = NOT FOUND

            return Ok(); //link operation
        }
    }  
}
