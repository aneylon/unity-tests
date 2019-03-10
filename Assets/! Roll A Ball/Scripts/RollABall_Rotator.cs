using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall_Rotator : MonoBehaviour
{
    public float spinSpeed = 50;

    private void Update()
    {
        transform.Rotate(new Vector3(spinSpeed, spinSpeed, spinSpeed) * Time.deltaTime);
    }
}
