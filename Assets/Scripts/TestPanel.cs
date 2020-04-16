using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SLua;

[CustomLuaClass]
public class TestPanel : MonoBehaviour {

    public static float p_hp;
    public static float p_shield;
    public static float p_energy;
    public static float p_power;
    public static float p_hp_total;
    public static float p_shield_total;
    public static float p_energy_total;
    public static float b_hp_total;
    public static float b_power;
    public static float b_fight_round;
	// Use this for initialization

	void Start () {
        GameObject.Find("Canvas/TestPanel/TestField/GameObject/InputField").GetComponent<InputField>().text = "25";
        GameObject.Find("Canvas/TestPanel/TestField/GameObject1/InputField").GetComponent<InputField>().text = "20";
        GameObject.Find("Canvas/TestPanel/TestField/GameObject2/InputField").GetComponent<InputField>().text = "15";
        GameObject.Find("Canvas/TestPanel/TestField/GameObject3/InputField").GetComponent<InputField>().text = "100";
        GameObject.Find("Canvas/TestPanel/TestField/GameObject7/InputField").GetComponent<InputField>().text = "100";
        GameObject.Find("Canvas/TestPanel/TestField/GameObject4/InputField").GetComponent<InputField>().text = "100";
        GameObject.Find("Canvas/TestPanel/TestField/GameObject5/InputField").GetComponent<InputField>().text = "100";
        GameObject.Find("Canvas/TestPanel/TestField/GameObject8/InputField").GetComponent<InputField>().text = "1000";
        GameObject.Find("Canvas/TestPanel/TestField/GameObject9/InputField").GetComponent<InputField>().text = "25";
        GameObject.Find("Canvas/TestPanel/TestField/GameObject10/InputField").GetComponent<InputField>().text = "4";

	}

    public void confirm()
    {
        p_hp = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject/InputField/Text").GetComponent<Text>().text);
        p_shield = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject1/InputField/Text").GetComponent<Text>().text);
        p_energy = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject2/InputField/Text").GetComponent<Text>().text);
        p_power = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject3/InputField/Text").GetComponent<Text>().text);
        p_hp_total = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject7/InputField/Text").GetComponent<Text>().text);
        p_shield_total = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject4/InputField/Text").GetComponent<Text>().text);
        p_energy_total = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject5/InputField/Text").GetComponent<Text>().text);
        b_hp_total = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject8/InputField/Text").GetComponent<Text>().text);
        b_power = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject9/InputField/Text").GetComponent<Text>().text);
        b_fight_round = Convert.ToSingle(GameObject.Find("Canvas/TestPanel/TestField/GameObject10/InputField/Text").GetComponent<Text>().text);
    }
}
