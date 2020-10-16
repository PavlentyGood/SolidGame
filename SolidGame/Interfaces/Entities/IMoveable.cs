using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Entities {
	interface IMoveable : IEntity {

		int Speed { get; set; }

		void Move();
	}
}
