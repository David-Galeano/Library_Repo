using Microsoft.AspNetCore.Mvc;
namespace LIBRARY_DG.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LibraryController:ControllerBase
    {
        //public property
        public string LibraryProperty { get; set; }
        public LibraryController()
        {
        }
        [HttpGet]
        public string Get_Book()
        {
            return "Book found";
        }
        [HttpGet]
        public string Search_Student()
        {
            return "Student gotten from database";
        }
        [HttpGet]
        public string Get_Loan()
        {
            return "The loan has been found";
        }
        [HttpGet]
        public string Search_Author()
        {
            return "An author has been found";
        }
        [HttpPost]
        public string Update_Book()
        {
            return "Book data modified succesfully";
        }
        [HttpPost]
        public string Update_Student()
        {
            return "Student data updated";
        }
        [HttpPost]
        public string Update_Loan()
        {
            return "Monetary data updated";
        }
        [HttpPost]
        public string Update_Author()
        {
            return "Author information modified";
        }
        [HttpPut]
        public string UpdateBook()
        {
            return "New book added to databank";
        }
        [HttpPut]
        public string Add_Student()
        {
            return "Sudent data added succesfully";
        }
        [HttpPut]
        public string Include_Loan()
        {
            return "New loan created";
        }
        [HttpPut]
        public string Create_Author()
        {
            return "New author data added";
        }
        [HttpDelete]
        public string DELETEBook()
        {
            return "Computer deactivate Iguana    " +
                "NOOOOOOOOOOOOOOOOOOO";

        }
        [HttpDelete]
        public string Erase_Student()
        {
            return "Student data erased";
        }
        [HttpDelete]
        public string Delete_Loan()
        {
            return "The loan has been paid/the loan has been deleted";
        }
        [HttpDelete]
        public string Erase_Author()
        {
            return "Author data eliminated succesfully";
        }
    }
}