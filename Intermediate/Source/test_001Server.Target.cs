using UnrealBuildTool;

public class test_001ServerTarget : TargetRules
{
	public test_001ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("test_001");
	}
}
