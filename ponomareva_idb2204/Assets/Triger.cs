using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
   
    public Text counterText;

    int counter = 100;

    private void Start()
    {
        counterText.text = "Counter: " + counter.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {

        counter--;

        counterText.text = "Counter: " + counter.ToString();
    }
}
