namespace TakafulApi.Models
{
    public class SuppliersContracts
    {
        public int Id { get; set; } // رقم
        public int SuppliersId { get; set; } // رقم مزود الخدمة
        public string Contracts_Date { get; set; } // تاريخ العقد
          public string Contracts_Code { get; set; } // الرقم المرجعى للعقد 
          public int ContractTypesId { get; set; } // نوع العقد
          public int Contracts_Status { get; set; } // حالة العقد
          public int PaymentMethodsId { get; set; } // رقم طريقة الدفع
          public int Contracts_Amount  { get; set; } // قيمة العقد
          public int Contracts_Commission { get; set; } // عمولة العقد
          public int Contracts_Discount { get; set; } // قيمة خصم العقد
          public string Contracts_Photo { get; set; } // صورة العقد

    


    }
}