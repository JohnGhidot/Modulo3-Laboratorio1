using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DardoMagico : Proiettile
{
    public DardoMagico(float spd) : base(spd)  { }

    public override void Lancia()
    {
        Debug.Log($"Dardo Magico è stato lanciato alla velocità di {_spd} m/s");
    }
}