using UnrealBuildTool;

public class unrealEditorTarget : TargetRules
{
	public unrealEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("unreal");
	}
}
