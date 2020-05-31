using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cube;

namespace Interactables
{
public class InteractForParticle : MonoBehaviour,  Interactable
{
public GameObject particle;

public void Interact(PlayerCube player)
{
	Instantiate(particle, transform.position + new Vector3(0f, 1f, 0f), Quaternion.Euler(-90f, 0f, 0f));
}
}
}
