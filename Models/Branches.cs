namespace TakafulApi.Models
{
    public class Branches
    {
        public int Id { get; set; } // رقم 
        public int CompanyId { get; set; } // رقم الشركة
        public int BRN_FLAG { get; set; } // حالة الفرع فعال غير فعال
        public string BRN_ADES { get; set; } // اسم الفرع بالعربي
        public string BRN_EDES { get; set; } // اسم الفرع بالانجليزى
        public string BRN_MAIL { get; set; } // البريد الالكترونى
        public string BRN_ADDR { get; set; } // العنوان
        public string BRN_FTEL { get; set; } // رقم التليفون الاول 
        public string BRN_STEL { get; set; } // رقم التليفون التانى 
        public string BRN_FAX { get; set; } // رقم الفاكس

    }
}