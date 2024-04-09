using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using JetBrains.Annotations;
using UnityEngine;

public class ScenePersist : MonoBehaviour
{
    void Awake()
    {
        int numScenePersists = FindObjectsOfType<ScenePersist>().Length;

        if(numScenePersists > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }
    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
}
