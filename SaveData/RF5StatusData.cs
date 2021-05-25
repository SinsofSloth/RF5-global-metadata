public class RF5StatusData : SaveDataValueBase // TypeDefIndex: 9902
{
	// Fields
	public readonly Dictionary<ActorID, HumanStatusData> HumanStatusDatas; // 0x10
	public readonly List<FriendMonsterStatusData> FriendMonsterStatusDatas; // 0x18
	public static readonly ActorID[] SaveActors; // 0x0
	private static readonly ActorID[] ReadActors_000; // 0x8

	// Properties
	public int PlayerLevel { get; }

	// Methods

	// RVA: 0x20F3270 Offset: 0x20F3371 VA: 0x20F3270
	public int get_PlayerLevel() { }

	// RVA: 0x20F0360 Offset: 0x20F0461 VA: 0x20F0360
	public void .ctor() { }

	// RVA: 0x20F32E0 Offset: 0x20F33E1 VA: 0x20F32E0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x20F3470 Offset: 0x20F3571 VA: 0x20F3470
	public void InitializeForNewGame() { }

	// RVA: 0x20F3A50 Offset: 0x20F3B51 VA: 0x20F3A50 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x20F3A60 Offset: 0x20F3B61 VA: 0x20F3A60 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x20F3A70 Offset: 0x20F3B71 VA: 0x20F3A70 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x20F16E0 Offset: 0x20F17E1 VA: 0x20F16E0
	public void Reader0000(BinaryReader reader) { }

	// RVA: 0x20F3D20 Offset: 0x20F3E21 VA: 0x20F3D20
	private static void .cctor() { }
}

