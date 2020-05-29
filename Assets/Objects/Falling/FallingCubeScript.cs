using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vars;

namespace Cube
{
public class FallingCubeScript : MonoBehaviour
{
public VoidCallback ondie;
public float timespan;

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
	transform.position = Vector3.Lerp(transform.position, aim, time/timespan);
	if (time >= timespan)
	{
		Destroy(gameObject);
		ondie();
	}
}
}
}
