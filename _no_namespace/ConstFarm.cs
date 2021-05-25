public class ConstFarm : ScriptableObject // TypeDefIndex: 6932
{
	// Fields
	[SerializeField] // RVA: 0x161790 Offset: 0x161891 VA: 0x161790
	public int MonsterHut_AppealLoveLevel; // 0x18
	[SerializeField] // RVA: 0x1617A0 Offset: 0x1618A1 VA: 0x1617A0
	public int MonsterHut_FriendLoveLevel; // 0x1C
	[SerializeField] // RVA: 0x1617B0 Offset: 0x1618B1 VA: 0x1617B0
	public int MonsterHut_EscapeLoveLevel; // 0x20
	[SerializeField] // RVA: 0x1617C0 Offset: 0x1618C1 VA: 0x1617C0
	public float MonsterHut_MinWaitTime; // 0x24
	[SerializeField] // RVA: 0x1617D0 Offset: 0x1618D1 VA: 0x1617D0
	public float MonsterHut_MaxWaitTime; // 0x28
	[SerializeField] // RVA: 0x1617E0 Offset: 0x1618E1 VA: 0x1617E0
	public float MonsterHut_WanderRange; // 0x2C
	[SerializeField] // RVA: 0x1617F0 Offset: 0x1618F1 VA: 0x1617F0
	public float MonsterHut_EscapeRange; // 0x30
	[SerializeField] // RVA: 0x161800 Offset: 0x161901 VA: 0x161800
	public float MonsterHut_AppealRange; // 0x34
	[SerializeField] // RVA: 0x161810 Offset: 0x161911 VA: 0x161810
	public int MonsterHut_TiredHPPercent; // 0x38
	[SerializeField] // RVA: 0x161820 Offset: 0x161921 VA: 0x161820
	public int Esa_Power; // 0x3C
	[SerializeField] // RVA: 0x161830 Offset: 0x161931 VA: 0x161830
	public int WorkCost_MaxHpRatio; // 0x40
	[SerializeField] // RVA: 0x161840 Offset: 0x161941 VA: 0x161840
	public int Farm_WorkCost; // 0x44
	[SerializeField] // RVA: 0x161850 Offset: 0x161951 VA: 0x161850
	public int Farm_WorkSeedCost; // 0x48
	[SerializeField] // RVA: 0x161860 Offset: 0x161961 VA: 0x161860
	public int NotTask_WanderRate; // 0x4C
	[SerializeField] // RVA: 0x161870 Offset: 0x161971 VA: 0x161870
	public int NotTask_WaitRate; // 0x50
	[SerializeField] // RVA: 0x161880 Offset: 0x161981 VA: 0x161880
	public float NotTask_MaxWaitTime; // 0x54
	[SerializeField] // RVA: 0x161890 Offset: 0x161991 VA: 0x161890
	public float NotTask_MinWaitTime; // 0x58
	[SerializeField] // RVA: 0x1618A0 Offset: 0x1619A1 VA: 0x1618A0
	public int MaxRandomCutWoolDropCount_Enemy; // 0x5C
	[SerializeField] // RVA: 0x1618B0 Offset: 0x1619B1 VA: 0x1618B0
	public int MaxRandomCutWoolDropCount_Friend; // 0x60
	public const int FarmActionIndex = 200;
	private static ConstFarm _Instance; // 0x0

	// Properties
	public static ConstFarm Instance { get; }

	// Methods

	// RVA: 0x1FCA490 Offset: 0x1FCA591 VA: 0x1FCA490
	public static ConstFarm get_Instance() { }

	// RVA: 0x1FCA5A0 Offset: 0x1FCA6A1 VA: 0x1FCA5A0
	public void .ctor() { }
}

