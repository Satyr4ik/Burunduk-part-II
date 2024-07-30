using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public Animator anim;
    public bool ChekAnim = true;
    public bool HeadUp;
    public Transform HeadCheck;
    public float checkRadius = 0.3f;
    public LayerMask Head;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DamageEnemy();
    }
    void DamageEnemy()
    {
        HeadUp = Physics2D.OverlapCircle(HeadCheck.position, checkRadius, Head);
        if (HeadUp == true)
        {
            anim.SetBool("Death", HeadUp);
            gameObject.GetComponent<Collider2D>().enabled = false;
            ChekAnim = false;
        }
    }  
    void Death()
    {
        
        if (ChekAnim == false)  
        Destroy(gameObject);
    }
}
