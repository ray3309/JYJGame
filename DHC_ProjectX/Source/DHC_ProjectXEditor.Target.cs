// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class DHC_ProjectXEditorTarget : TargetRules
{
	public DHC_ProjectXEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "DHC_ProjectX" } );
	}
}
