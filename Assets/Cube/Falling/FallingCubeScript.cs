using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vars;

namespace Cube
{
public class FallingCubeScript : MonoBehaviour
{
private Vector3 aim;

// Start is called before the first frame update
void Start()
{
	aim = transform.position + new Vector3(0f, -1f, 0f);
}

// Update is called once per frame
void Update()
{
	transform.position = Vector3.Lerp(transform.position, aim, Statics.smoothing*Time.deltaTime);
	if (transform.position == aim)
	{
		Destroy(gameObject);
	}
}
}
}
