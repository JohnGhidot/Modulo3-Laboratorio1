using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Proiettile
{
    protected float _spd;

    public abstract void Lancia();

    public Proiettile (float spd)
    {
        this._spd = spd;
    }
}