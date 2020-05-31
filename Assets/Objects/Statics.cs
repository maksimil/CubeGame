using UnityEngine;

namespace Vars
{
public static class Statics
{
public static float SMOOTHING = 10f;

public static float MOVE_PERIOD = 0.2f;

public static float MEANINGLESS_DEVIATION = 0.05f;

public static float TRAP_COOLDOWN = 0.1f;

public static float SCENE_TRANSITION_TIME = 1f;

public static Vector3 MovePosition(Vector3 position, Vector3 aim)
{
	Vector3 moved = Vector3.Lerp(position, aim, Statics.SMOOTHING*Time.deltaTime);
	if ((moved-aim).magnitude < MEANINGLESS_DEVIATION)
	{
		return aim;
	}
	return moved;
}

}

public delegate void VoidCallback();
}
