[Serializable]
public struct FurnitureData // TypeDefIndex: 7539
{
	// Fields
	[SerializeField] // RVA: 0x166F70 Offset: 0x167071 VA: 0x166F70
	public FurnitureID Id; // 0x0
	[SerializeField] // RVA: 0x166F80 Offset: 0x167081 VA: 0x166F80
	public Prefab PrefabId; // 0x4
	[SerializeField] // RVA: 0x166F90 Offset: 0x167091 VA: 0x166F90
	public string NameId; // 0x8
	[SerializeField] // RVA: 0x166FA0 Offset: 0x1670A1 VA: 0x166FA0
	public string ScriptName; // 0x10
	[SerializeField] // RVA: 0x166FB0 Offset: 0x1670B1 VA: 0x166FB0
	public int Hp; // 0x18
	private static bool IsLoad; // 0x0
	private static FurnitureDataTableArray _FurnitureDataTableArray; // 0x8

	// Properties
	public static FurnitureDataTableArray FurnitureDataTableArray { get; }

	// Methods

	// RVA: 0x2F2090 Offset: 0x2F2191 VA: 0x2F2090
	public void .ctor(FurnitureID id, Prefab prefab_id, string name_id, string script_name, int hp) { }

	// RVA: 0x2F20E0 Offset: 0x2F21E1 VA: 0x2F20E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x229A8D0 Offset: 0x229A9D1 VA: 0x229A8D0
	public static FurnitureDataTableArray get_FurnitureDataTableArray() { }

	// RVA: 0x229A940 Offset: 0x229AA41 VA: 0x229A940
	public static FurnitureData GetData(FurnitureID id) { }

	// RVA: 0x229AB00 Offset: 0x229AC01 VA: 0x229AB00
	public static string GetNameId(FurnitureID id) { }

	// RVA: 0x229AB80 Offset: 0x229AC81 VA: 0x229AB80
	public static string GetScriptName(FurnitureID id) { }

	// RVA: 0x229AC00 Offset: 0x229AD01 VA: 0x229AC00
	public static Prefab GetPrefabId(FurnitureID id) { }

	// RVA: 0x229AC80 Offset: 0x229AD81 VA: 0x229AC80
	public static int GetHp(FurnitureID id) { }

	// RVA: 0x229AD00 Offset: 0x229AE01 VA: 0x229AD00
	public static void LoadData() { }

	// RVA: 0x229AE30 Offset: 0x229AF31 VA: 0x229AE30
	private static void .cctor() { }
}

