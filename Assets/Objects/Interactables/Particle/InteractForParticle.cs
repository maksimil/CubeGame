using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interactables
{
public class InteractForParticle : MonoBehaviour,  Interactable
{
public GameObject particle;

public void Interact()
{
	Instantiate(particle, transform.position + new Vector3(0f, 1f, 0f), Quaternion.Euler(-90f, 0f, 0f));
}
}
}
