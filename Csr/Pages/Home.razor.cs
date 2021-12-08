using System;
using System.Threading.Tasks;
using Csr.Components.Editor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Csr.Pages
{
    public partial class Home
    {

        private BlazingSummerJsInterop _blazingSummerJsInterop;
        private bool _edit = true;

        [Parameter] public string Content { get; set; }

        [Parameter] public EventCallback<string> ContentChanged { get; set; }

        private string NoteId { get; } = $"BlazingSummerNote{new Random().Next(0, 1000000).ToString()}";
        
        private void EditorUpdate(object sender, string editorText)
        {
            Content = editorText;
            ContentChanged.InvokeAsync(editorText);
        }

        protected override async Task<Task> OnInitializedAsync()
        {
            //_blazingSummerJsInterop = new BlazingSummerJsInterop(Js, NoteId, EditorUpdate);
            //await _blazingSummerJsInterop.Init();
            return base.OnInitializedAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            //_blazingSummerJsInterop = new BlazingSummerJsInterop(Js, NoteId, EditorUpdate);
            //await _blazingSummerJsInterop.Init();
            //return base.OnAfterRenderAsync(firstRender);

            


        }

        private async Task Save()
        {
            _edit = false;
            await _blazingSummerJsInterop.Save();
            StateHasChanged();
        }

        private async Task Edit()
        {
            _edit = true;
            var response = await _blazingSummerJsInterop.Edit(Content);
            StateHasChanged();
        }

    }
}
