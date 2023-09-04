using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public Enemy enemyType;

    public CharacterController enemyController;
    public MeshRenderer enemyMeshRender;
    public Transform enemyTransform;

    Transform playerTransform;
    int speed;
    int life;

    void Start()
    {
        //Trocar aparencia do inimigo
        enemyMeshRender.material = enemyType.enemyMaterial;

        //Salvar suas variaveis em variaveis locais
        speed = enemyType.enemySpeed;
        life = enemyType.enemyLife;

        //Encontrar o player para a movimentacao
        playerTransform = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (playerTransform != null)
        {
            //Encontrar a direcao do player
            var direction = playerTransform.position - enemyTransform.position;
            direction.Normalize();

            //Andar na direcao do player
            enemyTransform.LookAt(playerTransform);
            enemyController.Move(speed * Time.deltaTime * direction);
        }
    }
}
