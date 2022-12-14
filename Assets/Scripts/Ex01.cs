using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01 : MonoBehaviour
{
    public float moneyBox = 0f; //Stores the total amount of money stored

    // Start is called before the first frame update
    void Start()
    {
        StoreMoney(10f);
        Debug.Log($"Total money in box: {moneyBox}");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            StoreMoney(10f);
            Debug.Log($"Total money in box: {moneyBox}"); 
        }
    }

    //Function that stores the given money
    private void StoreMoney(float money) {
        moneyBox += money; //Increase by the money given
    }
}
