[Serializable]
public class DoorDataTable // TypeDefIndex: 6945
{
	// Fields
	[SerializeField] // RVA: 0x161AB0 Offset: 0x161BB1 VA: 0x161AB0
	public ActorID[] CheckActors; // 0x10
	[SerializeField] // RVA: 0x161AC0 Offset: 0x161BC1 VA: 0x161AC0
	public int NeedLoveLevel; // 0x18
	[SerializeField] // RVA: 0x161AD0 Offset: 0x161BD1 VA: 0x161AD0
	public int OpenHour; // 0x1C
	[SerializeField] // RVA: 0x161AE0 Offset: 0x161BE1 VA: 0x161AE0
	public int CloseHour; // 0x20
	[SerializeField] // RVA: 0x161AF0 Offset: 0x161BF1 VA: 0x161AF0
	public int Holiday_OpenHour; // 0x24
	[SerializeField] // RVA: 0x161B00 Offset: 0x161C01 VA: 0x161B00
	public int Holiday_CloseHour; // 0x28
	[SerializeField] // RVA: 0x161B10 Offset: 0x161C11 VA: 0x161B10
	public int OpenHour_Friend; // 0x2C
	[SerializeField] // RVA: 0x161B20 Offset: 0x161C21 VA: 0x161B20
	public int CloseHour_Friend; // 0x30
	[SerializeField] // RVA: 0x161B30 Offset: 0x161C31 VA: 0x161B30
	public int Holiday_OpenHour_Friend; // 0x34
	[SerializeField] // RVA: 0x161B40 Offset: 0x161C41 VA: 0x161B40
	public int Holiday_CloseHour_Friend; // 0x38
	[SerializeField] // RVA: 0x161B50 Offset: 0x161C51 VA: 0x161B50
	public GameFlagData OpenFlag; // 0x3C
	private static DoorDataTableArray _DoorDataTableArray; // 0x0

	// Methods

	// RVA: 0x1CEE290 Offset: 0x1CEE391 VA: 0x1CEE290
	public static DoorDataTable GetDataTable(Place id) { }

	// RVA: 0x1CEE420 Offset: 0x1CEE521 VA: 0x1CEE420
	public static bool HasDataTable(Place id) { }

	// RVA: 0x1CEE710 Offset: 0x1CEE811 VA: 0x1CEE710
	public void .ctor() { }

	// RVA: 0x1CEE720 Offset: 0x1CEE821 VA: 0x1CEE720
	private static void .cctor() { }
}

