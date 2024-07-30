using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public Animator anim;
    public bool ChekAnim = true;
    public bool Damage;
    public Transform DamageCheck;
    public float checkRadius = 0.5f;
    public LayerMask Enemy;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckDamage();
    }

    void CheckDamage()
    {
        Damage = Physics2D.OverlapCircle(DamageCheck.position, checkRadius, Enemy);
        anim.SetBool("TakeDamage", Damage);
        ChekAnim = false;
    }

    void Death()
    {

        if (ChekAnim == false)
            Destroy(gameObject);
    }
}

