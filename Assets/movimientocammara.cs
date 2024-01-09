using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientocammara : MonoBehaviour
{
    public float hori;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        
        rig.velocity = new Vector2(hori * 10, rig.velocity.y);
    }
}
