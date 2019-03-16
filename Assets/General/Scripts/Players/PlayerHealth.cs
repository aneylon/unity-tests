using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 20;

    public void TakeDamage(int damageAmmount)
    {
        Debug.Log("Take that!  " + damageAmmount );
        health -= damageAmmount;
    }

    private void Die()
    {
        Debug.Log("Ded!");
    }

    private void Update()
    {
        if(health <= 0)
        {
            Debug.Log("Time to die!");
            Die();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit : " + other.gameObject.tag);
    }
}
