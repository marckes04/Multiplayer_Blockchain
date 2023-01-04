using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int m_health;

    public int m_maxhealth = 100;

    [SerializeField]
    private Image m_healthBar;

    void Awake() {
        m_health = m_maxhealth;
    }

    public void TakeDamage(int damage){
        m_health -= damage;
        if(m_health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
