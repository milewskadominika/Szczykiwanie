using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Szczykiwanie.Interfaces;
using Szczykiwanie.Models;

namespace Szczykiwanie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonService _personService;
        public IndexModel(ILogger<IndexModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }
        public IQueryable<Person> Records { get; set; }


        

        public void OnGet()
        {
            Records = _personService.GetActivePeople();
        }
    }
}