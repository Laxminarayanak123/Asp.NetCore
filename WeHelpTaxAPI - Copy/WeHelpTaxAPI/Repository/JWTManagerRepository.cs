using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using System.Linq;
using WeHelpTaxAPI.Models;
using JWTWebAuthentication.Repository;

namespace WeHelpTaxAPI.Repository
{
    public class JWTManagerRepository : taxPayerApplicationContext,IJWTManagerRepository
    {

        private readonly taxPayerApplicationContext _context;
        private readonly IConfiguration iconfiguration;

        private List<Users> l1;

        private taxPayerApplicationContext t1;
        public JWTManagerRepository(taxPayerApplicationContext tax, IConfiguration iconfiguration)
        {
            this.iconfiguration = iconfiguration;
            _context = tax;
            l1 = _context.Users.ToList();
        }







 
     

        public Tokens Authenticate(Users users)
        {
            

            // Else we generate JSON Web Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
             new Claim(ClaimTypes.Name, users.Email)
              }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new Tokens { Token = tokenHandler.WriteToken(token) };

        }
    }
}
