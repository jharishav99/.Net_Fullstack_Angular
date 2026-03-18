namespace WebApplication2.Controllers
{
    public class CategoriesController
    {
        private readonly FoodDeliveryContext _context;
        public CategoriesController(FoodDeliveryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = _context.categories.ToList();
            return View(categories);
        }
}
