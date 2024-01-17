using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaMaoPiscando : MonoBehaviour
{
    private SpriteRenderer maozinha;
    // Start is called before the first frame update
    void Awake()
    {
        this.maozinha = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Desaparecer();
        }
    }

    private void Desaparecer()
    {
        maozinha.enabled = false;
    }
}
