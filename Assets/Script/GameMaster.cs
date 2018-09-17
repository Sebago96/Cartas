using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameMaster : MonoBehaviour {
    [SerializeField]
    Transform[] spawnPoints;
    [SerializeField]
    Material monkeyNumberMaterial;
    [SerializeField]
    Material cowNumberMaterial;
    [SerializeField]
    Material dogNumberMaterial;
    private int monkey;
    private int cow;
    private int dog;
    [SerializeField]
    Texture[] numberTextures;
    [SerializeField]
    GameObject[] playingCards;

    public int Monkey
    {
        get
        {
            return monkey;
        }

        set
        {
            monkey = value;
        }
    }

    public int Cow
    {
        get
        {
            return cow;
        }

        set
        {
            cow = value;
        }
    }

    public int Dog
    {
        get
        {
            return dog;
        }

        set
        {
            dog = value;
        }
    }

    // Use this for initialization
    void Start () {
        initializeGame();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void initializeGame()
    {
        this.monkey = Random.Range(0, 4);
        this.dog = Random.Range(0, 4);
        this.cow = Random.Range(0, 4);
        this.monkeyNumberMaterial.SetTexture("_MainTex", numberTexture(this.monkey));
        this.cowNumberMaterial.SetTexture("_MainTex", numberTexture(this.cow));
        this.dogNumberMaterial.SetTexture("_MainTex", numberTexture(this.dog));
        for (int i = 0; i < 9; i++) {
            Instantiate(playingCards[Random.Range(0, 3)], spawnPoints[i]);
        }

    }
    public Texture numberTexture(int number) {
        switch (number) {
            case 1:
                return numberTextures[0];
                break;
            case 2:
                return numberTextures[1];
                break;
            case 3:
                return numberTextures[2];
                break;
            default:
                return numberTextures[0];

        }
    }
}
