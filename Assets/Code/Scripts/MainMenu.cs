using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria que permite cambiar entre escenas

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo que usamos desde el boton de Play para ir a la escena del juego
    public void ChangeScene() 
    {
        //Carga la escena con ese nombre
        SceneManager.LoadScene("Game");
    }
}
