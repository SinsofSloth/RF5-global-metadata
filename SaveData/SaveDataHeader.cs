public class SaveDataHeader // TypeDefIndex: 9916
{
	// Fields
	public const int SIZE = 32;
	public ulong UID; // 0x10
	public uint Version; // 0x18
	public char[] Project; // 0x20
	public uint WCnt; // 0x28
	public uint WOpt; // 0x2C
	private SaveTime SaveTime; // 0x30

	// Properties
	public bool IsEncryption { get; }

	// Methods

	// RVA: 0x20F78C0 Offset: 0x20F79C1 VA: 0x20F78C0
	private bool ReadCheck(BinaryReader reader) { }

	// RVA: 0x20F6670 Offset: 0x20F6771 VA: 0x20F6670
	public void .ctor() { }

	// RVA: 0x20F6710 Offset: 0x20F6811 VA: 0x20F6710
	public void Initialize(uint version) { }

	// RVA: 0x20F6880 Offset: 0x20F6981 VA: 0x20F6880
	public void Update(uint version) { }

	// RVA: 0x20F6C70 Offset: 0x20F6D71 VA: 0x20F6C70
	public void Write(BinaryWriter writer) { }

	// RVA: 0x20F72A0 Offset: 0x20F73A1 VA: 0x20F72A0
	public void Read(BinaryReader reader) { }

	// RVA: 0x20F7910 Offset: 0x20F7A11 VA: 0x20F7910
	public void SetSaveTime(DateTime dateTime) { }

	// RVA: 0x20F6D80 Offset: 0x20F6E81 VA: 0x20F6D80
	public bool get_IsEncryption() { }

	// RVA: 0x20F79D0 Offset: 0x20F7AD1 VA: 0x20F79D0
	public DateTime GetSaveTime() { }
}

