[Serializable]
public class DualSkillDataTable // TypeDefIndex: 6947
{
	// Fields
	[SerializeField] // RVA: 0x161B90 Offset: 0x161C91 VA: 0x161B90
	public TimeLine TimeLine; // 0x10
	[SerializeField] // RVA: 0x161BA0 Offset: 0x161CA1 VA: 0x161BA0
	public MagicParamID ParamID; // 0x14
	private static DualSkillDataTableArray _DualSkillDataTableArray; // 0x0

	// Methods

	// RVA: 0x1CF3A60 Offset: 0x1CF3B61 VA: 0x1CF3A60
	public static DualSkillDataTable GetDataTable(ActorID actor_id) { }

	// RVA: 0x1CF3C00 Offset: 0x1CF3D01 VA: 0x1CF3C00
	public static bool HasDataTable(ActorID actor_id) { }

	// RVA: 0x1CF3BF0 Offset: 0x1CF3CF1 VA: 0x1CF3BF0
	public void .ctor() { }
}

