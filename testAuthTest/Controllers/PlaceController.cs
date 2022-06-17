using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerForAppV1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerForAppV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : Controller
    {
        //БД
        ApplicationContext db;
        public PlaceController(ApplicationContext context)
        {
            db = context;
        }

        //Получение данных о местах в клубе
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Place>>> Get()
        {
            return await db.Places.ToListAsync();
        }

        // Метод бронирования
        [HttpPost("reservation")]
        public async Task<ActionResult<string>> Reservation(List<Reservation> reserv)
        {
            string result="";
            foreach (Reservation reservat in reserv)
            {
                Place place = await db.Places.FirstOrDefaultAsync(p => p.Id == reservat.PlaceId);
                if (place != null)
                {
                    //Если место не забронировано и не занято,
                    //То бронируем его
                    if (place.IsBusy != -1 && place.IsBusy != 2)
                    {
                        Reservation localrecord = await db.Reservations.FirstOrDefaultAsync(r => r.Id == reservat.Id);
                        if (localrecord != null)
                        {
                            return BadRequest("Запись уже существует!");
                        }
                        else
                        {
                            //Помещаем запись о бронировании
                            db.Reservations.Add(reservat);
                            await db.SaveChangesAsync();

                            //Обновили статус места
                            place.IsBusy = reservat.IsBusy;
                            db.Places.Update(place);
                            await db.SaveChangesAsync();
                            result = "Бронирование успешно!";
                        }
                    }
                    else
                    {
                        result = "Ошибка";
                    }
                }
                else
                {
                    result = "Ошибка";
                }
            }
            switch (result)
            {
                case "Бронирование успешно!":
                    return Ok("Бронирование успешно!");
                case "Ошибка":
                    return BadRequest("Бронирование успешно!");
            }
            return null;
        }
    }
}
