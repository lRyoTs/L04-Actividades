using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{

    public string[] animals;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"The animal you get is: {getAnimal()}");
    }

    //Function that returns a random animal from the array
    private string getAnimal() {
        int arrayLimit = animals.Length; //Stores the limit of the array
        int randIndex = Random.Range(0, arrayLimit); //Gets a random index from the array
        return animals[randIndex];
    }
}
