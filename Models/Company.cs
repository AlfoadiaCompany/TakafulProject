namespace TakafulApi.Models
{
    public class Company
    {
        public int Id { get; set; } // رقم الشركة
        public string CMP_ADES { get; set; } // اسم الشركة بالعربى
        public string CMP_EDES { get; set; }// اسم الشركة بالانجليزى
        public string CMP_MAIL { get; set; } //البريد الالكترونى
        public string CMP_ADDR { get; set; }// العنوان
        public string CMP_FTEL { get; set; } // رقم التليفون الاول
        public string CMP_STEL { get; set; } // رقم التليفون التانى 
        public string CMP_FAX { get; set; } // الفاكس
        public string CMP_PBOX { get; set; } // رقم صندوق بريد
        public string CMP_LOGO { get; set; } // لوجو الشركة

    }
}