using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!checkOOB(transform.position.x, transform.position.y, transform.position.z)) {
            Debug.Log("The object is NOT Out Of Bounds");
        } else {
            Debug.Log("The object is Out Of Bounds");
        }   
    }


    //Function that checks if an object is Out of Bounds
    private bool checkOOB(float posX, float posY, float posZ) {
        float horizontalLimit = 5f;
        float verticalLimit = 5f;
        float depthLimit = 5f;

        //check if any position it's out of bounds
        if ((posX > horizontalLimit || posX < (-horizontalLimit)) || (posY > verticalLimit || posY < (-verticalLimit)) || (posZ > depthLimit || posZ < (-depthLimit))) {
            return true;
        }
        return false;
    }

}
