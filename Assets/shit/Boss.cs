using UnityEngine;

[RequireComponent(typeof(BossStats), typeof(HealthBar))]
public class Boss : MonoBehaviour
{
    BossStats bossStats;
    HealthBar healthBar;

    private void Start()
    {
        bossStats = GetComponent<BossStats>();
        healthBar = GetComponent<HealthBar>();
    }
}