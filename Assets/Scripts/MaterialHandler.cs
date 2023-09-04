using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialHandler : MonoBehaviour
{
    public MeshRenderer playerMeshRenderer;

    public void SelectMaterial(Material selectedMaterial)
    {
        playerMeshRenderer.material = selectedMaterial;

        //Salvar material escolhido no Singleton;
        GameManager.instance.playerMaterial = selectedMaterial;
    }
}
