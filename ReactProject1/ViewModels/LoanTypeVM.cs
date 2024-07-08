using Microsoft.AspNetCore.Mvc.Rendering;
using ReactProject1.DBQueries;
using System.ComponentModel.DataAnnotations;

namespace ReactProject1.ViewModels
{
    public class LoanTypeVM
    {
        public int Id { get; set; }
        public string LoanTypeName { get; set; }
        public string ProductName { get; set; }
        public string EntityType { get; set; }
        public string InstanceId { get; set; }
        public string Loan_Type_Code { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public List<SelectListItem> RetailLoanList { get; set; }
        public List<SelectListItem> MSMELoanList { get; set; }
        public List<SelectListItem> AgriLoanList { get; set; }
        public List<SelectListItem> LoanSubTypeList { get; set; } = new List<SelectListItem>();
        public string LoanSubType { get; set; }

        public LoanTypeVM()
        {
            RetailLoanList = new List<SelectListItem>();
            MSMELoanList = new List<SelectListItem>();
            AgriLoanList = new List<SelectListItem>();
        }


        public LoanTypeVM GetLoanList()
        {
            var loanTypeMappingList = DBOpsLOS.GetLoanTypeMappingList();
            foreach (var item in loanTypeMappingList)
            {
                if (item.LoanTypeName == "RetailLoan")
                {
                    this.RetailLoanList.Add(new SelectListItem { Text = item.ProductName, Value = item.LoanTypeId.ToString() });

                }
                else if (item.LoanTypeName == "MSME")
                {
                    this.MSMELoanList.Add(new SelectListItem { Text = item.ProductName, Value = item.LoanTypeId.ToString() });
                }
                else if (item.LoanTypeName == "AGRI")
                {
                    this.AgriLoanList.Add(new SelectListItem { Text = item.ProductName, Value = item.LoanTypeId.ToString() });
                }
            }
            return this;
        }

        public List<SelectListItem> GetLoanSubType(int loanTypeId)
        {
            var LoanSubTypeList = DBOpsLOS.GetLoanSubTypes(loanTypeId);
            foreach (var item in LoanSubTypeList)
            {

                    this.LoanSubTypeList.Add(new SelectListItem { Text = item.Description, Value = item.Value.ToString() });
            }
            return this.LoanSubTypeList;
        }
    }
}
