using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Factories {
	public interface IPlayerFactory {

		IPlayer CreatePlayer(IHouse house);
	}
}
