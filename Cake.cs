public class Cake
{
    private string cake_name;
    private string brand_name;
    private int weight;
    private int price;
    private int calories;
    private bool gluten;

    public Cake(string cake_name, string brand_name, int weight, int price, int calories, bool gluten)
    {
        this.cake_name = cake_name;
        this.brand_name = brand_name;
        this.weight = weight;
        this.price = price;
        this.calories = calories;
        this.gluten = gluten;
    }

    public string Cake_name 
    {
        get { return cake_name; }
    }

    public string Brand_name
    {
        get { return brand_name; }
    }

    public int Weight
    {
        get { return weight; }
    }

    public int Price
    {
        get { return price; }
    }

    public int Calories
    {
        get { return calories; }
    }

    public bool Gluten
    {
        get { return gluten; }
    }

    public string get_info()
    {
        return $"Наименование: {this.cake_name}\r\n" + $"Бренд: {this.brand_name}\r\n" + $"Вес: {this.weight} г\r\n" + 
            $"Цена: {this.price} руб.\r\n" + $"Пищевая ценность на 100 г: {this.calories} ккал\r\n" +
            $"Глютен: {(this.gluten ? "содержится" : "не содержится")}\r\n\r\n";
    }
}

