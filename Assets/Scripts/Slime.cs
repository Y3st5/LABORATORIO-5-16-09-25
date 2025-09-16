using Unity.VisualScripting;
using UnityEngine;
//En slime implementa un constructor sobrecargado de operadores que permita sumar su vida con otro slime para crear uno nuevo
public class Slime
{
    public int Life;

    public Slime(int _Life)
    {
        Life = _Life;
    }

    public static Slime operator +(Slime s1, Slime s2)
    {
        return new Slime(s1.Life + s2.Life);
    }
}
