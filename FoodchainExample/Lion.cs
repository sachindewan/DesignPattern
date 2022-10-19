using System;

namespace FoodchainExample
{
	/// <summary>
	/// The concrete product class for carnivores in Africa.
	/// </summary>
	class Lion : ICarnivore
	{
		/// <summary>
		/// Eat a herbivore.
		/// </summary>
		/// <param name="herbivore">The herbivore to eat.</param>
		public  void Eat (IHerbivore herbivore)
		{
			Console.WriteLine ("{0} eats {1}", this.GetType ().Name, herbivore.GetType ().Name);
		}
	}
}
