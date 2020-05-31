using Vars;
using Cube;
using UnityEngine;

namespace Camera
{
public class SimpleFollowCameraScript : CameraScript
{
void Update()
{
	transform.position = Vector3.Lerp(transform.position, playerScript.aimPosition+offset, Statics.SMOOTHING*Time.deltaTime);
}
}
}
