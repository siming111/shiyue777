using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Z))
        {
            this.gameObject.SetActive(true);
        }
	}

    public void Confirm()
    {
        this.gameObject.SetActive(false);
    }
}
