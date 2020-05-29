using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vars;

namespace Cube
{
public class MainCubeScript : MonoBehaviour
{
public GameObject fallingCube;

public Vector3 aimPosition;
private Vector2 direction = new Vector2(0f, 0f);
private float height;
private bool moving = false;

// <editor-fold desc = controls>
private InputMaster controls;

void Awake()
{
	controls = new InputMaster();
	controls.Cube.Move.performed += ctx =>
	{
		direction = ctx.ReadValue<Vector2>();
		if (!moving && direction != new Vector2(0f, 0f))
		{
			Move();
		}
	};
	controls.Cube.Interact.performed += _ => Interact();
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

void Move()
{
	moving = direction != new Vector2(0f, 0f) && CheckGroundAndWalls(direction);
	if (moving)
	{
		FallingCubeScript fcube = Instantiate(fallingCube, transform.position, Quaternion.Euler(0f, 0f, 0f)).GetComponent<FallingCubeScript>();
		fcube.ondie = Move;
		Vector3 pos = transform.position;
		transform.position = new Vector3(pos.x+direction.x, height-1f, pos.z+direction.y);
		aimPosition = transform.position + new Vector3(0f, 1f, 0f);
	}
}

bool CheckGroundAndWalls(Vector2 direction)
{
	Vector3 dir3 = new Vector3(direction.x, 0f, direction.y);
	RaycastHit hit;
	int layerMask = 1 << 8;
	bool wall = !Physics.Raycast(aimPosition, dir3, out hit, 1f, layerMask);
	bool ground = Physics.Raycast(aimPosition+dir3, new Vector3(0f, -1f, 0f), out hit, 1f, layerMask);
	return wall && ground;
}

void Interact()
{
	RaycastHit hit;
	if (Physics.Raycast(aimPosition, new Vector3(0f, -1f, 0f), out hit, 1f, 1 << 9))
	{
		hit.collider.GetComponent<InteractScript>().Interact();
	}
}
}
}
