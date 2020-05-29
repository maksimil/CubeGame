using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
public bool reusable;
public GameObject particle;

public void Interact()
{
	if (!reusable)
	{
		Destroy(gameObject);
	}
	Instantiate(particle, transform.position + new Vector3(0f, 1f, 0f), Quaternion.Euler(-90f, 0f, 0f));
}
}
