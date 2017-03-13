using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBurn : Attack {

	public override void DoAttack (CharacterStats stats)
	{
		stats.health -= 10;
	}

}
