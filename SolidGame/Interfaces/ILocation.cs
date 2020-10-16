using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces {
	public interface ILocation {

		bool IsNear(ILocation other);
	}
}
