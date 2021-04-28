using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private ILoginRepository _loginRepository { get; set; }

        public LoginController()
        {

            _loginRepository = new LoginRepository();

        }

        public IActionResult Autenth(string email, string senha)
        {

            Usuario usuarioBuscado = _loginRepository.Autenticacao(email, senha);

            var claims = new[]
            {

                new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email)
                ,new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString())
                ,new Claim( ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString())

            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("chave-de-segurança-autenticação"));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(

                issuer: "senai.hroads.webApi",
                audience: "senai.hroads.webApi",
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: cred

             );

            return Ok( new { token = new JwtSecurityTokenHandler().WriteToken(token) } );
        }

    }
}
