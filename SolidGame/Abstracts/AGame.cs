using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using SolidGame.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Abstracts {
	public abstract class AGame : IGame {

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

		public abstract void FinishGame();
		protected abstract void CreateStartHarvests();
		protected abstract void SpawnEnemies();

		public virtual void StartGame() {
			House = HouseFactory.CreateHouse();
			Player = PlayerFactory.CreatePlayer(House);
			
			CreateStartHarvests();
		}
		
		protected virtual void UpdatePlayer() {
			Player.Update();
		}

		protected virtual void UpdateEnemies() {
			SpawnEnemies();

			foreach (var e in Enemies) {
				e.Update();
			}
		}

		protected virtual void UpdateHarvests() {
			foreach (var h in Harvests) {
				h.Grow();
			}
		}

		public virtual void UpdateGame() {
			UpdatePlayer();
			UpdateEnemies();
			UpdateHarvests();
		}
	}
}
