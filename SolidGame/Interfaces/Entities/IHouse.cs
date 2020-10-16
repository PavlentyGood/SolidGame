using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Entities {
	public interface IHouse : IEntity {

		IList<IHarvestItem> ExtreactedHarvests { get; set; }
	}
}
