using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonHumanHeroFactory : ICreatureFactory
{
    public ICreature Create(CreatureRequirements requirements)
    {
        return new DogKnight();
    }
}
