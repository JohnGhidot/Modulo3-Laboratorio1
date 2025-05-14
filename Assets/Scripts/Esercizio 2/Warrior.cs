using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class Warrior : Character
{
    public Warrior(string nome, int vita, int danno) : base(nome, vita, danno) { }
    public override void Attack()
    {
        Debug.Log($"{Nome} ha attaccato provocando {Damage} danni");
    }

    public override void TakeDamage(int dmg)
    {
        Vita -= dmg;
        Debug.Log($"{Nome} subisce {dmg} danni ed ora ha {Vita} di vita");
    }




}