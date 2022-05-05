using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // transform bracht immer koordinaten
    // target erstellen und in unity player zuweisen
    public Transform target;
    // schnellerer player, mehr smoothen
    // irgend ein wert zwischen 0 und 1
    public float smoothSpeed  = 0.125f;

    // Vector 3, weil Kamera in allen 3 Axen offset sein soll
    public Vector3 offset;

    // lateupdate, sonst streiten camera und player wer zuerst dran kommt
    // wackeliges verhalten
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
    //Vector3.Lerp T = wert zwischen 0 und 1 
    // 0 ist anfangsposition (transform.position), 1 ist desiredposition
    Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    transform.position = smoothedPosition;
    }

}
