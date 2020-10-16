using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Factories {
	interface IHouseFactory {

		IHouse CreateHouse();
	}
}
