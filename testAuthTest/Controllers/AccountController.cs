using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerForAppV1.Models;
using System.Threading.Tasks;

namespace ServerForAppV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        //БД
        ApplicationContext db;
        public AccountController(ApplicationContext context)
        {
            db = context;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<string>> AddNewUser(User user)
        {
                                      
            if (user == null)
            {
                return NotFound("От Сервера: Пользователь не найден"); ;
            }
            else
            {
                User localUser = await db.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
                if (localUser != null)
                {
                    return BadRequest("От Сервера: Пользователь с таким Логином уже существует!");
                }
                else
                {
                    //Добвляем пользователя в бд
                    db.Users.Add(user);
                    await db.SaveChangesAsync();
                    return Ok();
                }
            }
        }

        [HttpPost("signin")]
        public async Task<ActionResult<string>> SignIn(User usr)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Login == usr.Login);
            if (user != null)
            {
                if (usr.Login == user.Login && usr.Password == user.Password)
                {
                    return Ok("Авторизация прошла успешно!");
                }
                else
                {
                    return BadRequest("Неверное имя пользователя или пароль");
                }
            }
            else
            {
                return NotFound("От Сервера: Пользователь не найден");
            }
        }

        [HttpPost("userinfo/{Login}")]
        public async Task<ActionResult<User>> UserInfo(string Login)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Login == Login);
            user.Password = "";

            return new ObjectResult(user);
        }

        [HttpPut]
        public async Task<ActionResult<string>> ChangePassword(User usr)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Login == usr.Login);

            if(user == null)
            {
                return BadRequest();
            }
            else
            {
                user.Password = usr.Password;
                db.Users.Update(user);
                db.SaveChanges();
                return Ok();
            }
        }
    }
}
