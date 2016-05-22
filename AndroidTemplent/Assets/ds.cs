using UnityEngine;
using System.Collections;

public class ds : MonoBehaviour {

    public GameObject ac;
    public GameObject bx;
    private int i;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            i++;
        }
        if (i % 2 == 0)
        {
            ac.transform.SetAsLastSibling();
        }
        else bx.transform.SetAsLastSibling();
    }
}
