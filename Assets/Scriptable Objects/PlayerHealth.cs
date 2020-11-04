using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Player/Health")]
public class PlayerHealth : ScriptableObject
{
    public delegate void HealthEvent(int health);
    public event HealthEvent OnHealthChange;
    public event HealthEvent OnPlayerDead;

    [SerializeField]
    private int _maxHealth;
    public int MaxHealth{
        get {return _maxHealth;}
    }

    private int _health;

    public int Health{
        get{return _health;}
    }

    public void Alive(){
        _health = MaxHealth;
    }

    public void TakeHit(){
        _health--;
        OnHealthChange?.Invoke(_health);
    }
}
