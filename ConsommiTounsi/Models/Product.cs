using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public float SellPrice { get; set; }
        public bool NewProduct { get; set; }
        public string BarCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public int MostViewed { get; set; }
        public bool PromotionEtat { get; set; }
        public int GuranteePeriod { get; set; }

        public virtual List<LigneComand> Lignescmd { get; set; }
        public virtual List<Promotion> Promotions { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Stock> Stocks { get; set; }
        public virtual List<Evaluation> Evaluations { get; set; }

        public Product()
        {
        }

        public Product(int idProduct, string productName, string picture, string description, float sellPrice, bool newProduct, string barCode, DateTime createdAt, int mostViewed, bool promotionEtat, int guranteePeriod, List<LigneComand> lignescmd, List<Promotion> promotions, Category category, List<Stock> stocks, List<Evaluation> evaluations)
        {
            IdProduct = idProduct;
            ProductName = productName;
            Picture = picture;
            Description = description;
            SellPrice = sellPrice;
            NewProduct = newProduct;
            BarCode = barCode;
            CreatedAt = createdAt;
            MostViewed = mostViewed;
            PromotionEtat = promotionEtat;
            GuranteePeriod = guranteePeriod;
            Lignescmd = lignescmd;
            Promotions = promotions;
            Category = category;
            Stocks = stocks;
            Evaluations = evaluations;
        }
    }
}