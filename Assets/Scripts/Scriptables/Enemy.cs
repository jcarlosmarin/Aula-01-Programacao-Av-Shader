using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Atalho para criacao de Scriptables
[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]

//Trocar de Monobehavior para ScriptableObject
public class Enemy : ScriptableObject
{
    public Material enemyMaterial;
    public int enemyLife;
    public int enemySpeed;
}
