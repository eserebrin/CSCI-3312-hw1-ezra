using System;
// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour
{
    float speed = 2.0F;
    float targetPosX;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.x < targetPosX) {
            pos.x += speed * Time.deltaTime;
        }
        if (pos.x > targetPosX) {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;
        if (Math.Abs(pos.x - targetPosX) < speed * Time.deltaTime) {
            targetPosX = UnityEngine.Random.Range(-8.0F, 8.0F);
        }
    }
}
