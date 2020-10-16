using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Abstracts.Entities {
	public abstract class AHouse : IHouse {

		public abstract IList<IHarvestItem> ExtreactedHarvests { get; set; }
		public abstract IGame Game { get; set; }
		public abstract ILocation Location { get; set; }

		public abstract void Update();
	}
}
