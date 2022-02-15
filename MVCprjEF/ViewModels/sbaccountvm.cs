
using Microsoft.AspNetCore.Http;

namespace MVCprjEF.ViewModels
{
   public class sbaccountvm
    {
        public int Accno { get; set; }
        public decimal? Bal { get; set; }
        public string Name { get; set; }
        public IFormFile Address { get; set; }

    }
}