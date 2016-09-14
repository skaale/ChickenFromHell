using UnityEngine;
using System.Collections;

public class uGUI_UIController : MonoBehaviour {


    public static uGUI_UIController instance;
    public UnityEngine.UI.Text countText;
    static int chickenCount = 0;

    static int ChickenCount
    {
        get
        {
            return chickenCount;
        }
        set
        {
            if (value != chickenCount)
            {
                chickenCount = value;
                //Debug.Log("Setting chickenCount to " + );
                if (instance != null && instance.countText != null) instance.countText.text = chickenCount.ToString();
            }
        }
    }

    public static void RegisterChicken()
    {
        Debug.Log("Registering chicken");
        ++ChickenCount;
    }

    public static void UnRegisterChicken()
    {
        --ChickenCount;
    }

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
