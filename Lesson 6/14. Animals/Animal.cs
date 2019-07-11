namespace Animals
{
    public class Animal
    {
        private string name;
        private string favouriteFood;
        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return string.Empty;
        }

        public string Name
        {
            get => this.name; 
            private set => this.name = value;
        }
        public string FavouriteFood
        {
            get => this.favouriteFood; 
            private set => this.favouriteFood = value;
        }
    }
}