// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AnimationFinal : ModuleRules
{
	public AnimationFinal(ReadOnlyTargetRules Target) : base(Target)
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
			"AnimationFinal",
			"AnimationFinal/Variant_Platforming",
			"AnimationFinal/Variant_Platforming/Animation",
			"AnimationFinal/Variant_Combat",
			"AnimationFinal/Variant_Combat/AI",
			"AnimationFinal/Variant_Combat/Animation",
			"AnimationFinal/Variant_Combat/Gameplay",
			"AnimationFinal/Variant_Combat/Interfaces",
			"AnimationFinal/Variant_Combat/UI",
			"AnimationFinal/Variant_SideScrolling",
			"AnimationFinal/Variant_SideScrolling/AI",
			"AnimationFinal/Variant_SideScrolling/Gameplay",
			"AnimationFinal/Variant_SideScrolling/Interfaces",
			"AnimationFinal/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
