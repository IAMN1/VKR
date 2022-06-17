using CyberLoungeV2.Models.ReservationModels;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CyberLoungeV2.Services
{
    public class ReservationService
    {
        const string Url = "http://192.168.108.86:3000/api/place/"; // обратить внимание на слеш в конце!
        //const string Url = "http://192.168.31.92:3000/api/place/";

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        //Настройка клиента
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<Place>> GetPlace()
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonSerializer.Deserialize<IEnumerable<Place>>(result, options);
        }

        //отправляем забронированное место на сервер
        public async Task<string> SendReservation(List<Reservation> reserv)
        {
            //отправляем данные на сервер в БД
            HttpClient client = GetClient();

            //отправляем запрос на сервер
            var response = await client.PostAsync(Url + "reservation/",
                new StringContent(
                JsonSerializer.Serialize(reserv),
                Encoding.UTF8, "application/json"));
            if (response.StatusCode != HttpStatusCode.OK)
            {
                return "Ошибка, повторите попытку позже!";
            }
            else
            {
                return "Вы успешно забронировали место!";
            }
        }
    }
}
