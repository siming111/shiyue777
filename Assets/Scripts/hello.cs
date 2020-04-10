using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hello : MonoBehaviour {


	// Use this for initialization
	void Start () {
        float space = 140f;
        float shiftX = 87f;
        float shiftY = -142f;
        GameObject gameObject = Resources.Load("Block") as GameObject;
        Debug.Log(gameObject);
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                GameObject block = Instantiate(gameObject, GameObject.Find("Canvas/GuildCrushWindow/Bg/Board").transform);
                block.transform.localPosition = new Vector3(shiftX+i*space, shiftY-j*space, 0);
                Image image = block.GetComponent<Image>();
                Debug.Log(image);
                image.sprite = Resources.Load("Textures/Crush/icon2") as Sprite;
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
