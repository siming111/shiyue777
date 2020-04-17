using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeTestPanel : MonoBehaviour {

    private Transform testPanel;

	// Use this for initialization
	void Start () {
        GameObject gameObject = GameObject.Find("Canvas");
        testPanel = gameObject.transform.Find("TestPanel");
	}

    public void confirm()
    {
        GameObject.Find("Canvas/TestPanel/TestField/Button").SetActive(false);
        testPanel.gameObject.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            testPanel.gameObject.SetActive(!testPanel.gameObject.active);
        }
	}
}
