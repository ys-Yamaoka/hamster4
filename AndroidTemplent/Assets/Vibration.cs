using UnityEngine;
using System.Collections;

public class Vibration : MonoBehaviour {

    // Use this for initialization
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 10, 100, 32), "Vibrate!"))
            //バイブレーションが出来ます！！
            Handheld.Vibrate();
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
