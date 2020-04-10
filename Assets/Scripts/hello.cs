using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject gameObject = Resources.Load("Block") as GameObject;
        Debug.Log(gameObject);
        GameObject block = Instantiate(gameObject, new Vector2(0, 0), gameObject.transform.rotation, GameObject.Find("Canvas/GuildCrushWindow/Bg/Board").transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
