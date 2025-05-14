using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaProiettili : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       List<Proiettile> ListaProiettili = new List<Proiettile>();
        ListaProiettili.Add(new DardoDiFuoco(10));
        ListaProiettili.Add(new DardoMagico(7));

        //for (int i = 0; i < ListaProiettili.Count; i++)
        //{
        //    ListaProiettili[i].Lancia();
        //}

        foreach (Proiettile i in ListaProiettili) //per ogni oggetto dentro questa lista, chiamami Lancia(), sostituisce "for" e tutto il resto che c'è sopra
        {
            i.Lancia();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
