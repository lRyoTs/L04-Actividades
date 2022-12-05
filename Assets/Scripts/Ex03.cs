using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    public float lowRange = 0f; //Indicates the lower limit
    public float upRange = 10f; //Indicates the upper limit
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"The new vector is {generateVector(lowRange, upRange)}");
    }

    //Generate a new vector3 given limit
    private Vector3 generateVector(float lowerLimit, float upperLimit)
    {
        float randomX = Random.Range(lowerLimit, upperLimit); //Gets a random position in X
        float randomY = Random.Range(lowerLimit, upperLimit); //Gets a random position in Y
        float randomZ = Random.Range(lowerLimit, upperLimit); //Gets a random position in Z
        return new Vector3(randomX, randomY, randomZ); //Generates a new Vector
    }
}
