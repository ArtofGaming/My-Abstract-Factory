using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFactory : ICreatureFactory
{
    public ICreature Create(CreatureRequirements requirements)
    {
        switch (requirements.fightType)
        {
            case "Slime":
                return new Slime();
            case "Bat":
                return new Bat();
            case "Ghost":
                return new Ghost();
            default:
                return new Slime();
        }
    }
    public void Show(ICreature creature)
    {
        Debug.Log(creature);
    }

}
