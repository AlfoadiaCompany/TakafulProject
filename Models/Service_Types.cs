namespace TakafulApi.Models
{
    public class Service_Types
    {
        public int Id { get; set; } // رقم الخدمة
        public string Service_Type_AName { get; set; } // وصف الخدمة بالعربي
        public string Service_Type_EName { get; set; } // وصف الخدمة بالانجليزي
        public int Service_Type_Amounts { get; set; } // قيمة الخدمة

    }
}