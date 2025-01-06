using UnrealBuildTool;

public class test_001ClientTarget : TargetRules
{
	public test_001ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("test_001");
	}
}
