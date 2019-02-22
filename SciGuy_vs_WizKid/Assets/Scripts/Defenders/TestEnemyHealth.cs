using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestEnemyHealth : MonoBehaviour
{
    public GameObject ship;
    private Rigidbody2D m_rig;
    public float health = 3.0f;
    public bool canDie = true;
    public float speed = -3.0f;
    // Start is called before the first frame update
    private void Start()
    {
        m_rig = this.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile"))
        {
            health -= 1.0f;
            //this.gameObject.SetActive(false);
            if (canDie)
            {
                Destroy(this.gameObject);
            }
        }
        if (other.CompareTag("Lane"))
        {
            //TowerTrigger count = GetComponentInParent<TowerTrigger>();
            //count.num_enemies += 1;
        }

    }
    void Update()
    {
        
        m_rig.velocity = new Vector2(speed, 0f);
    }
}
