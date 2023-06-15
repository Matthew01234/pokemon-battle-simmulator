


namespace Pokemons
{ 
    abstract class Pokemon
    {

        private string name;
        private string strength;
        private string weakness;
        

        public Pokemon (string name, string strength,string weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness; 
            

        }

        public abstract void battlecry(string name);

        public string getName()
        {
            return name;
        }

    }
}