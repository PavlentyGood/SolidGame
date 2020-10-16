using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Abstracts.Entities {
	abstract class AHarvest : IHarvest {

		public int Age { get; set; }
		public int Health { get; set; }
		public int Value { get; set; }
		public int GrowValue { get; set; }
		public int MaxAge { get; set; }
		public IGame Game { get; set; }
		public ILocation Location { get; set; }

		public abstract void Update();
		public abstract void Die();

		public virtual void Grow() {
			if (Age < MaxAge) {
				Age += GrowValue;
			}
		}
	}
}
