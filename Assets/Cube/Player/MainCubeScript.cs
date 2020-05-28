using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vars;

namespace Cube
{
public class MainCubeScript : MonoBehaviour
{
public GameObject fallingCube;
private InputMaster controls;
private Vector3 aim;
private float height;


void Awake()
{
	controls = new InputMaster();
	controls.Cube.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
}

void OnEnable()
{
	controls.Enable();
}

void OnDisable()
{
	controls.Disable();
}

// Start is called before the first frame update
void Start()
{
	height = transform.position.y;
}

// Update is called once per frame
void Update()
{
	transform.position = Vector3.Lerp(transform.position, aim, Statics.smoothing*Time.deltaTime);
}

void Move(Vector2 direction)
{
	Instantiate(fallingCube, transform.position, Quaternion.Euler(0f, 0f, 0f));
	Vector3 pos = transform.position;
	transform.position = new Vector3(pos.x+direction.x, height-1f, pos.z+direction.y);
	aim = transform.position + new Vector3(0f, 1f, 0f);
}
}
}
