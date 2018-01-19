// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class DHC_ProjectXTarget : TargetRules
{
	public DHC_ProjectXTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "DHC_ProjectX" } );
	}
}
