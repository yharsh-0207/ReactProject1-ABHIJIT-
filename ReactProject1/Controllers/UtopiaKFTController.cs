using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReactProject1.ViewModels;

namespace ReactProject1.Controllers
{
    [ApiController]
    [Route("/api/utopiakft/")]
    public class UtopiaKFTController : Controller
    {

        [HttpGet("getloantypes")]
        public LoanTypeVM GetLoanTypes()
        {
            LoanTypeVM loanType = new LoanTypeVM();
            return loanType.GetLoanList();
        }

        [HttpGet("getloansubtypes/{id}")]
        public List<SelectListItem> GetLoanSubTypes(int id)
        {
            LoanTypeVM loanType = new LoanTypeVM();
            return loanType.GetLoanSubType(id);
        }
    }
}
