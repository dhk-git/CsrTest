using Csr.Data;
using Csr.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace Csr.Pages.RequestBoard
{
    public partial class RequestList
    {
        public IEnumerable<CT_REQUEST> SelectedRequestModels { get; set; }
        
        [Inject]
        public CsrDbContext Ctx { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //return base.OnInitializedAsync();
            SelectedRequestModels = await Ctx.CT_REQUEST.ToListAsync();
        }
    }
}