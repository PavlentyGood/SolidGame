using SolidGame.Interfaces.Entities;
using SolidGame.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces {
	public interface IGame {

		IPlayerFactory PlayerFactory { get; set; }
		IHouseFactory HouseFactory { get; set; }
		IEnemyFactory EnemyFactory { get; set; }
		IHarvestFactory HarvestFactory { get; set; }

		IPlayer Player { get; set; }
		IHouse House { get; set; }

		IList<IHarvest> Harvests { get; set; }
		IList<IEnemy> Enemies { get; set; }

		void StartGame();
		void UpdateGame();
		void FinishGame();
	}
}
