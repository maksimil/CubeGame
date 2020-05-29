using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cube;

namespace Interactables
{
public class LiftInteractScript : MonoBehaviour, Interactable
{
public float lift;

public void Interact(MainCubeScript player)
{
	player.movePlayer(new Vector3(0f, lift, 0f));
}
}
}
