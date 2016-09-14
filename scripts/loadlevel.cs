using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour {

    public string level;



    public void OnTriggerEnter(Collider c)
    {

        //Application.LoadLevel(2);
        SceneManager.LoadScene(level);


    }

}
