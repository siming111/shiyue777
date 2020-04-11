using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hello : MonoBehaviour {

    private GameObject icon1;
	// Use this for initialization
	void Start () {
        float space = 0f;
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
                GameObject icon = block.transform.Find("icon").gameObject;
                Image image = icon.GetComponent<Image>();
                Debug.Log(image);
                image.sprite = Resources.Load<Sprite>("Textures/Crush/icon1") ;
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
