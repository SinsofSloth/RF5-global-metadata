[Serializable]
public class PersonalMotionDataTable // TypeDefIndex: 7026
{
	// Fields
	[SerializeField] // RVA: 0x162890 Offset: 0x162991 VA: 0x162890
	public float StartTime; // 0x10
	[SerializeField] // RVA: 0x1628A0 Offset: 0x1629A1 VA: 0x1628A0
	public int VoiceFrequency; // 0x14
	[SerializeField] // RVA: 0x1628B0 Offset: 0x1629B1 VA: 0x1628B0
	public float EndTransition; // 0x18
	[SerializeField] // RVA: 0x1628C0 Offset: 0x1629C1 VA: 0x1628C0
	public List<PesronalMotionPlayData> PlayDatas; // 0x20
	private static PersonalMotionDataTableArray _PersonalMotionDataTableArray; // 0x0

	// Methods

	// RVA: 0x1FE2260 Offset: 0x1FE2361 VA: 0x1FE2260
	public static PersonalMotionDataTable GetDataTable(CharID charID) { }

	// RVA: 0x1FE23E0 Offset: 0x1FE24E1 VA: 0x1FE23E0
	public static bool HasDataTable(CharID charID) { }

	// RVA: 0x1FE2520 Offset: 0x1FE2621 VA: 0x1FE2520
	public void .ctor() { }
}

