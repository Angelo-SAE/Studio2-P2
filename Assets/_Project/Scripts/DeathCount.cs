using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCount : MonoBehaviour
{
    private TMP_Text textObject;

    void Start()
    {
      textObject = GetComponent<TMP_Text>();
    }

    void Update()
    {
      textObject.text = StaticTotalDeaths.deathCount.ToString();
    }
}
