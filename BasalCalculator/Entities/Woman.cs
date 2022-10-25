namespace BasalCalculator.Entities
{
    public class Woman
    {
        public int age { get; set; }
        public double weight { get; set; }
        public int height { get; set; }

        public Woman(int age, double weight, int height)
        {
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public int Calculator(int age, double weight, int height)
        {
            return (int)(665 + (9.6 * weight) + (1.8 * height) - (4.7 - age));
        }

    }
}
