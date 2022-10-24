using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CreatureCreation : MonoBehaviour
{
    CreatureRequirements requirements;
    public Button createButton;
    public Toggle monsterToggle;
    public Toggle humanToggle;
    public Toggle maleToggle;
    public TMP_Dropdown fightTypeDropdown;

    public GameObject dogKnight;
    public GameObject maleHero;
    public GameObject femaleHero;
    public GameObject maleGunner;
    public GameObject femaleGunner;
    public GameObject ghost;
    public GameObject bat;
    public GameObject slime;

    public void Start()
    {
        requirements = new CreatureRequirements();
    }

    public void OnMonsterToggleChanged()
    {
        requirements.isMonster = monsterToggle.isOn;
    }
    public void OnHumanToggleChanged()
    {
        requirements.isHuman = humanToggle.isOn;
    }
    public void OnMaleToggleChanged()
    {
        requirements.isMale = maleToggle.isOn;
    }
    public void OnFightTypeSelected()
    {
        requirements.fightType = fightTypeDropdown.captionText.text;
    }
    public void OnCreateCreature()
    {
        ICreature creature = GetCreature(requirements);
        if(creature.ToString() == "DogKnight")
        {
            Instantiate(dogKnight);
        }
        else if(creature.ToString() == "MaleHero")
        {
            Instantiate(maleHero);
        }
        else if(creature.ToString() == "FemaleHero")
        {
            Instantiate(femaleHero);
        }
        else if(creature.ToString() == "MaleGunner")
        {
            Instantiate(maleGunner);
        }
        else if (creature.ToString() == "FemaleGunner")
        {
            Instantiate(femaleGunner);
        }
        else if (creature.ToString() == "Slime")
        {
            Instantiate(slime);
        }
        else if (creature.ToString() == "Bat")
        {
            Instantiate(bat);
        }
        else
        {
            Instantiate(ghost);
        }
        Debug.Log(creature);
    }
    public ICreature GetCreature(CreatureRequirements requirements)
    {
        CreatureFactory factory = new CreatureFactory(requirements);
        return factory.Create();
    }
}
