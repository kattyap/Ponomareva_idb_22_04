using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject Sphere;
    public float speed = 50000f; 
    private float targetPosition;

    public void OnButtonDown()
    {
        float randomSpeed = Random.Range(100000, 110000); 
        targetPosition = Sphere.transform.position.x + randomSpeed; 
        StartCoroutine(MoveSphere());
    }

    IEnumerator MoveSphere()
    {
        while (Sphere.transform.position.x < targetPosition)
        {
            float step = speed * Time.deltaTime; 
            Sphere.transform.position = new Vector3(Sphere.transform.position.x + step, Sphere.transform.position.y, Sphere.transform.position.z); 
            yield return null;
        }
    }
}
