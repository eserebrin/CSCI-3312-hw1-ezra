using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomEdgeManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider) {
        Destroy(collider.gameObject);
        GameObject bucket = GameObject.Find("bucket (2)");
        if (bucket == null) {
            bucket = GameObject.Find("bucket (1)");
        }
        if (bucket == null) {
            bucket = GameObject.Find("bucket");
        }
        if (bucket == null) {
            Application.Quit();
        }
        Destroy(bucket);
    }
}
