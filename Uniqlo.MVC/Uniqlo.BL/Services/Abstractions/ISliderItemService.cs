using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniqlo.DAL.Models;

namespace Uniqlo.BL.Services.Abstractions
{
   public interface ISliderItemService
    {
        public Task<List<SliderItem>> GetAllSliderItemsAsync();
    }
}
