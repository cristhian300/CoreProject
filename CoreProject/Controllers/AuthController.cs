using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using transport.Configuration.Response;

namespace CoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IConfiguration _IConfiguration;

        private JWTConfig _JJWTConfig;
        public AuthController(IConfiguration IConfiguration, IOptions<JWTConfig> JWTConfig)
        {
            _IConfiguration = IConfiguration;
            _JJWTConfig = JWTConfig.Value;
        }
       

        // POST: api/Auth
        [HttpPost]
        public IActionResult Post()
        {

            //byte[] claveEnByte = Encoding.UTF8.GetBytes(_IConfiguration["JWTConfig:clave"]);
            byte[] claveEnByte = Encoding.UTF8.GetBytes(_JJWTConfig.JWTclave);
            
            SymmetricSecurityKey key = new SymmetricSecurityKey(claveEnByte);

            //Generando el algoritmo
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: "Magic", audience: "infinito", 
                claims: new[] { new Claim("whatever","cristhian")},
                expires:DateTime.Now.AddMinutes(15)
                ,
                signingCredentials: cred
                );

            string token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(token);
        }

       
    }
}
