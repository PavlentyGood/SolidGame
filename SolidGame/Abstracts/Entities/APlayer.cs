using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using SolidGame.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidGame.Abstracts.Entities {
	abstract class APlayer : IPlayer {

		public int Health { get; set; }
		public int ExtractDamage { get; set; }
		public int Speed { get; set; }
		public bool IsInHouse { get; set; }
		public IGame Game { get; set; }
		public ILocation Location { get; set; }
		public IList<IHarvestItem> ExtractedHarvests { get; set; }
		public abstract IHarvestItemFactory HarvestItemFactory { get; set; }

		public abstract void Update();
		protected abstract ILocation GetNearPlantLocation();
		public abstract void Die();

		public IEnumerable<IHarvest> FindNearHarvestes() {
			return Game.Harvests
				.Where(b => b.Location.IsNear(Location));
		}

		public IHarvest PlantHarvest(IHarvestItem item) {
			return Game.HarvestFactory.CreateHarvest(item, GetNearPlantLocation());
		}

		public void ExtractHarvest(IHarvest harvest) {
			harvest.Health -= ExtractDamage;
			if (harvest.Health <= 0) {
				Game.Harvests.Remove(harvest);
				ExtractedHarvests.Add(HarvestItemFactory.CreateHarvestItem(harvest));
			}
		}

		public void PutHarvestToHouse(IHarvestItem item) {
			ExtractedHarvests.Remove(item);
			Game.House.ExtreactedHarvests.Add(item);
		}
	}
}
