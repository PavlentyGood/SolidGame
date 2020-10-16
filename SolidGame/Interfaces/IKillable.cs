using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGame.Interfaces {
	interface IKillable {

		int Health { get; set; }

		void Die();
	}
}
