using SolidGame.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Entities {
	interface IPlayer : IEntity, IMoveable, IKillable {

		int ExtractDamage { get; set; }
		bool IsInHouse { get; set; }
		IList<IHarvestItem> ExtractedHarvests { get; set; }
		IHarvestItemFactory HarvestItemFactory { get; set; }

		IHarvest PlantHarvest(IHarvestItem item);
		void ExtractHarvest(IHarvest harvest);
		void PutHarvestToHouse(IHarvestItem item);
	}
}
