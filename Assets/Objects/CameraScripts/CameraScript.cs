using UnityEngine;
using Cube;

namespace Camera
{
public abstract class CameraScript : MonoBehaviour
{
public GameObject player;

protected Vector3 offset;
protected PlayerCube playerScript;

void Start()
{
	offset = transform.position - player.transform.position;
	playerScript = player.GetComponent<PlayerCube>();
}
}
}
