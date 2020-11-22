using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolcanoControlScript : MonoBehaviour
{
    [SerializeField]
    ParticleSystem smokeUp;

    [SerializeField]
    float smokeUpMinEmission = 1.00f;
    float smokeUpCurrentEmission = 0.0f;
    [SerializeField]
    float smokeUpMaxEmission = 10.0f;
    [SerializeField]
    float smokeUpEmissionSpeed = 10.0f;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            smokeUpCurrentEmission += Time.deltaTime * smokeUpEmissionSpeed;
        }
        else
        {
            smokeUpCurrentEmission -= Time.deltaTime * smokeUpEmissionSpeed;
        }

        smokeUpCurrentEmission = Mathf.Clamp(smokeUpCurrentEmission, smokeUpMinEmission, smokeUpMaxEmission);
        var emission = smokeUp.emission;
        emission.rateOverTime = smokeUpCurrentEmission;


    }


}
