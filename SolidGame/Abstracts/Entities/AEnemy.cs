using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Abstracts.Entities {
	abstract class AEnemy : IEnemy {

		public int Damage { get; set; }
		public int Speed { get; set; }
		public IGame Game { get; set; }
		public ILocation Location { get; set; }
		protected ILocation TargetLocation { get; set; }

		protected abstract bool IsAvailablePursue();
		protected abstract void MoveTo(ILocation location);
		protected abstract ILocation GetMoveTarget();

		protected void Attack() {
			Game.Player.Health -= Damage;
		}
		
		protected void Pursue() {
			MoveTo(Game.Player.Location);
		}

		public void Update() {
			if (Location.IsNear(Game.Player.Location)) {
				Attack();
			} else if (IsAvailablePursue()) {
				Pursue();
			} else if (Location.IsNear(TargetLocation)) {
				TargetLocation = GetMoveTarget();
			} else {
				MoveTo(TargetLocation);
			}
		}
	}
}
