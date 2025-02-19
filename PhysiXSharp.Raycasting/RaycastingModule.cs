﻿using PhysiXSharp.Core;
using PhysiXSharp.Core.ModuleInterfaces;

namespace PhysiXSharp.Raycasting;

public class RaycastingModule : IPhysiXModule
{
    public void Initialize()
    {
        PhysiX.Logger.Log("Ray casting module successfully loaded!");
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}