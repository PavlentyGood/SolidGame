using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Entities {
	interface IEntity {

		IGame Game { get; set; }
		ILocation Location { get; set; }
	}
}
