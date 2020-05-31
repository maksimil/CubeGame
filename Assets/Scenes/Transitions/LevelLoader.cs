using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vars;

namespace Levels
{
public class LevelLoader : MonoBehaviour
{
public Animator transition;

public void Transition(int move)
{
	StartCoroutine(Load(SceneManager.GetActiveScene().buildIndex + move));
}

IEnumerator Load(int index)
{
	transition.SetTrigger("Start");

	yield return new WaitForSeconds(Statics.SCENE_TRANSITION_TIME);

	SceneManager.LoadScene(index);
}
}
}
