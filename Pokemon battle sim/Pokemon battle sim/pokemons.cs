


namespace Pokemons
{ 
    class Pokemon
    {

        private string name;
        private string weakness;
        private string strength;

        public Pokemon (string name, string weakness, string strength)
        {
            this.name = name;
            this.weakness = weakness; 
            this.strength = strength;

        }

        public void battlecry(string name)
        {
            
          Console.WriteLine(""+name+ " screams: "+name+"'\n");
            
           
        }
        public string getName()
        {
            return name;
        }

    }
}