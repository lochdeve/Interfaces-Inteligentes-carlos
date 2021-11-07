using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonPlay : MonoBehaviour
{
   public Button botonPublico;
    public AudioSource grabacion;
    void Start()
    {
        Button boton = botonPublico.GetComponent<Button>();
		boton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
       // grabacion = GetComponent<AudioSource>();
       if (grabacion.clip != null)
       {
         grabacion.Play();
       }else {
           Debug.Log("No hay grabacion disponible");
       }
	}
}

