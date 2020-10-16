using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Entities {
	public interface IEnemy : IEntity, IMoveable {

		int Damage { get; set; }

		void AttackPlayer();
	}
}
