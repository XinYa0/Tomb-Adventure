using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followtarget : MonoBehaviour
{
    public Transform hero;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - hero.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + hero.position;
    }
}
