using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyData",menuName ="Enemy/Enemy Data")]
public class FlyweightEnemyDataExample : ScriptableObject
{
    private float _maxSpeed=10f;
    private float _attackRange=20f;
    private float _attackDamage=10f;
    private float _attackInterval=3f;
    private int _maxHp=100;

    public float MaxSpeed => _maxSpeed;
    public float AttackDamage => _attackDamage;
    public float AttackRange => _attackRange;
    public float AttackInterval => _attackInterval;
    public int MaxHp => _maxHp;
}
