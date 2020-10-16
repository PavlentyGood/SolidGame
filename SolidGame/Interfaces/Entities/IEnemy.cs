using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Entities {
	interface IEnemy : IMoveable {

		int Damage { get; set; }

		void AttackPlayer();
	}
}
