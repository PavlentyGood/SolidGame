using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Abstracts.Strategies {
	public abstract class AEnemyAttackStrategy : IEnemyStrategy {

		public abstract void Perform(IEnemy enemy);
	}
}
