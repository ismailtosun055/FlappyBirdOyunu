using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruHareketi : MonoBehaviour
{
    [SerializeField] float velocity = 5f;
    void Start()
    {
        Destroy(gameObject,5f);
        
    }

    void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
        
    }
}
