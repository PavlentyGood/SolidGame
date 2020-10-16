using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using SolidGame.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Abstracts {
	abstract class AGame : IGame {

		public IPlayerFactory PlayerFactory { get; set; }
		public IHouseFactory HouseFactory { get; set; }
		public IEnemyFactory EnemyFactory { get; set; }
		public IHarvestFactory HarvestFactory { get; set; }

		public IPlayer Player { get; set; }
		public IHouse House { get; set; }
		public IList<IHarvest> Harvests { get; set; }
		public IList<IEnemy> Enemies { get; set; }

		public ILocation WorldSize { get; set; }
		public int StartHarvestCount { get; set; }

		public AGame(IPlayerFactory playerFactory, IHouseFactory houseFactory, IEnemyFactory enemyFactory, IHarvestFactory harvestFactory) {
			PlayerFactory = playerFactory;
			HouseFactory = houseFactory;
			EnemyFactory = enemyFactory;
			HarvestFactory = harvestFactory;
		}

		public abstract void FinishGame();

		public void StartGame() {
			House = HouseFactory.CreateHouse();
			Player = PlayerFactory.CreatePlayer(House);

			var i = 0;
			while (i++ < StartHarvestCount) {
				Harvests.Add(HarvestFactory.CreateHarvest(this));
			}
		}

		protected void SpawnEnemies() {
			Enemies.Add(EnemyFactory.CreateEnemy(this));
		}
		
		protected void UpdatePlayer() {
			Player.Move();

			if (Player.Health <= 0) {
				FinishGame();
			}
		}

		protected void UpdateEnemies() {
			SpawnEnemies();

			foreach (var e in Enemies) {
				e.Update();
			}
		}

		protected void UpdateHarvests() {
			foreach (var h in Harvests) {
				h.Grow();
			}
		}

		public void UpdateGame() {
			UpdatePlayer();
			UpdateEnemies();
			UpdateHarvests();
		}
	}
}
