using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public bool isPushed;
    public GameObject Projectile;
    public GameObject spawnPoint;

    public Material defaultMaterial;
    public Material usedMaterials;
    public MeshRenderer myMr;


    private void OnCollisionEnter(Collision collision)
    {
        if (!isPushed)
        {
            isPushed = true;
            Debug.Log("Button was pushed");
            StartCoroutine(ButtonReset());
        }

    }
    IEnumerator ButtonReset()
    {
        yield return new WaitForSeconds(5);
        myMr.material = defaultMaterial;
        isPushed = false;
    }

    public void Shoot()
        

}
