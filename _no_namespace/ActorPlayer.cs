public static class ActorPlayer // TypeDefIndex: 6307
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15C0A0 Offset: 0x15C1A1 VA: 0x15C0A0
	private static bool <LoadCacheOn>k__BackingField; // 0x0
	private static Character CacheMaleModel; // 0x4
	private static Character CacheFemaleModel; // 0x8
	private static Character CacheMaleBase; // 0xC
	private static Character CacheFemaleBase; // 0x10

	// Properties
	public static Actor Actor { get; }
	public static bool IsSpawn { get; }
	public static Gender Gender { get; set; }
	public static Gender ModelGender { get; set; }
	public static bool IsMale { get; }
	public static bool IsModelMale { get; }
	public static VariationNo CostumeNo { get; set; }
	public static HumanStatus Status { get; }
	public static bool IsDead { get; }
	public static bool IsMannequin { get; }
	public static bool IsPlayable { get; }
	public static bool IsShortPlay { get; }
	public static Transform Player { get; }
	public static PlayerCharacterController PC { get; }
	public static ActorController ActiveController { get; }
	public static SpcController SpcController { get; }
	public static bool LoadCacheOn { get; set; }

	// Methods

	// RVA: 0x1BF0F30 Offset: 0x1BF1031 VA: 0x1BF0F30
	public static Actor get_Actor() { }

	// RVA: 0x1BF0FB0 Offset: 0x1BF10B1 VA: 0x1BF0FB0
	public static bool get_IsSpawn() { }

	// RVA: 0x1BF1150 Offset: 0x1BF1251 VA: 0x1BF1150
	public static Gender get_Gender() { }

	// RVA: 0x1BF1180 Offset: 0x1BF1281 VA: 0x1BF1180
	public static void set_Gender(Gender value) { }

	// RVA: 0x1BF11C0 Offset: 0x1BF12C1 VA: 0x1BF11C0
	public static Gender get_ModelGender() { }

	// RVA: 0x1BF11F0 Offset: 0x1BF12F1 VA: 0x1BF11F0
	public static void set_ModelGender(Gender value) { }

	// RVA: 0x1BF1230 Offset: 0x1BF1331 VA: 0x1BF1230
	public static bool get_IsMale() { }

	// RVA: 0x1BF1260 Offset: 0x1BF1361 VA: 0x1BF1260
	public static bool get_IsModelMale() { }

	// RVA: 0x1BF1290 Offset: 0x1BF1391 VA: 0x1BF1290
	public static VariationNo get_CostumeNo() { }

	// RVA: 0x1BF12C0 Offset: 0x1BF13C1 VA: 0x1BF12C0
	public static void set_CostumeNo(VariationNo value) { }

	// RVA: 0x1BF1300 Offset: 0x1BF1401 VA: 0x1BF1300
	public static HumanStatus get_Status() { }

	// RVA: 0x1BF1440 Offset: 0x1BF1541 VA: 0x1BF1440
	public static bool get_IsDead() { }

	// RVA: 0x1BF14B0 Offset: 0x1BF15B1 VA: 0x1BF14B0
	public static bool get_IsMannequin() { }

	// RVA: 0x1BF15A0 Offset: 0x1BF16A1 VA: 0x1BF15A0
	public static bool get_IsPlayable() { }

	// RVA: 0x1BF1690 Offset: 0x1BF1791 VA: 0x1BF1690
	public static bool get_IsShortPlay() { }

	// RVA: 0x1BF1780 Offset: 0x1BF1881 VA: 0x1BF1780
	public static Transform get_Player() { }

	// RVA: 0x1BF1870 Offset: 0x1BF1971 VA: 0x1BF1870
	public static PlayerCharacterController get_PC() { }

	// RVA: 0x1BF19C0 Offset: 0x1BF1AC1 VA: 0x1BF19C0
	public static ActorController get_ActiveController() { }

	// RVA: 0x1BF1AA0 Offset: 0x1BF1BA1 VA: 0x1BF1AA0
	public static SpcController get_SpcController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19ABB0 Offset: 0x19ACB1 VA: 0x19ABB0
	// RVA: 0x1BF1BF0 Offset: 0x1BF1CF1 VA: 0x1BF1BF0
	public static bool get_LoadCacheOn() { }

	[CompilerGeneratedAttribute] // RVA: 0x19ABC0 Offset: 0x19ACC1 VA: 0x19ABC0
	// RVA: 0x1BF1C60 Offset: 0x1BF1D61 VA: 0x1BF1C60
	public static void set_LoadCacheOn(bool value) { }

	// RVA: 0x1BF1CD0 Offset: 0x1BF1DD1 VA: 0x1BF1CD0
	public static void Spawn() { }

	// RVA: 0x1BF1F70 Offset: 0x1BF2071 VA: 0x1BF1F70
	public static void PlayerModelLoad() { }

	// RVA: 0x1BF23F0 Offset: 0x1BF24F1 VA: 0x1BF23F0
	public static void CreateFirst(bool isMale, ActorType actorType = 1) { }

	// RVA: 0x1BF29C0 Offset: 0x1BF2AC1 VA: 0x1BF29C0
	public static void ChangeGender() { }

	// RVA: 0x1BF2CE0 Offset: 0x1BF2DE1 VA: 0x1BF2CE0
	public static void ChangeCostume(VariationNo variationNo) { }

	// RVA: 0x1BF2F10 Offset: 0x1BF3011 VA: 0x1BF2F10
	private static void .cctor() { }
}

