using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private GameObject turretToBuild;

    public GameObject turretPrefab;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;
    }

    private void Start()
    {
        turretToBuild = turretPrefab;
    }

    public GameObject getTurretToBuilt()
    {
        return turretToBuild;
    }
}
