using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[CustomLuaClass]
public class LoadScene : MonoBehaviour {

	public static void LoadScene__s(int i)
	{
		SceneManager.LoadScene(i);
	}
	

}
