namespace DapperProject.Dtos.DashboardDtos
{
    public class ResultDashboardStatisticDto
    {
        public string ExpensiveProductName { get; set; }
        public decimal ExpensiveProductPrice { get; set; }
        public decimal ProductAvgPrice { get; set; }
        public decimal CheeperProductPrice { get; set; }
        public int ProductCount { get; set; }   
    }
}
