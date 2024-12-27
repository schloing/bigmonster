using UnityEngine;

public class BossStats : MonoBehaviour
{
    public int level;
    public int currStage;
    public int stages;
    public int[] maxHealth;
    public int health;
    public float moveSpeed;
    public float motorSpeed;
    public float stunPeriod;

    private void Start()
    {
        currStage = 0;
        health = maxHealth[currStage];
    }
}
