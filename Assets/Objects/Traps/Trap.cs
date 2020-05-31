using UnityEngine;
using Interactables;
using Cube;
using Vars;

namespace Traps
{
public abstract class Trap : MonoBehaviour
{
protected Vector3 direction;
protected Vector3 positionOffset;
protected float range;
protected bool oneUse;
private bool usable = true;

public abstract void Start();

void Update()
{
	if (usable)
	{
		RaycastHit hit;
		if (Physics.Raycast(transform.position+positionOffset, direction, out hit, range, 1 << 10))
		{
			Activate(hit.collider.GetComponent<PlayerCube>());
			if (oneUse)
			{
				Destroy(gameObject);
			}
			usable = false;
			Invoke("SetUsable", Statics.TRAP_COOLDOWN);
		}
	}
}

void SetUsable()
{
	usable = true;
}

public abstract void Activate(PlayerCube player);
}
}
