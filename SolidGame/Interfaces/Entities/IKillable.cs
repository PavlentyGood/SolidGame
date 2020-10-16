using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces.Entities {
	interface IKillable {

		int Health { get; set; }

		void Die();
	}
}
