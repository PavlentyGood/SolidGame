using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces {
	public interface IEnemyStrategyProvider {

		IEnemy Enemy { get; set; }

		IEnemyStrategy ProvideStrategy();
	}
}
