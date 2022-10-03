using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BucketManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private float speed = 2.0F;

    void OnTriggerEnter2D(Collider2D collider) {
        Destroy(collider.gameObject);
        score++;
        scoreText.text = score.ToString();
    }
    
    // Update is called once per frame
    void Update() {
        Vector3 pos = transform.position;
        if (Input.GetKey("d") || Input.GetKey("right")) {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.GetKey("left")) {
            pos.x -= speed * Time.deltaTime;
        } 
        transform.position = pos;
    }
}
