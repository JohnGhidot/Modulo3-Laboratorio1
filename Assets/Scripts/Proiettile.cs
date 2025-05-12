using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Proiettile
{
    protected float _spd;

    public Proiettile (float spd)
    {
        _spd = spd;
    }

    public abstract void Lancia();
}