using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeDamage : MonoBehaviour
{
    public float attack;
    // Start is called before the first frame update
    void Start()
    {
        attack = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DamageOverTime(float attackSpeed)
    {
        while(gameObject.GetComponent<AttackerColliderHealth>().health > 0)
        {
            Debug.Log("Did damage");
            yield return new WaitForSeconds(attackSpeed);
        }
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Defender")
        {
            StartCoroutine(DamageOverTime(attack));
        }
    }
}
