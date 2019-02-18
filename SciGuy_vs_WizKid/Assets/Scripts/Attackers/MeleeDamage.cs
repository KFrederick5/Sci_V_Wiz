using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeDamage : MonoBehaviour
{
    public float atkSpeed;
    public float atkDmg;
    // Start is called before the first frame update
    void Start()
    {
        atkSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DamageOverTime(float attackSpeed, Collider2D tower)
    {
        while(gameObject.GetComponent<AttackerColliderHealth>().currentHealth > 0)
        {
            TowerHealth towerHealthScript = tower.GetComponent<TowerHealth>();
            towerHealthScript.health -= atkDmg;
            Debug.Log("An enemy did damage");
            yield return new WaitForSeconds(attackSpeed);
        }
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Tower")
        {
            StartCoroutine(DamageOverTime(atkSpeed, coll));
        }
    }
}
