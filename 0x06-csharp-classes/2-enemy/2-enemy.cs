using System;

namespace Enemies
{
    /// <summary> Represents a Zombie class </summary>
    class Zombie
    {
         /// <summary> Represents the health a zombie posses </summary>
        public int health;

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> 
        /// class and takes <paramref name="value"/></summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
    }
}

