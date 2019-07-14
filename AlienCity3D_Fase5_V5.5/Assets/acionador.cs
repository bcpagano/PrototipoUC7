using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acionador : MonoBehaviour
{
    public estala1 estala;
    public estala1 estala2;
    public estala1 estala3;
    public estala1 estala4;
    public estala1 estala5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            Debug.Log("armadilha");
            estala.Fallen();
        estala2.Fallen();
        estala3.Fallen();
        estala4.Fallen();
        estala5.Fallen();
        Destroy(gameObject, 2f);
    }
        
}
