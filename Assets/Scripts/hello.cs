using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour {


	// Use this for initialization
	void Start () {
        float space = 150f;
        float shiftX = 0f;
        float shiftY = 0f;
        GameObject gameObject = Resources.Load("Block") as GameObject;
        Debug.Log(gameObject);
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 7; j++)
            {
                GameObject block = Instantiate(gameObject, GameObject.Find("Canvas/GuildCrushWindow/Bg/Board").transform);
                block.transform.localPosition = new Vector3(shiftX+i*space, shiftY-j*space, 0);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void InitLocation()
    {

    }
}
