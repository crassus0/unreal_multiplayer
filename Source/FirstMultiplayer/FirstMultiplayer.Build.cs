// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FirstMultiplayer : ModuleRules
{
	public FirstMultiplayer(ReadOnlyTargetRules Target) : base(Target)
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
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"FirstMultiplayer",
			"FirstMultiplayer/Variant_Platforming",
			"FirstMultiplayer/Variant_Platforming/Animation",
			"FirstMultiplayer/Variant_Combat",
			"FirstMultiplayer/Variant_Combat/AI",
			"FirstMultiplayer/Variant_Combat/Animation",
			"FirstMultiplayer/Variant_Combat/Gameplay",
			"FirstMultiplayer/Variant_Combat/Interfaces",
			"FirstMultiplayer/Variant_Combat/UI",
			"FirstMultiplayer/Variant_SideScrolling",
			"FirstMultiplayer/Variant_SideScrolling/AI",
			"FirstMultiplayer/Variant_SideScrolling/Gameplay",
			"FirstMultiplayer/Variant_SideScrolling/Interfaces",
			"FirstMultiplayer/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
