using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cube;

namespace Interactables
{
public class PushInteract : MonoBehaviour, Interactable
{
public Vector3 pushAmount;

public void Interact(MainCubeScript player)
{
	player.MovePlayer(pushAmount);
}
}
}
