using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vars;

namespace Cube
{
public class MainCubeScript : MonoBehaviour
{
public int groundLayer = 8;
public GameObject fallingCube;
private Vector3 aimPosition;
private float height;

// <editor-fold desc = controls>
private InputMaster controls;

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
// </editor-fold>

// Start is called before the first frame update
void Start()
{
	height = transform.position.y;
}

// Update is called once per frame
void Update()
{
	transform.position = Vector3.Lerp(transform.position, aimPosition, Statics.smoothing*Time.deltaTime);
}

void Move(Vector2 direction)
{
	if (CheckGroundAndWalls(direction))
	{
		Instantiate(fallingCube, transform.position, Quaternion.Euler(0f, 0f, 0f));
		Vector3 pos = transform.position;
		transform.position = new Vector3(pos.x+direction.x, height-1f, pos.z+direction.y);
		aimPosition = transform.position + new Vector3(0f, 1f, 0f);
	}
}

bool CheckGroundAndWalls(Vector2 direction)
{
	Vector3 dir3 = new Vector3(direction.x, 0f, direction.y);
	RaycastHit hit;
	int layerMask = 1 << groundLayer;
	bool wall = !Physics.Raycast(aimPosition, dir3, out hit, 1f, layerMask);
	Debug.Log(wall);
	bool ground = Physics.Raycast(aimPosition+dir3, new Vector3(0f, -1f, 0f), out hit, 1f, layerMask);
	return wall && ground;
}
}
}
