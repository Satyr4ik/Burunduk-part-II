using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public Animator anim;
    public bool ChekAnim = true;
    public bool isActive = true;
    public int liveCount = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Вышел из колайдера");
            isActive = true;
            anim.SetBool("TakeDamage", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isActive == false) return;
        if (collision.gameObject.CompareTag("Enemy") & liveCount > 0)
        {
            
            Debug.Log("Зашел в колайдер");
            anim.SetBool("TakeDamage", true);
            liveCount--;
            isActive = false;
        }
        if (liveCount == 0)
        {
            Debug.Log("Смерть");
            anim.SetBool("Death", true);
            ChekAnim = false;

        }
    }
    void Death()
    {
        Debug.Log("Уничтожение обьекта");
        if (ChekAnim == false)
            Destroy(gameObject);
    }
}

