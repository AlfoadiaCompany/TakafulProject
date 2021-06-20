namespace TakafulApi.Models
{
    public class Suppliers
    {
        public int Id { get; set; } //  رقم مزود الخدمة  
        public string Suppliers_Aname { get; set; }  // اسم مزود الخدمة باللغه العربية
        public string Suppliers_Ename { get; set; } // اسم مزود الخدمة باللغه الانجليزية
        public string Suppliers_Commercial_Register_No { get; set; } // رقم السجل التجارى
        public string Suppliers_Commercial_Register_Name { get; set; } // الاسم بالسجل التجارى
        public string Suppliers_Phone_number { get; set; } // رقم تليفون مزود الخدمة
        public string Suppliers_Email { get; set; } // البريد الالكترونى
        public int Suppliers_DescriptionId { get; set; } // رقم وصف مزود الخدمة
        public int CountryId { get; set; } // رقم الدولة
        public int CityId { get; set; } //  رقم المدينة 
        public string Suppliers_Address { get; set; } // عنوان مزود الخدمة
        public string Suppliers_Personal_Contact { get; set; } // اسم الشخص المسئول
        public string Suppliers_Personal_Contact_Number { get; set; } // رقم الشخص المسئول


    }
}