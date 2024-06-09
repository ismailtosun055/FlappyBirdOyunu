using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Ucma : MonoBehaviour
{
    [SerializeField] float velocity = 10f;
    int score = 0;
    [SerializeField] GameObject scoretext;
    Rigidbody2D rb;
    Touch touch;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.touchCount > 0){

            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){
                rb.velocity =  Vector2.up * velocity;
            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoretext.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
