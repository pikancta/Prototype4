using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangePickUp : MonoBehaviour
{
    [Header("Materials")]
    public Material defaultMaterial;
    public Material newMaterial;

    [Header("Duration")]
    public float duration;

    //Components

    private MeshRenderer myMr;
    private MeshRenderer playerMr;
    private Collider myCollider;


    // Start is called before the first frame update
    void Start()
    {
        myMr = GetComponent<MeshRenderer>();
        myCollider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerMr = other.gameObject.GetComponent<MeshRenderer>();
            myCollider.enabled = false;
            playerMr.material = newMaterial;
            StartCoroutine(ColorReset());
        }
    }
    IEnumerator ColorReset()
    {
        yield return new WaitForSeconds(duration);
        playerMr.material = defaultMaterial;
        myCollider.enabled = true;
    }
}
