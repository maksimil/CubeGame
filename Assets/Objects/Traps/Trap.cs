using UnityEngine;
using Interactables;
using Cube;

namespace Traps
{
public abstract class Trap : MonoBehaviour
{
protected Vector3 direction;
protected Vector3 positionOffset;
protected float range;
protected bool oneUse;

public abstract void Start();

void Update()
{
	RaycastHit hit;
	if (Physics.Raycast(transform.position+positionOffset, direction, out hit, range, 1 << 10))
	{
		Activate(hit.collider.GetComponent<MainCubeScript>());
		if (oneUse)
		{
			Destroy(gameObject);
		}
	}
}

public abstract void Activate(MainCubeScript player);
}
}
