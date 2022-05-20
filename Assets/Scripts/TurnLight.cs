using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{
    public GameObject directionalLight;
    public GameObject lampLight;
    public GameObject spotLight;
    public GameObject bathroomLight;

    public bool isLightActive;

    // Start is called before the first frame update
    void Start()
    {
        isLightActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            isLightActive = !isLightActive;
        }
        directionalLight.SetActive(isLightActive);
        lampLight.SetActive(!isLightActive);
        spotLight.SetActive(!isLightActive);
        bathroomLight.SetActive(!isLightActive);
    }
}
