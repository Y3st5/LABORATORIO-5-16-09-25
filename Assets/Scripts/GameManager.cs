using UnityEngine;
//En slime implementa un constructor sobrecargado de operadores que permita sumar su vida con otro slime para crear uno nuevo
public class GameManager : MonoBehaviour
{
    public Slime Slime1 = new(15) ;
    public Slime Slime2 = new(10) ;
    public Slime Slime3 = new(10);

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}
