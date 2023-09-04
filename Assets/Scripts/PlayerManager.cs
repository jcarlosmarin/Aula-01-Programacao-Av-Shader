using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Transform playerTransform;
    public MeshRenderer playerMeshRenderer;
    public CharacterController playerController;

    public int speed;

    void Start()
    {
        //Aplicar o material no player no começo do jogo
        if (GameManager.instance.playerMaterial != null)
        {
            playerMeshRenderer.material = GameManager.instance.playerMaterial;
        }     
    }

    private void Update()
    {
        //Movimentacao do player
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            playerController.Move(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime));
        }
    }

}
