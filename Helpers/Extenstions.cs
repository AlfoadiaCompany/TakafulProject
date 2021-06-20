using System;

using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace TakafulApi.Helpers
{

    public static class Extenstions
    {

        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");

        }

        // public static void AddPagination(this HttpResponse response,
        // int Id,
        // int UserTypeId,
        //  string UserName,
        //  string Mobile,
        //  string Email,
        //  int Age,
        //  string Gender,
        //  string Userstatus,
        // string PhotoUrl,
        // int countryID,
        // string CountryName,
        // int CityID,
        // string CityName,
        // int ViewsCount,
        //  Boolean approval,
        //  int ConfirmPayment,
        //  int StarRate)
        // {
        //     var paginationHeader = new PaginationUser(

        //       Id,
        //  UserTypeId,
        //   UserName,
        //   Mobile,
        //   Email,
        //   Age,
        //   Gender,
        //   Userstatus,
        //  PhotoUrl,
        //  countryID,
        //  CountryName,
        //  CityID,
        //  CityName,
    
        //  ViewsCount,
        //   approval,
        //   ConfirmPayment,
        //   StarRate
        //     );
        //    var camelCaseFormatter= new JsonSerializerSettings();
        //    camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
        //    response.Headers.Add("Pagination",JsonConvert.SerializeObject(paginationHeader,camelCaseFormatter));
        //    response.Headers.Add("Access-Control-Expose-Headers","Pagination");

    //    }

        public static int CalculateAge(this DateTime datetime)
        {
            var age = DateTime.Today.Year - datetime.Year;
            if (datetime.AddYears(age) > DateTime.Today) age--;
            return age;
        }

        


        //     var result =  .GroupBy(o => o.membername)
        //                .Select(g => new { membername = g.Key, total = g.Sum(i => i.cost) });

        // foreach (var group in result)
        // {
        //     Console.WriteLine("Membername = {0} Totalcost={1}", group.membername, group.total);
        // }
    }

}