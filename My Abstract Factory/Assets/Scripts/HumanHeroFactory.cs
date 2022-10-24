using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanHeroFactory : ICreatureFactory
{
    public ICreature Create(CreatureRequirements requirements)
    {
        if (requirements.fightType == "Hero")
        {
            if(requirements.isMale)
            {
                return new MaleHero();
            }
            return new FemaleHero();
        }
        else
        {
            if (requirements.isMale)
            {
                return new MaleGunner();
            }
            return new FemaleGunner();
        }
    }
}
