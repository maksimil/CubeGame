using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cube;

namespace Traps
{
public class PushTrap : Trap
{
public Vector3 pushAmount;

public override void Start()
{
	direction = new Vector3(0f, 1f, 0f);
	positionOffset = new Vector3(0f, 0f, 0f);
	range = 1f;
	oneUse = true;
}

public override void Activate(MainCubeScript player)
{
	Debug.Log("Moved");
	player.MovePlayer(pushAmount);
}
}
}
