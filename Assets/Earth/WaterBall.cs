using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBall : Attack 
{
	public override void DoHeal (CharacterStats stats)
	{
		CharacterStats CS = new CharacterStats();
		CS.health = CS.curHealth + 50;
	}
	public override void DoAttack (CharcterStats2 stats)
	{
		CharcterStats2 CS2 = new CharcterStats2();
		CS2.health = CS2.curHealth - 50;
	}
}
