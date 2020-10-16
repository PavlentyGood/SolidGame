using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces {
	interface ILocation {

		bool IsNear(ILocation other);
	}
}
