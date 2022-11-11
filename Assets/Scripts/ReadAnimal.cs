using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimalType
{
    Dog,
    Cat,
    Bird,
    Fish
}

public class ReadAnimal : MonoBehaviour
{

    public List<AnimalSetup> animalSetup = new List<AnimalSetup>
        { new AnimalSetup("I love my cat!", AnimalType.Cat, "c"),
          new AnimalSetup("My dog is awesome!", AnimalType.Dog, "d"),
          new AnimalSetup("There was a bird flying around that tree", AnimalType.Bird, "b"),
          new AnimalSetup("This fish is nice", AnimalType.Fish, "f")
        };

    public AnimalType SelectedAnimalType;

    // Update is called once per frame
    void Update()
    {

        /*
        
        O código fica muito extenso dessa forma

        if (Input.GetKeyDown(KeyCode.D))
        {
            CheckAnimal(AnimalType.Dog);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            CheckAnimal(AnimalType.Cat);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            CheckAnimal(AnimalType.Bird);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            CheckAnimal(AnimalType.Fish);
        }
        */
        CheckAnimal();
    }

    private void CheckAnimal()
    {
        if (Input.anyKeyDown)
        {
            animalSetup?.ForEach(animal =>
            {
                if (animal.keyCode.ToLower() == Input.inputString)
                {
                    SelectedAnimalType = animal.type;
                    Debug.Log(animal.description);
                };
            });
        }
    }

    /* 
    private void CheckAnimal(AnimalType type)
    {
        
        Não vi oportunidade de usar switch nesse código, mas se fosse usar seria assim:

        switch (type)
        {
            case AnimalType.Dog:
                ReadAnimalDescription(type);
                break;
            case AnimalType.Cat:
                ReadAnimalDescription(type);
                break;
            case AnimalType.Bird:
                ReadAnimalDescription(type);
                break;
            case AnimalType.Fish:
                ReadAnimalDescription(type);
                break;
            default:
                Debug.Log("None");
                break;
        }
        
        ReadAnimalDescription(type);
        
     }

    private void ReadAnimalDescription(AnimalType type)
    {
        SelectedAnimalType = type;
        animalSetup?.ForEach(animal =>
        {
            if (animal.type == type) Debug.Log(animal.description);
        });
    }
    */
}

[System.Serializable]
public class AnimalSetup
{
    public string description;
    public AnimalType type;
    public string keyCode;

    public AnimalSetup(string description, AnimalType type, string keyCode)
    {
        this.description = description;
        this.type = type;
        this.keyCode = keyCode;
    }
}