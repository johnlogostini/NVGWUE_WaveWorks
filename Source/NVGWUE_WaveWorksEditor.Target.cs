// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class NVGWUE_WaveWorksEditorTarget : TargetRules
{
	public NVGWUE_WaveWorksEditorTarget(TargetInfo Target) : base(Target)
    {
		Type = TargetType.Editor;

        ExtraModuleNames.Add("NVGWUE_WaveWorks");
    }
}
