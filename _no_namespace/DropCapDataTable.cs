[Serializable]
public class DropCapDataTable // TypeDefIndex: 6946
{
	// Fields
	[SerializeField] // RVA: 0x161B60 Offset: 0x161C61 VA: 0x161B60
	public GameFlagData GameFlagData; // 0x10
	[SerializeField] // RVA: 0x161B70 Offset: 0x161C71 VA: 0x161B70
	public int DropCap; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x161B80 Offset: 0x161C81 VA: 0x161B80
	private static DropCapDataTableArray <_Instance>k__BackingField; // 0x0

	// Properties
	private static DropCapDataTableArray _Instance { get; set; }
	public static int NoDropTresureCap { get; }
	public static int HiDropCap { get; }
	public static int Legendary { get; }
	public static int NoDropCap { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DD10 Offset: 0x19DE11 VA: 0x19DD10
	// RVA: 0x1CF2C50 Offset: 0x1CF2D51 VA: 0x1CF2C50
	private static DropCapDataTableArray get__Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DD20 Offset: 0x19DE21 VA: 0x19DD20
	// RVA: 0x1CF2CC0 Offset: 0x1CF2DC1 VA: 0x1CF2CC0
	private static void set__Instance(DropCapDataTableArray value) { }

	// RVA: 0x1CF2D30 Offset: 0x1CF2E31 VA: 0x1CF2D30
	public static int get_NoDropTresureCap() { }

	// RVA: 0x1CF2E10 Offset: 0x1CF2F11 VA: 0x1CF2E10
	public static int get_HiDropCap() { }

	// RVA: 0x1CF2EF0 Offset: 0x1CF2FF1 VA: 0x1CF2EF0
	public static int get_Legendary() { }

	// RVA: 0x1CF2FD0 Offset: 0x1CF30D1 VA: 0x1CF2FD0
	public static int get_NoDropCap() { }

	// RVA: 0x1CF30B0 Offset: 0x1CF31B1 VA: 0x1CF30B0
	public static void Init() { }

	// RVA: 0x1CF32C0 Offset: 0x1CF33C1 VA: 0x1CF32C0
	public static DropCapDataTable GetDataTable(DropCapID id) { }

	// RVA: 0x1CF34A0 Offset: 0x1CF35A1 VA: 0x1CF34A0
	public static int CalcNowCap() { }

	// RVA: 0x1CF37B0 Offset: 0x1CF38B1 VA: 0x1CF37B0
	public void .ctor() { }

	// RVA: 0x1CF37C0 Offset: 0x1CF38C1 VA: 0x1CF37C0
	private static void .cctor() { }
}

