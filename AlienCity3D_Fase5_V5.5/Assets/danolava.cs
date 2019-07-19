using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danolava : MonoBehaviour
{
    public bool isDamaging;
    public float damage = 10;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if(other.tag =="Player")
            other.SendMessage((isDamaging) ?"TakeDamage":"HealDamage",Time.deltaTime * damage);
        Handheld.Vibrate();
    }
}
