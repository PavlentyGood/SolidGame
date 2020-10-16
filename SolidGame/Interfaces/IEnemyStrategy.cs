using SolidGame.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces {
	interface IEnemyStrategy {

		void Perform(IEnemy enemy);
	}
}
