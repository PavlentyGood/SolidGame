using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces {
	interface IEnemyStrategyProvider {

		IEnemy Enemy { get; set; }

		IEnemyStrategy ProvideStrategy();
	}
}
