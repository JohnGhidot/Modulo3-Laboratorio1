using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string Nome { get; set; }
    public int Vita { get; set; }
    public int Damage { get; set; }

    
    public abstract void Attack();
    public abstract void TakeDamage(int damage);

    public Character(string nome, int vita, int damage)
    {
        this.Nome = nome;
        this.Vita = vita;
        Damage = damage;
    }
}
