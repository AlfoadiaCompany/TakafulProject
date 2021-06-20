namespace TakafulApi.Models
{
    public class Country
    {
        public int Id { get; set; } //رقم الدوله
        public string G_CNTRY_CODE { get; set; } // كود الدولة
        public string G_CNTRY_ADES { get; set; } // اسم الدولة بالعربى
         public string G_CNTRY_EDES { get; set; } // اسم الدولة بالانجليزية
         public int CurrencyId { get; set; } // رقم العملة 
         
    }
}