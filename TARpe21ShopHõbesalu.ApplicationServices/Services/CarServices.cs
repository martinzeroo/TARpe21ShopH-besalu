using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpe21ShopHõbesalu.ApplicationServices.Services
{
    public class CarDetailsDeleteViewModel
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsUsed { get; set; }
        public List<IFormFile> Files { get; set; }
        public List<FileToApiViewModel> FileToApiViewModels { get; set; } = new List<FileToApiViewModel>();
        public bool isDeleting { get; set; }

        //db only
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
