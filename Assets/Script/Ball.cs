using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    public Vector3 Position => rb.position;
    public bool IsMoving => rb.velocity!=Vector3.zero;
    
    private void Awake()
    {
        if(rb==null)
        rb = GetComponent<Rigidbody>();
    }
}
