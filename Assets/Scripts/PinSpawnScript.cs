using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pinPrefab;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            SpawnPin();
        }
    }

    void SpawnPin() {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
