using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cube;
using Traps;

namespace Aim
{
public class AimInteract : Trap
{
public override void Start()
{
	direction = new Vector3(0f, 1f, 0f);
	positionOffset = new Vector3(0f, 0f, 0f);
	range = 1f;
	oneUse = true;
}

public override void Activate(PlayerCube player)
{
	Debug.Log("Next lvl");
}
}
}
