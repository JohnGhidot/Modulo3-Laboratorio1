using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character //scaglia due frecce
{
    public Archer(string nome, int vita, int danno) : base(nome, vita, danno) { }
    public override void Attack()
    {
        int numeroFreccia = 2;

        for (int i = 0; i < numeroFreccia; i++)
        {
            Debug.Log($"{Nome} scaglia la freccia {i + 1} provocando {Damage} danni"); //con i che parte da 0, il ciclo for parte da 0 e poi finisce con 1 se non metto {i + 1}
        }
    }
    public override void TakeDamage(int dmg)
    {
     
        Vita -= dmg;
        Debug.Log($"{Nome} subisce {dmg} danni ed ora ha {Vita} di vita");
       
    }        
}

