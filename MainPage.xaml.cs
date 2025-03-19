using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace catcart
{
    public partial class CatCart : ContentPage
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public CatCart()
        {
            InitializeComponent();
            LoadCats();
        }

        private async void LoadCats()
        {
            List<Cat> cats = await _dbHelper.GetCatsAsync();
             
        }

       
        private void RagdollFrame_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Order-in mo na!<3", "Ragdoll Cat - Php 13,000", "OK");
        }

        private void MaineCoonFrame_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Order-in mo na!<3", "Maine Coon Cat - Php 22,000", "OK");
        }

        private void SiberianFrame_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Order-in mo na!<3", "Siberian Cat - Php 27,000", "OK");
        }

        private void BombayFrame_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Order-in mo na!<3", "Bombay Cat - Php 13,000", "OK");
        }
    }
}
