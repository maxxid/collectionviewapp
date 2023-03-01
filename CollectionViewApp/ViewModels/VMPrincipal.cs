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
                {
                    Name = "Puchini nini",
                    Description = "Perro Marron",
                    HasOffer = false,
                    Image = "dog.png",
                    Price = 100,
                    OfferPrice = 10
                },
                new Product
                {
                    Name = "Misi pisi",
                    Description = "Gato Smoking",
                    HasOffer = false,
                    Image = "cat.png",
                    Price = 90,
                    OfferPrice = 5
                },
                new Product
                {
                    Name = "Toby tobias",
                    Description = "Perro Negro",
                    HasOffer = true,
                    Image = "dog2.png",
                    Price = 80,
                    OfferPrice = 30
                },
                new Product
                {
                    Name = "Cone Conejardo",
                    Description = "Conejo Blanco",
                    HasOffer = false,
                    Image = "bunny.png",
                    Price = 100,
                    OfferPrice = 50
                },
                new Product
                {
                    Name = "Puchini nini",
                    Description = "Perro Marron",
                    HasOffer = false,
                    Image = "dog.png",
                    Price = 100,
                    OfferPrice = 10
                },
                new Product
                {
                    Name = "Misi pisi",
                    Description = "Gato Smoking",
                    HasOffer = false,
                    Image = "cat.png",
                    Price = 90,
                    OfferPrice = 5
                },
                new Product
                {
                    Name = "Toby tobias",
                    Description = "Perro Negro",
                    HasOffer = true,
                    Image = "dog2.png",
                    Price = 80,
                    OfferPrice = 30
                },
                new Product
                {
                    Name = "Cone Conejardo",
                    Description = "Conejo Blanco",
                    HasOffer = false,
                    Image = "bunny.png",
                    Price = 100,
                    OfferPrice = 50
                },
                new Product
                {
                    Name = "Puchini nini",
                    Description = "Perro Marron",
                    HasOffer = false,
                    Image = "dog.png",
                    Price = 100,
                    OfferPrice = 10
                },
                new Product
                {
                    Name = "Misi pisi",
                    Description = "Gato Smoking",
                    HasOffer = false,
                    Image = "cat.png",
                    Price = 90,
                    OfferPrice = 5
                },
                new Product
                {
                    Name = "Toby tobias",
                    Description = "Perro Negro",
                    HasOffer = true,
                    Image = "dog2.png",
                    Price = 80,
                    OfferPrice = 30
                },
                new Product
                {
                    Name = "Cone Conejardo",
                    Description = "Conejo Blanco",
                    HasOffer = false,
                    Image = "bunny.png",
                    Price = 100,
                    OfferPrice = 50
                }
            };
            
        }
    }
}
