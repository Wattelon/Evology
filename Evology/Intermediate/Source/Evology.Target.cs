using UnrealBuildTool;

public class EvologyTarget : TargetRules
{
	public EvologyTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Evology");
	}
}
