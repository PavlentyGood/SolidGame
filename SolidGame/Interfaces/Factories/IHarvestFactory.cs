using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Factories {
	public interface IHarvestFactory {

		IHarvest CreateHarvest(IGame game);
		IHarvest CreateHarvest(IHarvestItem item, ILocation location);
	}
}
