using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DardoDiFuoco : Proiettile
{
    public DardoDiFuoco(float spd) : base(spd) { }

    public override void Lancia()
    {
        Debug.Log($"Dardo di Fuoco � stato lanciato alla velovit� di {_spd}");
    }
}