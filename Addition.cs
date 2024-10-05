using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Variables globales
    public int Number;

    // Start is called before the first frame update
    void Start()
    {
        getAddition(Number);
    }
    private void getAddition(int number){
        //Variable local
        int numberAddiction = 0;

        if (number >= 0){
            //Bucle de suma de valores
            for (int i = 1; i<= number; i++){
                numberAddiction+=i;
            }
            Debug.Log("La suma de los números entre 1 y el número " + number + " es " + numberAddiction + ".");
        }else{
            Debug.Log("El número " + number + " no puede sumarse.");
        }
    }

}
