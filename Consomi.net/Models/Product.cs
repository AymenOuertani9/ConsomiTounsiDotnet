using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Product
    {
        [JsonProperty("idProduct")]
        public int IdProduct { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sellPrice")]
        public float SellPrice { get; set; }

        [JsonProperty("newProduct")]
        public bool NewProduct { get; set; }

        [JsonProperty("barCode")]
        public string BarCode { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("mostViewed")]
        public int MostViewed { get; set; }

        [JsonProperty("weigth")]
        public int Weigth { get; set; }

        public virtual ICollection<LigneComand> Lignescmd { get; set; }
        public virtual ICollection<Promotion> Promotions { get; set; }
        public virtual Category Category { get; set; }
        public virtual Radius Radius { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }

        public Product()
        {
        }

        //    public Product(int idProduct, string productName, string picture, string description, float sellPrice, bool newProduct, string barCode, DateTime createdAt, int mostViewed, bool promotionEtat, int guranteePeriod, List<LigneComand> lignescmd, List<Promotion> promotions, Category category, Radius radius, List<Stock> stocks, List<Evaluation> evaluations)
        //    {
        //        IdProduct = idProduct;
        //        ProductName = productName;
        //        Picture = picture;
        //        Description = description;
        //        SellPrice = sellPrice;
        //        NewProduct = newProduct;
        //        BarCode = barCode;
        //        CreatedAt = createdAt;
        //        MostViewed = mostViewed;
        //        PromotionEtat = promotionEtat;
        //        GuranteePeriod = guranteePeriod;
        //        Lignescmd = lignescmd;
        //        Promotions = promotions;
        //        Category = category;
        //        Radius = radius;
        //        Stocks = stocks;
        //        Evaluations = evaluations;
        //    }
        //}
    }
}