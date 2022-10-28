using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirLockSystem : MonoBehaviour
{

    public GameObject outsideDoor;
    public GameObject insideDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if(other.gameObject.tag == "AirlockOutside") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            outsideDoor.SetActive(false);
        }
        else if(other.gameObject.tag == "AirlockInsideOuterDoor") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            outsideDoor.SetActive(false);
            insideDoor.SetActive(true);
        }
        else if(other.gameObject.tag == "AirlockInsideInnerDoor") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            outsideDoor.SetActive(true);
            insideDoor.SetActive(false);
        }
        else if(other.gameObject.tag == "AirlockInside") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            insideDoor.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "AirlockOutside") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            outsideDoor.SetActive(true);
        }
        else if(other.gameObject.tag == "AirlockInside") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            insideDoor.SetActive(true);
        }
     
    }
}
