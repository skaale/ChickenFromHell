using UnityEngine;
using System.Collections;

public class SpwanerBehaviour : MonoBehaviour {

    public GameObject chickenPrefab;

	// Use this for initialization
	void Start () {
        StartCoroutine(InfiniteSpawn());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public IEnumerator InfiniteSpawn()
    {
        while (true)
        {
            GameObject.Instantiate(chickenPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(10f);
        }
    }
}
