using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cube;
using Traps;

namespace Levels
{
public class AimScript : MonoBehaviour
{
public int move;
public LevelLoader levelLoader;

void Update()
{
	RaycastHit hit;
	if (Physics.Raycast(transform.position, new Vector3(0f, 1f, 0f), out hit, 1f, 1 << 10))
	{
		levelLoader.Transition(move);
	}
}
}
}
