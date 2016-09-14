using UnityEngine;
using System.Collections;

public class MovementAI : MonoBehaviour {

    private GameObject player;   
    public float movmentSpeed = 1.0f;
    public float closeDistance = 1.0f;
       

	// Update is called once per frame
	void Update () 
    {
        if(player == null)
        {

            player = GameObject.FindGameObjectWithTag("Player");
          
        
        }
        else
        {
            Vector3 temp = player.transform.position - transform.position;
            temp.y = 0;
            transform.rotation = Quaternion.LookRotation(temp);

            if (temp.magnitude > closeDistance )
            {
            
                 transform.position += transform.forward * movmentSpeed * Time.deltaTime;
            }
           
            
        }

	
	}

   void Damage(float amount)
    {

        Destroy(gameObject);


    }
}
