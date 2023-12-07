using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderAnimation : MonoBehaviour
{
    public Animator riderAnimation;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        riderAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        if (forwardInput > 0.0f)
        {
            riderAnimation.Play("Rider Canter");
        }
        else
        {
            riderAnimation.Play("Rider Idle");
        }
    }
}
