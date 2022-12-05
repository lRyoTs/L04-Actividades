using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex02 : MonoBehaviour
{
    public float cms = 1f; //Stores the centimeters to convert to inches

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{cms} cm = {CmToInchesConverter(cms)} inches.");   
    }

    private float CmToInchesConverter(float centimeter) {
        float inches=0;
        inches = centimeter * 0.393701f;
        return inches;
    }
}
