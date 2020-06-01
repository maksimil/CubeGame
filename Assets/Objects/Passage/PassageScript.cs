using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Levels
{
public class PassageScript : MonoBehaviour
{
public LevelLoader levelLoader;
public int scene;

void OnTriggerEnter(Collider other)
{
	levelLoader.MoveLevel(scene);
}

}
}
