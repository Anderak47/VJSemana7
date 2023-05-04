using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearManzanaController : MonoBehaviour
{
    float timer;
    public GameObject manzanaPrefab;
    void Start()
    {

    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            timer = 0;
            float x = Random.Range(60f,70f);
            var position = new Vector3(x, -2, 0);
            Instantiate(manzanaPrefab, position, Quaternion.identity);
        }

    }
}
