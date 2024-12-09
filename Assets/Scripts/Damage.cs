using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public Animator anim;
    public bool ChekAnim = true;
    private int damage = 2;     //  олайдер врага отвечающий за регистрацию урона

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D head)
    {
        if (head.gameObject.name == "GroundCheck")
        {
            Debug.Log(head.gameObject.name);
            anim.SetBool("Death", true);
            gameObject.GetComponent<Collider2D>().enabled = false;
            transform.GetChild(damage).gameObject.SetActive(false);
            ChekAnim = false;
        }
    }
    void Death()
    {
        
        if (ChekAnim == false)  
        Destroy(gameObject);
    }
}
