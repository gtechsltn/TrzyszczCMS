﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace TrzyszczCMS.Client.Views.Administering.Edit
{
    public partial class PageEditor : IDisposable
    {
        #region Init
        protected override void OnInitialized()
        {
            base.OnInitialized();
            this.ViewModel.PropertyChanged += new PropertyChangedEventHandler(
                async (s, e) => await this.InvokeAsync(() => this.StateHasChanged())
            );
            this.ViewModel.OnExitingView = new Action(() => this.NavigationManager.NavigateTo("/manage/pages"));
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                await this.ViewModel.LoadDataFromDeposit();
            }
        }
        #endregion

        #region Dispose
        public void Dispose() => this.ViewModel?.Dispose();
        #endregion
    }
}
