using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Character> Characters = new List<Character>();     //Crea lista di Character
        Characters.Add(new Mage("Baradun", 107, 7));               //Aggiungo nuovi Character e gli assegno i relativi oggetti (Mage, Warrior o Archer)
        Characters.Add(new Archer("Bob", 115, 9));
        Characters.Add(new Warrior("Bodger", 126, 12));

        foreach (Character character in Characters)             //Per ogni (foreach) character dentro la lista chiama il metodo Attack() e TakeDamage(int)
        {
            Debug.Log($"{character.Nome} ha {character.Vita} di vita prima dell'attacco");

            character.Attack();

            Debug.Log($"{character.Nome} ha {character.Vita} di vita, dopo l'attacco");

            character.TakeDamage((int)Random.Range(0, 20));     //A TakeDamage sto passando un numero randomico da 1 a 20
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
