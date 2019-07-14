using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estala1 : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    public void Fallen()
    {
        // if(trigger.gameObject.CompareTag("Player"))
        {
            rb.useGravity = true;

            Destroy(gameObject, 2f);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
