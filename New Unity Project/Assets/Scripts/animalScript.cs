using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class animalScript : MonoBehaviour {

    public GameObject animals;

	public void buttonClick()
    {
        if (animals.activeInHierarchy)
            animals.SetActive(false);
        else
            animals.SetActive(true);
    }
}
