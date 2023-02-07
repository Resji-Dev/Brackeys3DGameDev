using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionDetect : MonoBehaviour
{
    public int health = 3;
    [SerializeField]private Movement movementScript;
    [SerializeField]private Rigidbody rotationUnfreeze;
    [SerializeField]private ScoreCounter scoreOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //THE LINES OF CODE BELOW DOES WHATEVER IS IN THE BRACKETS WHEN YOU ENTER A COLLISION
    //THE LINES OF CODE BELOW SORT OF DO THE SAME THING
    private void OnCollisionEnter(Collision enterInfo){
        
        
        if (enterInfo.gameObject.tag == "Obstacle"){
            Debug.Log("You hit smth...");
            health--;
            Debug.Log(health);
            if(health == 0){
                movementScript.enabled = false;
                scoreOff.enabled = false;
            }
        }
    }
    //LINES OF CODE BELOW LOOKS FOR THE LAST COLLISION YOU HIT BEFORE YOU EXIT COLLISION
    //USED REALLY WELL FOR FALLING OFF OF STUFF
    //RIGHT NOW USING IT TO DISABLE MOVEMENT WHEN YOU FALL OFF
    void OnCollisionExit(Collision exitInfo){
        if(exitInfo.gameObject.tag == "Level"){
            //IF ITS ALREADY FALSE, DON'T DO IT AGAIN
            if (movementScript.enabled != false)
            {
            Debug.Log("You fell off the Earth. #FlatEarthConfirmed"); 
            movementScript.enabled = false;
            scoreOff.enabled = false;
            }
        }
    }
    //THIS LINES OF CODE BELOW DETECTS THE TRIGGER ON THE SECOND PLATFORM DUPLICATED ONTO THE FIRST (THIS ONE REQUIRES A DUPLICATED TRIGGER PLATFORM)
    //THEY THEN COMPARE THE GAME OBJECT TAG, IF TRUE THEY EXECUTE THE CODE IN THEIR BRACKETS
    //THIS ONE IS USED MORE TO DETECT IF YOU ARE IN A AREA WITHOUT STOPPING YOU (TRANSPARENT)
    /*
    void OnTriggerEnter(Collider triggerInfo){
        if (triggerInfo.gameObject.tag == "Level"){
        Debug.Log("Success, but with trigger.");
        }
    }
    */
    void OnTriggerEnter(Collider triggerInformation){
        if (triggerInformation.gameObject.tag == "Finish"){
            Debug.Log("You Won!");
            movementScript.enabled = false;
            scoreOff.enabled = false;
            //unfreezes rotation after winning, its freezed because of bouncing problems
            //rotationUnfreeze.freezeRotation = false;
            //still gives bouncing problems

        }
    }

    
        
    
}
