using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICreature
{
    public static ICreature GetCreature(CreatureRequirements requirements)
    {
        CreatureFactory factory = new CreatureFactory(requirements);
        return factory.Create();
    }
}

public class MaleHero : ICreature { }
public class FemaleHero : ICreature { }

public class MaleGunner : ICreature { }
public class FemaleGunner: ICreature { }

public class DogKnight : ICreature { }

public class Slime : ICreature { }
public class Bat : ICreature { }
public class Ghost : ICreature { }
