// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class WhiteMoon : ModuleRules
{
	public WhiteMoon(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"WhiteMoon",
			"WhiteMoon/Variant_Platforming",
			"WhiteMoon/Variant_Combat",
			"WhiteMoon/Variant_Combat/AI",
			"WhiteMoon/Variant_SideScrolling",
			"WhiteMoon/Variant_SideScrolling/Gameplay",
			"WhiteMoon/Variant_SideScrolling/AI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
