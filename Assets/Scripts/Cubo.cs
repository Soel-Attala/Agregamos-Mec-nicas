using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public int Health = 100;
    private int velocidad = 2;
    private float direccion;

    
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        MovimientoJugador();

        if (Input.GetKeyDown(KeyCode.R))
        Damage();

        Death();

        if(Input.GetKeyDown(KeyCode.E))
        Heal();
        
        Invencible();

        if(Input.GetKeyDown(KeyCode.Q))
        Speed();
        
        if(Input.GetKeyDown(KeyCode.A))
        Direccion();
        
    }

    void MovimientoJugador()
    {
        transform.position += new Vector3(1,0,0);
    }

    void Damage()
    {
        Health = Health - 25;
    }

    void Heal()
    {
        Health = Health + 10;
    }

    public void Death()
    {
        if (Health <= 0) Destroy(gameObject);
    }

    public void Invencible()
    {
        if (Health == 150)
        GetComponent<Renderer>().material.color = Color. blue;
    }

    void Speed ()
    {
        transform.position += new Vector3(5,0,0);
    }

    void Direccion()
    {
        transform.position += new Vector3(-3,0,0);
    }

}
