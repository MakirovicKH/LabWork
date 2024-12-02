
using Uniqlo.BL.Services.Abstractions;
using Uniqlo.DAL.Models;
using Uniqlo.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Uniqlo.BL.Services.Concretes
{
    public class SliderItemService : ISliderItemService
    {
        private readonly UniqloDbContext _context;


        public SliderItemService(UniqloDbContext context)
        {
            _context = context;
        }

        public async Task<List<SliderItem>> GetAllSliderItemsAsync()
        {
            List<SliderItem> sliderItems = await _context.SliderItems.ToListAsync();
            return sliderItems;
        }
    }
}
