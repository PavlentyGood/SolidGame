using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Entities {
	public interface IHarvest : IEntity, IKillable {

		int Age { get; set; }
		int MaxAge { get; set; }
		int Value { get; set; }
		int GrowValue { get; set; }

		void Grow();
	}
}
