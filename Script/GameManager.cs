using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject boruprefap;
    [SerializeField] float olusmasuresi = 5f;
    void Start()
    {
        StartCoroutine(Spanlama());
        
    }

    void Update()
    {
        
    }
    IEnumerator Spanlama()
    {
        while(true)
        {
            UnityEngine.Vector3 farkliaraliklar = new UnityEngine.Vector3(transform.position.x,transform.position.y + UnityEngine.Random.Range(-3f,3f),transform.position.z);
            Instantiate(boruprefap,farkliaraliklar,UnityEngine.Quaternion.identity);
            olusmasuresi = UnityEngine.Random.Range(1f,3f);
            yield return new WaitForSeconds(olusmasuresi);
        }

    }
}
