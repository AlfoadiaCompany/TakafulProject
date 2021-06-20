namespace TakafulApi.Models
{
    public class Includes
    {
        public int Id { get; set; } // رقم
        public int Service_TypesId { get; set; } // رقم الخدمة
        public int SuppliersContractsId { get; set; } // قيمة العقد
        public int Contracts_Amount { get; set; } // قيمة الخدمات  //  (total from Service_Type_Amounts)
    
    }
}