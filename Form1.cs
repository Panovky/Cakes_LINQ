using System;
using System.Linq;

namespace Cakes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Cake> cakes = new List<Cake>()
        {
            new Cake("Ореховый классический", "У ПАЛЫЧА", 750, 400, 480, true),
            new Cake("Медовик", "ФИЛИ-БЕЙКЕР", 600, 800, 390, true),
            new Cake("Три шоколада", "MIREL", 770, 900, 380, true),
            new Cake("Манго-маракуйя", "MARCELO DOLCI", 630, 450, 250, true),
            new Cake("Наполеон классический", "MIREL", 400, 550, 430, true),
            new Cake("Панчо", "ФИЛИ-БЕЙКЕР", 800, 1000, 240, true),
            new Cake("Красный бархат", "У ПАЛЫЧА", 700, 450, 410, true),
            new Cake("Тирамису", "MARCELO DOLCI", 630, 450, 300, true),
            new Cake("Прага", "MIREL", 330, 600, 420, true),
            new Cake("Карамельный", "DELISSE", 540, 500, 480, true)
        };

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            IOrderedEnumerable<Cake> formattedCakes;
            string info = "";

            if (radioButton1.Checked)
            {
                formattedCakes = cakes.OrderBy(c => c.Price);
            }
            else
            {
                formattedCakes = cakes.OrderByDescending(c => c.Price);
            }
           
            foreach (var cake in formattedCakes)
            {
                info += cake.get_info();
            }

            output.Text = info.Trim();
        }

        private void buttonShowCount_Click(object sender, EventArgs e)
        {
            var groups = cakes.GroupBy(c => c.Brand_name).Select(g => new { Name = g.Key, Count = g.Count() });
            string info = "";

            foreach(var group in groups)
            {
                info += $"{group.Name}: {group.Count} шт.\r\n\r\n";  
            }

            output.Text = info.Trim();
        }

        private void buttonSearchOne_Click(object sender, EventArgs e)
        {
            if (cakes.Any(c => c.Cake_name == cakeName1.Text))
            {
                Cake cake = cakes.Where(c => c.Cake_name == cakeName1.Text).Single();

                output.Text = cake.get_info();
            }
            else
            {
                output.Text = "Торта с таким названием не существует в базе данных.";
            } 
        }

        private void buttonFindCalories_Click(object sender, EventArgs e)
        {
            if (cakes.Any(c => c.Cake_name == cakeName2.Text))
            {
                output.Text = $"Пищевая ценность на 100 г для торта '{cakeName2.Text}' составляет {cakes.Where(c => c.Cake_name == cakeName2.Text).Select(c => c.Calories).Single()} ккал.";
            }
            else
            {
                output.Text = "Торта с таким названием не существует в базе данных.";
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            minCost.Text = $"{cakes.Min(c => c.Price)} руб.";
            maxCost.Text = $"{cakes.Max(c => c.Price)} руб."; 
            averageCost.Text = $"{cakes.Average(c => c.Price)}  руб.";
            sumCost.Text = $"{cakes.Sum(c => c.Price)} руб.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            cakeName1.Clear();
            cakeName2.Clear();
            minCost.Clear();
            maxCost.Clear();
            averageCost.Clear();
            sumCost.Clear();
            output.Clear();
        }
    }
}