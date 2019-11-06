using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouge : MonoBehaviour {

    public Vector3 wantedPositon;
    Vector3 go = new Vector3(0, 0, 0);//La position désirée
    public bool useLerp = false;         //Si on utilise la fonction Lerp dans notre Update
    public float speed = 10f;            //La vitesse de déplacement si on utilise MoveToward
    public float damping = 1f;            //Le facteur du lerp
                                          //damping = 0 -> L'ojet ne se déplacera pas
                                          //damping = 1000 -> L'objet ira à la position instantanement

    void Start()
    {
         //Pour que l'objet soit à sa place initiale dans la scene
        go = new Vector3(100, 100, 100);
        wantedPositon = go;
    }

    void Update()
    {
            transform.position = Vector3.MoveTowards(transform.position, wantedPositon, speed * Time.deltaTime);
    }
}
