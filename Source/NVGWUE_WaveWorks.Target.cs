// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class NVGWUE_WaveWorksTarget : TargetRules
{
	public NVGWUE_WaveWorksTarget(TargetInfo Target) : base(Target)
    {
		Type = TargetType.Game;

        ExtraModuleNames.Add("NVGWUE_WaveWorks");
    }
}
