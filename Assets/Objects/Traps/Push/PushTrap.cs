using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cube;

namespace Traps
{
public class PushTrap : Trap
{
public Vector3 pushAmount;
public bool reusable;

public override void Start()
{
	direction = new Vector3(0f, 1f, 0f);
	positionOffset = new Vector3(0f, 0f, 0f);
	range = 1f;
	oneUse = !reusable;
}

public override void Activate(PlayerCube player)
{
	player.MovePlayer(pushAmount);
}
}
}
