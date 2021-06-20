namespace TakafulApi.Models
{
    public class Suppliers_Branch
    {
        public int Id { get; set; } // رقم مزود الخدمة  
        public int SuppliersId { get; set; } // رقم الفرع
        public string Suppliers_Branch_Aname { get; set;} // اسم الفرع بالعربى
        public string Suppliers_Branch_Ename { get; set; } // اسم الفرع انجليزي
        public string Suppliers_Phone_number { get; set; } // رقم التليفون 
        public string Suppliers_Email { get; set; } // البريد الالكترونى
        public int CountryId { get; set; } // رقم الدولة
        public int CityId { get; set; } // رقم المدينة 
        public string Suppliers_Branch_Address { get; set; } // عنوان الفرع
        public string Suppliers_Personal_Contact { get; set; } // اسم الشخص المسئول
         public string Suppliers_Personal_Contact_Number { get; set; } // رقم الشخص المسئول عن الفرع



        

    }
}