[Serializable]
public struct DiagnosticEvent // TypeDefIndex: 4505
{
	// Fields
	[SerializeField] // RVA: 0x12A000 Offset: 0x12A101 VA: 0x12A000
	private string m_Graph; // 0x0
	[SerializeField] // RVA: 0x12A010 Offset: 0x12A111 VA: 0x12A010
	private int[] m_Dependencies; // 0x8
	[SerializeField] // RVA: 0x12A020 Offset: 0x12A121 VA: 0x12A020
	private int m_ObjectId; // 0x10
	[SerializeField] // RVA: 0x12A030 Offset: 0x12A131 VA: 0x12A030
	private string m_DisplayName; // 0x18
	[SerializeField] // RVA: 0x12A040 Offset: 0x12A141 VA: 0x12A040
	private int m_Stream; // 0x20
	[SerializeField] // RVA: 0x12A050 Offset: 0x12A151 VA: 0x12A050
	private int m_Frame; // 0x24
	[SerializeField] // RVA: 0x12A060 Offset: 0x12A161 VA: 0x12A060
	private int m_Value; // 0x28

	// Properties
	public string Graph { get; }
	public int ObjectId { get; }
	public string DisplayName { get; }
	public int[] Dependencies { get; }
	public int Stream { get; }
	public int Frame { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x15EE0 Offset: 0x15FE1 VA: 0x15EE0
	public string get_Graph() { }

	// RVA: 0x15EF0 Offset: 0x15FF1 VA: 0x15EF0
	public int get_ObjectId() { }

	// RVA: 0x15F00 Offset: 0x16001 VA: 0x15F00
	public string get_DisplayName() { }

	// RVA: 0x15F10 Offset: 0x16011 VA: 0x15F10
	public int[] get_Dependencies() { }

	// RVA: 0x15F20 Offset: 0x16021 VA: 0x15F20
	public int get_Stream() { }

	// RVA: 0x15F30 Offset: 0x16031 VA: 0x15F30
	public int get_Frame() { }

	// RVA: 0x15F40 Offset: 0x16041 VA: 0x15F40
	public int get_Value() { }

	// RVA: 0x15F50 Offset: 0x16051 VA: 0x15F50
	public void .ctor(string graph, string name, int id, int stream, int frame, int value, int[] deps) { }

	// RVA: 0x15FD0 Offset: 0x160D1 VA: 0x15FD0
	internal byte[] Serialize() { }

	// RVA: 0x19D6C30 Offset: 0x19D6D31 VA: 0x19D6C30
	public static DiagnosticEvent Deserialize(byte[] data) { }
}

