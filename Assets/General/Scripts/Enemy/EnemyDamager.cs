using UnityEngine;

public class EnemyDamager : MonoBehaviour
{
    public int damagePower = 2;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit : " + other.gameObject.tag);

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit player");
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damagePower);
        }
    }
}
