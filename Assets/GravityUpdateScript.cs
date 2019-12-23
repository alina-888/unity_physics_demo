using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class GravityUpdateScript : MonoBehaviour
{
	public Slider myslider;
	public Text gravityText;
        

    // Start is called before the first frame update
    void Start()
    {
	    Debug.Log("I am alive!");
     			myslider.onValueChanged.AddListener (delegate {ChangeGravity();});
        		
    }




public void ChangeGravity() {
 	gravityText.text = "Gravity :" + Math.Round(myslider.value);
	Physics.gravity = new Vector3(0, -myslider.value, 0);
}



    // Update is called once per frame
    void Update()
    {
	   // Debug.Log("slider: " +  myslider.value);
        
    }
}
