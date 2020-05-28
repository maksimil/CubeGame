using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vars;

public class CameraScript : MonoBehaviour
{
public GameObject player;

private Vector3 offset;


// Start is called before the first frame update
void Start()
{
	offset = transform.position - player.transform.position;
}

// Update is called once per frame
void Update()
{
	transform.position = Vector3.Lerp(transform.position, player.transform.position+offset, Statics.smoothing*Time.deltaTime);
}
}
