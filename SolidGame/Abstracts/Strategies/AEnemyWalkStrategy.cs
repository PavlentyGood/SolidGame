using SolidGame.Interfaces;
using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Abstracts.Strategies {
	abstract class AEnemyWalkStrategy : IEnemyStrategy {

		public abstract void Perform(IEnemy enemy);
	}
}
