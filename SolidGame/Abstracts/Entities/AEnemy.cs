﻿using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Abstracts.Entities {
	public abstract class AEnemy : IEnemy {

		public int Damage { get; set; }
		public int Speed { get; set; }
		public IGame Game { get; set; }
		public ILocation Location { get; set; }
		public ILocation TargetLocation { get; set; }
		public IEnemyStrategyProvider StrategyProvider { get; set; }

		public abstract void Move();
		protected abstract bool IsAvailablePursuePlayer();
		protected abstract ILocation GetNextMoveTarget();

		public virtual void AttackPlayer() {
			Game.Player.Health -= Damage;
		}
		
		public virtual void Update() {
			Move();

			StrategyProvider
				.ProvideStrategy()
				.Perform(this);
		}
	}
}
