// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OutSideAction : ModuleRules
{
	public OutSideAction(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
			}
		);

        PublicIncludePathModuleNames.AddRange(
            new string[] {
            }
        );
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				// ... add private dependencies that you statically link with here ...
			}
		);
	}
}
