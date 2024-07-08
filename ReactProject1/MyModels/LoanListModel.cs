namespace ReactProject1.MyModels
{
    public class LoanListModel
    {
        public int Id { get; set; }
        public string LoanTypeName { get; set; }
        public string ProductName { get; set; }
        public string EntityType { get; set; }
        public string InstanceId { get; set; }
        public string Loan_Type_Code { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public int LoanTypeId { get; set; }
    }
}
