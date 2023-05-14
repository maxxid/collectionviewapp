using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CollectionViewApp.Models;

namespace CollectionViewApp.ViewModels
{
    public class VMPrincipal
    {
        public ObservableCollection<Product> Products { get; set; }

        public VMPrincipal()
        {
            InitProducts();
        }



        private void InitProducts()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                { Nombre = "Maximiliano", Apellido = "Araya", Imagen = "alumiconwhite.png" },
                new Product
                { Nombre = "Natalia", Apellido = "Peñaranda", Imagen = "alumiconwhite.png" },
                new Product
                { Nombre = "Nay", Apellido = "Tolay", Imagen = "alumiconwhite.png" },
                new Product
                {Nombre = "Candela", Apellido = "Cancelo", Imagen = "alumiconwhite.png"},
                new Product
                {Nombre = "Antonio", Apellido = "Perez", Imagen = "alumiconwhite.png"},
                new Product
                {Nombre = "Keila", Apellido = "Jaimez", Imagen = "alumiconwhite.png"},
                new Product
                { Nombre = "Leonel", Apellido = "Cuccitini", Imagen = "alumiconwhite.png" },
                new Product
                {Nombre = "Angel", Apellido = "Robles", Imagen = "alumiconwhite.png" },
                new Product
                {Nombre = "Lautaro", Apellido = "Villa", Imagen = "alumiconwhite.png"},
                new Product
                {Nombre = "Isabella", Apellido = "Luraschi", Imagen = "alumiconwhite.png"},
                new Product
                {Nombre = "Tobias", Apellido = "Vargas", Imagen = "alumiconwhite.png"},
                new Product
                {Nombre = "Emir", Apellido = "Perroni", Imagen = "alumiconwhite.png"}
            };
            
        }
    }
}
