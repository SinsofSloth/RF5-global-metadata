[Serializable]
public class FarmSupportMonsterData : SaveDataValueBase // TypeDefIndex: 8046
{
	// Fields
	[SerializeField] // RVA: 0x169F70 Offset: 0x16A071 VA: 0x169F70
	public uint FriendMonsterDataID; // 0x10
	[SerializeField] // RVA: 0x169F80 Offset: 0x16A081 VA: 0x169F80
	public FarmSupportState State; // 0x14
	[SerializeField] // RVA: 0x169F90 Offset: 0x16A091 VA: 0x169F90
	public int WorkTime; // 0x18
	[SerializeField] // RVA: 0x169FA0 Offset: 0x16A0A1 VA: 0x169FA0
	public int CellIndex; // 0x1C
	[SerializeField] // RVA: 0x169FB0 Offset: 0x16A0B1 VA: 0x169FB0
	public Vector3 Position; // 0x20
	[SerializeField] // RVA: 0x169FC0 Offset: 0x16A0C1 VA: 0x169FC0
	public Quaternion Rotation; // 0x2C

	// Properties
	public bool Used { get; }

	// Methods

	// RVA: 0x2033A50 Offset: 0x2033B51 VA: 0x2033A50
	public bool get_Used() { }

	// RVA: 0x2033A60 Offset: 0x2033B61 VA: 0x2033A60
	public void .ctor() { }

	// RVA: 0x2033A90 Offset: 0x2033B91 VA: 0x2033A90
	public void Set(uint friendMonsterDataID, FarmSupportState farmSupportState, int workTime, int cellIndex, Vector3 position, Quaternion rotation) { }

	// RVA: 0x2033AC0 Offset: 0x2033BC1 VA: 0x2033AC0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x2033B90 Offset: 0x2033C91 VA: 0x2033B90 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x2033BA0 Offset: 0x2033CA1 VA: 0x2033BA0 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x2033BB0 Offset: 0x2033CB1 VA: 0x2033BB0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x2033C90 Offset: 0x2033D91 VA: 0x2033C90
	public void Reader0000(BinaryReader reader) { }
}

