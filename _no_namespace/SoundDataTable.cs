[Serializable]
public class SoundDataTable // TypeDefIndex: 7045
{
	// Fields
	[SerializeField] // RVA: 0x162BD0 Offset: 0x162CD1 VA: 0x162BD0
	public Audio AudioID; // 0x10
	[SerializeField] // RVA: 0x162BE0 Offset: 0x162CE1 VA: 0x162BE0
	public Audio AudioID_Eng; // 0x14
	[SerializeField] // RVA: 0x162BF0 Offset: 0x162CF1 VA: 0x162BF0
	public SoundType SoundType; // 0x18
	[SerializeField] // RVA: 0x162C00 Offset: 0x162D01 VA: 0x162C00
	public float MinDistance; // 0x1C
	[SerializeField] // RVA: 0x162C10 Offset: 0x162D11 VA: 0x162C10
	public float MaxDistance; // 0x20
	[SerializeField] // RVA: 0x162C20 Offset: 0x162D21 VA: 0x162C20
	public bool IsLoop; // 0x24
	[SerializeField] // RVA: 0x162C30 Offset: 0x162D31 VA: 0x162C30
	public bool IsConcurrent; // 0x25
	[SerializeField] // RVA: 0x162C40 Offset: 0x162D41 VA: 0x162C40
	[RangeAttribute] // RVA: 0x162C40 Offset: 0x162D41 VA: 0x162C40
	public float Volume; // 0x28
	private static SoundDataTableArray _SoundDataTableArray; // 0x0

	// Methods

	// RVA: 0x2111F70 Offset: 0x2112071 VA: 0x2111F70
	public Audio AudioID_Lang() { }

	// RVA: 0x2111FC0 Offset: 0x21120C1 VA: 0x2111FC0
	public static SoundDataTable GetDataTable(SoundID soundID) { }

	// RVA: 0x2112120 Offset: 0x2112221 VA: 0x2112120
	public void .ctor() { }
}

