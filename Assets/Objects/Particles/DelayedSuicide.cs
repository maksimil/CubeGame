using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedSuicide : MonoBehaviour
{
public float timespan;

// Start is called before the first frame update
void Start()
{
	Invoke("Die", timespan);
}

void Die()
{
	Destroy(gameObject);
}
}
