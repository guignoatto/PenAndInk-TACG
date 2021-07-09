using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Range(0, 1)]
    [SerializeField] private float speed;

    void Update()
    {
        transform.Rotate(Vector3.down * speed);
    }
}
