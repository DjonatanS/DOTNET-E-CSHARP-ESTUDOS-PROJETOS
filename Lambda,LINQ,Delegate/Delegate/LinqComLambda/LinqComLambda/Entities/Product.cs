using System.Globalization;

namespace LinqComLambda.Entities
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }


        public override string ToString()
        {
            return "ID: " + ID +
                ", " +
                "Nome: " + Name +
                ", " +
                "Preço: " + Price.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                "Tier:" + Category.Tier;
        }
    }
}
