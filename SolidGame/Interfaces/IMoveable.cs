using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces {
	interface IMoveable {

		int Speed { get; set; }

		void Move();
	}
}
