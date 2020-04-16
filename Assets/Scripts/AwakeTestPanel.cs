using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeTestPanel : MonoBehaviour {

    private Transform testField;

	// Use this for initialization
	void Start () {
        GameObject testPanel = GameObject.Find("Canvas/TestPanel");
        testField = testPanel.transform.Find("TestField");
	}

    public void confirm()
    {
        GameObject.Find("Canvas/TestPanel/TestField/Button").SetActive(false);
        testField.gameObject.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            testField.gameObject.SetActive(!testField.gameObject.active);
        }
	}
}
