using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoreAPIIntro_0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {

        //HttpStatusCodes
        //100 ile baslayan kodlar => Information
        //200 ile baslayan kodlar => Basarılı
        //300 ile baslayan kodlar => Redirection
        //400 ile baslayan kodlar => Client Error
        //500 ile baslayan kodlar => Server errors



        //Get => Kullanıcının yeni bir istegi(Request mevcut durumda alınan response(varsa) ondan bagımsız bir tarzdadır.Taze bir haldedir)

        //Post => Gelen Response'un tekrar server'a gönderilmesidir...API'da sadece Creation icin kullanılması saglıklı olan HTTP request tipidir

        //Put => API'da Update işlemleri icin kullanacagınız HTTP request tipidir...

        //Delete => API'da Delete işlemleri icin kullanacagımız HTTP request tipidir...







        //MVC'de eger bir Action'in üzerine HTTP request yöntemini yazmazsanız MVC o Action'i HttpGet yönteminde calısır algılar...Ama API'da böyle bir şey yoktur...API'da her Action'in üzerine onun hangi HTTP yönteminde calısacagını belirten Attribute'u yazmak zorundasınız.


        public ValueController()
        {

        }

        static List<string> cities = new List<string>
        {
            "İstanbul","İzmir","Eskişehir","Ankara","Adana"
        };

        [HttpGet]
        public IActionResult GetCities()
        {
           
            return Ok(cities);
        }

        [HttpGet("GetCity")]
        public IActionResult GetCity(int index)
        {
            return Ok(cities[index]);
        }

        [HttpPost]
        public IActionResult AddCity(string item)
        {
            cities.Add(item);
            return Ok("Sehir eklendi");
        }

        [HttpPut]
        public IActionResult UpdateCity(int index,string newValue)
        {
            cities[index] = newValue;
            return Ok("Sehir güncellendi");
        }

        [HttpDelete]
        public IActionResult DeleteCity(int index) 
        {
            cities.Remove(cities[index]);
            return Ok("Sehir silindi.Ece yüzünden depresyondayım");
        }


    }
}
