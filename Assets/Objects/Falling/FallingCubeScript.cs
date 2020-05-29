using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vars;

namespace Cube
{
public class FallingCubeScript : MonoBehaviour
{
public VoidCallback ondie;

private float time = 0f;
private Vector3 aim;

// Start is called before the first frame update
void Start()
{
	aim = transform.position + new Vector3(0f, -1f, 0f);
}

// Update is called once per frame
void Update()
{
	time += Time.deltaTime;
	transform.position = Vector3.Lerp(transform.position, aim, time/Statics.MOVE_PERIOD);
	if (time >= Statics.MOVE_PERIOD)
	{
		Destroy(gameObject);
		ondie();
	}
}
}
}
