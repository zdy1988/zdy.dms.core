﻿using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace ZDY.DMS.AspNetCore.Auth
{
    public static class UserAuthorization
    {
        public static Guid MysteriousCode
        {
            get
            {
                return Guid.Parse("00000000-0000-0000-0000-000000000001");
            }
        }

        public static Guid GetMysteriousCode(this HttpContext context)
        {
            return MysteriousCode;
        }

        public static UserIdentity GetUserIdentity(this HttpContext context)
        {
            if (context.User.Identity.IsAuthenticated)
            {
                var claimsIdentity = context.User.Identity as ClaimsIdentity;

                if (claimsIdentity.Claims.Any())
                {
                    var id = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "Id").Value;
                    var name = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "Name").Value;
                    var companyId = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "CompanyId").Value;

                    return new UserIdentity
                    {
                        Id = Guid.Parse(id),
                        Name = name,
                        CompanyId = Guid.Parse(companyId),
                        IsAdministrator = companyId == MysteriousCode.ToString()
                    };
                }
            }

            return null;
        }

        public static bool TryGetUserId(this HttpContext context, out Guid userId)
        {
            try
            {
                var claimsIdentity = context.User.Identity as ClaimsIdentity;
                var id = claimsIdentity.Claims.FirstOrDefault(c => c.Type == "Id").Value;
                userId = Guid.Parse(id);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GenerateToken(Guid UserId, string Name, Guid CompanyId, DateTime expires)
        {
            var handler = new JwtSecurityTokenHandler();

            ClaimsIdentity identity = new ClaimsIdentity(
                new[] {
                    new Claim("Id", UserId.ToString()),
                    new Claim("Name", Name),
                    new Claim("CompanyId", CompanyId.ToString())
                }
            );

            if (CompanyId == MysteriousCode)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String));
            }

            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = SecurityTokenOptions.Issuer,
                Audience = SecurityTokenOptions.Audience,
                SigningCredentials = SecurityTokenOptions.SigningCredentials,
                Subject = identity,
                Expires = expires
            });

            return handler.WriteToken(securityToken);
        }
    }
}
