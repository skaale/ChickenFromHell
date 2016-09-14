using UnityEngine;
using System.Collections;

public class ChikenBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        uGUI_UIController.RegisterChicken();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Chicken was hit");
        GameObject.Destroy(gameObject);
    }

    void OnDestroy()
    {
        uGUI_UIController.UnRegisterChicken();
    }
}
