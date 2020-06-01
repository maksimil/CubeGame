using UnityEngine;
using Vars;

namespace Camera
{
public class LookFollowCameraScript : CameraScript
{
void Update()
{
	Vector3 fwd = playerScript.aimPosition - transform.position;
	Quaternion aim = Quaternion.LookRotation(fwd, new Vector3(0f, 1f, 0f));
	transform.localRotation = Quaternion.Lerp(transform.localRotation, aim, Statics.SMOOTHING*Time.deltaTime);
}
}
}
