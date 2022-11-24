using System;

namespace AuthServer.Core.Dtos
{
    public class ClientTokenDto
    {
        public string AccesToken { get; set; }
        public DateTime AccesTokenExpiration { get; set; }
    }
}
