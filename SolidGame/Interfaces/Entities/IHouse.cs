using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Entities {
	interface IHouse : IEntity {

		IList<IHarvestItem> ExtreactedHarvests { get; set; }
	}
}
