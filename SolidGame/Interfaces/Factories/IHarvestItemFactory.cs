using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Factories {
	public interface IHarvestItemFactory {

		IHarvestItem CreateHarvestItem(IHarvest harvest);
	}
}
