using SolidGame.Abstracts.Strategies;
using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Abstracts {
	abstract class AEnemyStrategyProvider : IEnemyStrategyProvider {

		public IEnemy Enemy { get; set; }

		public AEnemyStrategyProvider(IEnemy enemy) {
			Enemy = enemy;
		}

		protected abstract bool IsAvailableAttack();
		protected abstract bool IsAvailablePursue();
		protected abstract IEnemyStrategy CreateAttackStrategy();
		protected abstract IEnemyStrategy CreatePursueStrategy();
		protected abstract IEnemyStrategy CreateWalkStrategy();

		public virtual IEnemyStrategy ProvideStrategy() {
			if (IsAvailableAttack()) {
				return CreateAttackStrategy();
			} else if (IsAvailablePursue()) {
				return CreatePursueStrategy();
			} else {
				return CreateWalkStrategy();
			}
		}
	}
}
