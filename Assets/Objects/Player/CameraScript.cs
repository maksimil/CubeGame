using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vars;
using Cube;

namespace Camera
{
public class CameraScript : MonoBehaviour
{
public GameObject player;

private Vector3 offset;
private MainCubeScript playerScript;


// Start is called before the first frame update
void Start()
{
	offset = transform.position - player.transform.position;
	playerScript = player.GetComponent<MainCubeScript>();
}

// Update is called once per frame
void Update()
{
	transform.position = Vector3.Lerp(transform.position, playerScript.aimPosition+offset, Statics.smoothing*Time.deltaTime);
}
}
}
