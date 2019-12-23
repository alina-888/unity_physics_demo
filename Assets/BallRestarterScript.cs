using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallRestarterScript : MonoBehaviour
{
	public GameObject ball1;
        public GameObject ball2;
        public GameObject ball3;
	       Vector3 ball1SP;
	       Vector3 ball2SP;
	       Vector3 ball3SP;
        public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener (delegate {RestartGame();});
                        ball1SP = ball1.transform.position;
        		ball2SP = ball2.transform.position;
			ball3SP = ball3.transform.position;
    }
public void RestartGame()  {
Debug.Log("restart games ");	
// move balls to start position
	ball1.transform.position = ball1SP; 
 	ball2.transform.position = ball2SP; 
	ball3.transform.position = ball3SP;
	ResetVelocity(ball1);
	ResetVelocity(ball2);
	ResetVelocity(ball3);
	 
}

void ResetVelocity(GameObject obj){
	Rigidbody rb = obj.GetComponent(typeof(Rigidbody)) as Rigidbody;
	rb.velocity = new Vector3(0, 0, 0);	
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
