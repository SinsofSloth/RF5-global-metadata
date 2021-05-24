internal struct HashCode // TypeDefIndex: 5110
{
	// Fields
	private static readonly uint s_seed; // 0x0
	private const uint Prime1 = 2654435761;
	private const uint Prime2 = 2246822519;
	private const uint Prime3 = 3266489917;
	private const uint Prime4 = 668265263;
	private const uint Prime5 = 374761393;
	private uint _v1; // 0x0
	private uint _v2; // 0x4
	private uint _v3; // 0x8
	private uint _v4; // 0xC
	private uint _queue1; // 0x10
	private uint _queue2; // 0x14
	private uint _queue3; // 0x18
	private uint _length; // 0x1C

	// Methods

	// RVA: 0x1BD41E0 Offset: 0x1BD42E1 VA: 0x1BD41E0
	private static uint GenerateGlobalSeed() { }

	// RVA: -1 Offset: -1
	public static int Combine<T1>(T1 value1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557630 Offset: 0x2557731 VA: 0x2557630
	|-HashCode.Combine<DateTime>
	|
	|-RVA: 0x25576F0 Offset: 0x25577F1 VA: 0x25576F0
	|-HashCode.Combine<DateTimeOffset>
	|
	|-RVA: 0x25577B0 Offset: 0x25578B1 VA: 0x25577B0
	|-HashCode.Combine<double>
	|
	|-RVA: 0x2557870 Offset: 0x2557971 VA: 0x2557870
	|-HashCode.Combine<Guid>
	|
	|-RVA: 0x2557B40 Offset: 0x2557C41 VA: 0x2557B40
	|-HashCode.Combine<int>
	|
	|-RVA: 0x2557C00 Offset: 0x2557D01 VA: 0x2557C00
	|-HashCode.Combine<long>
	|
	|-RVA: 0x2558A70 Offset: 0x2558B71 VA: 0x2558A70
	|-HashCode.Combine<object>
	|
	|-RVA: 0x2558B40 Offset: 0x2558C41 VA: 0x2558B40
	|-HashCode.Combine<float>
	|
	|-RVA: 0x2558CE0 Offset: 0x2558DE1 VA: 0x2558CE0
	|-HashCode.Combine<ulong>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2>(T1 value1, T2 value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557A60 Offset: 0x2557B61 VA: 0x2557A60
	|-HashCode.Combine<int, int>
	|
	|-RVA: 0x2558970 Offset: 0x2558A71 VA: 0x2558970
	|-HashCode.Combine<object, object>
	|
	|-RVA: 0x2558C00 Offset: 0x2558D01 VA: 0x2558C00
	|-HashCode.Combine<uint, uint>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557930 Offset: 0x2557A31 VA: 0x2557930
	|-HashCode.Combine<int, int, DateTimeKind>
	|-HashCode.Combine<int, int, Int32Enum>
	|
	|-RVA: 0x2558850 Offset: 0x2558951 VA: 0x2558850
	|-HashCode.Combine<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558660 Offset: 0x2558761 VA: 0x2558660
	|-HashCode.Combine<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558430 Offset: 0x2558531 VA: 0x2558430
	|-HashCode.Combine<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25581E0 Offset: 0x25582E1 VA: 0x25581E0
	|-HashCode.Combine<object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557F50 Offset: 0x2558051 VA: 0x2557F50
	|-HashCode.Combine<object, object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557CC0 Offset: 0x2557DC1 VA: 0x2557CC0
	|-HashCode.Combine<object, object, object, object, object, object, object, object>
	*/

	// RVA: 0x1BD4330 Offset: 0x1BD4431 VA: 0x1BD4330
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	// RVA: 0x1BD4410 Offset: 0x1BD4511 VA: 0x1BD4410
	private static uint Round(uint hash, uint input) { }

	// RVA: 0x1BD4430 Offset: 0x1BD4531 VA: 0x1BD4430
	private static uint QueueRound(uint hash, uint queuedValue) { }

	// RVA: 0x1BD4450 Offset: 0x1BD4551 VA: 0x1BD4450
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	// RVA: 0x1BD4470 Offset: 0x1BD4571 VA: 0x1BD4470
	private static uint MixEmptyState() { }

	// RVA: 0x1BD44F0 Offset: 0x1BD45F1 VA: 0x1BD44F0
	private static uint MixFinal(uint hash) { }

	// RVA: -1 Offset: -1
	public void Add<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3278F0 Offset: 0x3279F1 VA: 0x3278F0
	|-HashCode.Add<char>
	|
	|-RVA: 0x327930 Offset: 0x327A31 VA: 0x327930
	|-HashCode.Add<int>
	|
	|-RVA: 0x327970 Offset: 0x327A71 VA: 0x327970
	|-HashCode.Add<object>
	*/

	// RVA: -1 Offset: -1
	public void Add<T>(T value, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279B0 Offset: 0x327AB1 VA: 0x3279B0
	|-HashCode.Add<object>
	*/

	// RVA: 0x26520 Offset: 0x26621 VA: 0x26520
	private void Add(int value) { }

	// RVA: 0x26530 Offset: 0x26631 VA: 0x26530
	public int ToHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	[EditorBrowsableAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	// RVA: 0x26540 Offset: 0x26641 VA: 0x26540 Slot: 2
	public override int GetHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	[EditorBrowsableAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	// RVA: 0x26550 Offset: 0x26651 VA: 0x26550 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BD49E0 Offset: 0x1BD4AE1 VA: 0x1BD49E0
	private static void .cctor() { }
}

internal struct HashCode // TypeDefIndex: 5110
{
	// Fields
	private static readonly uint s_seed; // 0x0
	private const uint Prime1 = 2654435761;
	private const uint Prime2 = 2246822519;
	private const uint Prime3 = 3266489917;
	private const uint Prime4 = 668265263;
	private const uint Prime5 = 374761393;
	private uint _v1; // 0x0
	private uint _v2; // 0x4
	private uint _v3; // 0x8
	private uint _v4; // 0xC
	private uint _queue1; // 0x10
	private uint _queue2; // 0x14
	private uint _queue3; // 0x18
	private uint _length; // 0x1C

	// Methods

	// RVA: 0x1BD41E0 Offset: 0x1BD42E1 VA: 0x1BD41E0
	private static uint GenerateGlobalSeed() { }

	// RVA: -1 Offset: -1
	public static int Combine<T1>(T1 value1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557630 Offset: 0x2557731 VA: 0x2557630
	|-HashCode.Combine<DateTime>
	|
	|-RVA: 0x25576F0 Offset: 0x25577F1 VA: 0x25576F0
	|-HashCode.Combine<DateTimeOffset>
	|
	|-RVA: 0x25577B0 Offset: 0x25578B1 VA: 0x25577B0
	|-HashCode.Combine<double>
	|
	|-RVA: 0x2557870 Offset: 0x2557971 VA: 0x2557870
	|-HashCode.Combine<Guid>
	|
	|-RVA: 0x2557B40 Offset: 0x2557C41 VA: 0x2557B40
	|-HashCode.Combine<int>
	|
	|-RVA: 0x2557C00 Offset: 0x2557D01 VA: 0x2557C00
	|-HashCode.Combine<long>
	|
	|-RVA: 0x2558A70 Offset: 0x2558B71 VA: 0x2558A70
	|-HashCode.Combine<object>
	|
	|-RVA: 0x2558B40 Offset: 0x2558C41 VA: 0x2558B40
	|-HashCode.Combine<float>
	|
	|-RVA: 0x2558CE0 Offset: 0x2558DE1 VA: 0x2558CE0
	|-HashCode.Combine<ulong>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2>(T1 value1, T2 value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557A60 Offset: 0x2557B61 VA: 0x2557A60
	|-HashCode.Combine<int, int>
	|
	|-RVA: 0x2558970 Offset: 0x2558A71 VA: 0x2558970
	|-HashCode.Combine<object, object>
	|
	|-RVA: 0x2558C00 Offset: 0x2558D01 VA: 0x2558C00
	|-HashCode.Combine<uint, uint>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557930 Offset: 0x2557A31 VA: 0x2557930
	|-HashCode.Combine<int, int, DateTimeKind>
	|-HashCode.Combine<int, int, Int32Enum>
	|
	|-RVA: 0x2558850 Offset: 0x2558951 VA: 0x2558850
	|-HashCode.Combine<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558660 Offset: 0x2558761 VA: 0x2558660
	|-HashCode.Combine<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558430 Offset: 0x2558531 VA: 0x2558430
	|-HashCode.Combine<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25581E0 Offset: 0x25582E1 VA: 0x25581E0
	|-HashCode.Combine<object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557F50 Offset: 0x2558051 VA: 0x2557F50
	|-HashCode.Combine<object, object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557CC0 Offset: 0x2557DC1 VA: 0x2557CC0
	|-HashCode.Combine<object, object, object, object, object, object, object, object>
	*/

	// RVA: 0x1BD4330 Offset: 0x1BD4431 VA: 0x1BD4330
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	// RVA: 0x1BD4410 Offset: 0x1BD4511 VA: 0x1BD4410
	private static uint Round(uint hash, uint input) { }

	// RVA: 0x1BD4430 Offset: 0x1BD4531 VA: 0x1BD4430
	private static uint QueueRound(uint hash, uint queuedValue) { }

	// RVA: 0x1BD4450 Offset: 0x1BD4551 VA: 0x1BD4450
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	// RVA: 0x1BD4470 Offset: 0x1BD4571 VA: 0x1BD4470
	private static uint MixEmptyState() { }

	// RVA: 0x1BD44F0 Offset: 0x1BD45F1 VA: 0x1BD44F0
	private static uint MixFinal(uint hash) { }

	// RVA: -1 Offset: -1
	public void Add<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3278F0 Offset: 0x3279F1 VA: 0x3278F0
	|-HashCode.Add<char>
	|
	|-RVA: 0x327930 Offset: 0x327A31 VA: 0x327930
	|-HashCode.Add<int>
	|
	|-RVA: 0x327970 Offset: 0x327A71 VA: 0x327970
	|-HashCode.Add<object>
	*/

	// RVA: -1 Offset: -1
	public void Add<T>(T value, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279B0 Offset: 0x327AB1 VA: 0x3279B0
	|-HashCode.Add<object>
	*/

	// RVA: 0x26520 Offset: 0x26621 VA: 0x26520
	private void Add(int value) { }

	// RVA: 0x26530 Offset: 0x26631 VA: 0x26530
	public int ToHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	[EditorBrowsableAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	// RVA: 0x26540 Offset: 0x26641 VA: 0x26540 Slot: 2
	public override int GetHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	[EditorBrowsableAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	// RVA: 0x26550 Offset: 0x26651 VA: 0x26550 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BD49E0 Offset: 0x1BD4AE1 VA: 0x1BD49E0
	private static void .cctor() { }
}

internal struct HashCode // TypeDefIndex: 5110
{
	// Fields
	private static readonly uint s_seed; // 0x0
	private const uint Prime1 = 2654435761;
	private const uint Prime2 = 2246822519;
	private const uint Prime3 = 3266489917;
	private const uint Prime4 = 668265263;
	private const uint Prime5 = 374761393;
	private uint _v1; // 0x0
	private uint _v2; // 0x4
	private uint _v3; // 0x8
	private uint _v4; // 0xC
	private uint _queue1; // 0x10
	private uint _queue2; // 0x14
	private uint _queue3; // 0x18
	private uint _length; // 0x1C

	// Methods

	// RVA: 0x1BD41E0 Offset: 0x1BD42E1 VA: 0x1BD41E0
	private static uint GenerateGlobalSeed() { }

	// RVA: -1 Offset: -1
	public static int Combine<T1>(T1 value1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557630 Offset: 0x2557731 VA: 0x2557630
	|-HashCode.Combine<DateTime>
	|
	|-RVA: 0x25576F0 Offset: 0x25577F1 VA: 0x25576F0
	|-HashCode.Combine<DateTimeOffset>
	|
	|-RVA: 0x25577B0 Offset: 0x25578B1 VA: 0x25577B0
	|-HashCode.Combine<double>
	|
	|-RVA: 0x2557870 Offset: 0x2557971 VA: 0x2557870
	|-HashCode.Combine<Guid>
	|
	|-RVA: 0x2557B40 Offset: 0x2557C41 VA: 0x2557B40
	|-HashCode.Combine<int>
	|
	|-RVA: 0x2557C00 Offset: 0x2557D01 VA: 0x2557C00
	|-HashCode.Combine<long>
	|
	|-RVA: 0x2558A70 Offset: 0x2558B71 VA: 0x2558A70
	|-HashCode.Combine<object>
	|
	|-RVA: 0x2558B40 Offset: 0x2558C41 VA: 0x2558B40
	|-HashCode.Combine<float>
	|
	|-RVA: 0x2558CE0 Offset: 0x2558DE1 VA: 0x2558CE0
	|-HashCode.Combine<ulong>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2>(T1 value1, T2 value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557A60 Offset: 0x2557B61 VA: 0x2557A60
	|-HashCode.Combine<int, int>
	|
	|-RVA: 0x2558970 Offset: 0x2558A71 VA: 0x2558970
	|-HashCode.Combine<object, object>
	|
	|-RVA: 0x2558C00 Offset: 0x2558D01 VA: 0x2558C00
	|-HashCode.Combine<uint, uint>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557930 Offset: 0x2557A31 VA: 0x2557930
	|-HashCode.Combine<int, int, DateTimeKind>
	|-HashCode.Combine<int, int, Int32Enum>
	|
	|-RVA: 0x2558850 Offset: 0x2558951 VA: 0x2558850
	|-HashCode.Combine<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558660 Offset: 0x2558761 VA: 0x2558660
	|-HashCode.Combine<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558430 Offset: 0x2558531 VA: 0x2558430
	|-HashCode.Combine<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25581E0 Offset: 0x25582E1 VA: 0x25581E0
	|-HashCode.Combine<object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557F50 Offset: 0x2558051 VA: 0x2557F50
	|-HashCode.Combine<object, object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557CC0 Offset: 0x2557DC1 VA: 0x2557CC0
	|-HashCode.Combine<object, object, object, object, object, object, object, object>
	*/

	// RVA: 0x1BD4330 Offset: 0x1BD4431 VA: 0x1BD4330
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	// RVA: 0x1BD4410 Offset: 0x1BD4511 VA: 0x1BD4410
	private static uint Round(uint hash, uint input) { }

	// RVA: 0x1BD4430 Offset: 0x1BD4531 VA: 0x1BD4430
	private static uint QueueRound(uint hash, uint queuedValue) { }

	// RVA: 0x1BD4450 Offset: 0x1BD4551 VA: 0x1BD4450
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	// RVA: 0x1BD4470 Offset: 0x1BD4571 VA: 0x1BD4470
	private static uint MixEmptyState() { }

	// RVA: 0x1BD44F0 Offset: 0x1BD45F1 VA: 0x1BD44F0
	private static uint MixFinal(uint hash) { }

	// RVA: -1 Offset: -1
	public void Add<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3278F0 Offset: 0x3279F1 VA: 0x3278F0
	|-HashCode.Add<char>
	|
	|-RVA: 0x327930 Offset: 0x327A31 VA: 0x327930
	|-HashCode.Add<int>
	|
	|-RVA: 0x327970 Offset: 0x327A71 VA: 0x327970
	|-HashCode.Add<object>
	*/

	// RVA: -1 Offset: -1
	public void Add<T>(T value, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279B0 Offset: 0x327AB1 VA: 0x3279B0
	|-HashCode.Add<object>
	*/

	// RVA: 0x26520 Offset: 0x26621 VA: 0x26520
	private void Add(int value) { }

	// RVA: 0x26530 Offset: 0x26631 VA: 0x26530
	public int ToHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	[EditorBrowsableAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	// RVA: 0x26540 Offset: 0x26641 VA: 0x26540 Slot: 2
	public override int GetHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	[EditorBrowsableAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	// RVA: 0x26550 Offset: 0x26651 VA: 0x26550 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BD49E0 Offset: 0x1BD4AE1 VA: 0x1BD49E0
	private static void .cctor() { }
}

internal struct HashCode // TypeDefIndex: 5110
{
	// Fields
	private static readonly uint s_seed; // 0x0
	private const uint Prime1 = 2654435761;
	private const uint Prime2 = 2246822519;
	private const uint Prime3 = 3266489917;
	private const uint Prime4 = 668265263;
	private const uint Prime5 = 374761393;
	private uint _v1; // 0x0
	private uint _v2; // 0x4
	private uint _v3; // 0x8
	private uint _v4; // 0xC
	private uint _queue1; // 0x10
	private uint _queue2; // 0x14
	private uint _queue3; // 0x18
	private uint _length; // 0x1C

	// Methods

	// RVA: 0x1BD41E0 Offset: 0x1BD42E1 VA: 0x1BD41E0
	private static uint GenerateGlobalSeed() { }

	// RVA: -1 Offset: -1
	public static int Combine<T1>(T1 value1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557630 Offset: 0x2557731 VA: 0x2557630
	|-HashCode.Combine<DateTime>
	|
	|-RVA: 0x25576F0 Offset: 0x25577F1 VA: 0x25576F0
	|-HashCode.Combine<DateTimeOffset>
	|
	|-RVA: 0x25577B0 Offset: 0x25578B1 VA: 0x25577B0
	|-HashCode.Combine<double>
	|
	|-RVA: 0x2557870 Offset: 0x2557971 VA: 0x2557870
	|-HashCode.Combine<Guid>
	|
	|-RVA: 0x2557B40 Offset: 0x2557C41 VA: 0x2557B40
	|-HashCode.Combine<int>
	|
	|-RVA: 0x2557C00 Offset: 0x2557D01 VA: 0x2557C00
	|-HashCode.Combine<long>
	|
	|-RVA: 0x2558A70 Offset: 0x2558B71 VA: 0x2558A70
	|-HashCode.Combine<object>
	|
	|-RVA: 0x2558B40 Offset: 0x2558C41 VA: 0x2558B40
	|-HashCode.Combine<float>
	|
	|-RVA: 0x2558CE0 Offset: 0x2558DE1 VA: 0x2558CE0
	|-HashCode.Combine<ulong>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2>(T1 value1, T2 value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557A60 Offset: 0x2557B61 VA: 0x2557A60
	|-HashCode.Combine<int, int>
	|
	|-RVA: 0x2558970 Offset: 0x2558A71 VA: 0x2558970
	|-HashCode.Combine<object, object>
	|
	|-RVA: 0x2558C00 Offset: 0x2558D01 VA: 0x2558C00
	|-HashCode.Combine<uint, uint>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557930 Offset: 0x2557A31 VA: 0x2557930
	|-HashCode.Combine<int, int, DateTimeKind>
	|-HashCode.Combine<int, int, Int32Enum>
	|
	|-RVA: 0x2558850 Offset: 0x2558951 VA: 0x2558850
	|-HashCode.Combine<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558660 Offset: 0x2558761 VA: 0x2558660
	|-HashCode.Combine<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558430 Offset: 0x2558531 VA: 0x2558430
	|-HashCode.Combine<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25581E0 Offset: 0x25582E1 VA: 0x25581E0
	|-HashCode.Combine<object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557F50 Offset: 0x2558051 VA: 0x2557F50
	|-HashCode.Combine<object, object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557CC0 Offset: 0x2557DC1 VA: 0x2557CC0
	|-HashCode.Combine<object, object, object, object, object, object, object, object>
	*/

	// RVA: 0x1BD4330 Offset: 0x1BD4431 VA: 0x1BD4330
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	// RVA: 0x1BD4410 Offset: 0x1BD4511 VA: 0x1BD4410
	private static uint Round(uint hash, uint input) { }

	// RVA: 0x1BD4430 Offset: 0x1BD4531 VA: 0x1BD4430
	private static uint QueueRound(uint hash, uint queuedValue) { }

	// RVA: 0x1BD4450 Offset: 0x1BD4551 VA: 0x1BD4450
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	// RVA: 0x1BD4470 Offset: 0x1BD4571 VA: 0x1BD4470
	private static uint MixEmptyState() { }

	// RVA: 0x1BD44F0 Offset: 0x1BD45F1 VA: 0x1BD44F0
	private static uint MixFinal(uint hash) { }

	// RVA: -1 Offset: -1
	public void Add<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3278F0 Offset: 0x3279F1 VA: 0x3278F0
	|-HashCode.Add<char>
	|
	|-RVA: 0x327930 Offset: 0x327A31 VA: 0x327930
	|-HashCode.Add<int>
	|
	|-RVA: 0x327970 Offset: 0x327A71 VA: 0x327970
	|-HashCode.Add<object>
	*/

	// RVA: -1 Offset: -1
	public void Add<T>(T value, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279B0 Offset: 0x327AB1 VA: 0x3279B0
	|-HashCode.Add<object>
	*/

	// RVA: 0x26520 Offset: 0x26621 VA: 0x26520
	private void Add(int value) { }

	// RVA: 0x26530 Offset: 0x26631 VA: 0x26530
	public int ToHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	[EditorBrowsableAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	// RVA: 0x26540 Offset: 0x26641 VA: 0x26540 Slot: 2
	public override int GetHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	[EditorBrowsableAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	// RVA: 0x26550 Offset: 0x26651 VA: 0x26550 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BD49E0 Offset: 0x1BD4AE1 VA: 0x1BD49E0
	private static void .cctor() { }
}

internal struct HashCode // TypeDefIndex: 5110
{
	// Fields
	private static readonly uint s_seed; // 0x0
	private const uint Prime1 = 2654435761;
	private const uint Prime2 = 2246822519;
	private const uint Prime3 = 3266489917;
	private const uint Prime4 = 668265263;
	private const uint Prime5 = 374761393;
	private uint _v1; // 0x0
	private uint _v2; // 0x4
	private uint _v3; // 0x8
	private uint _v4; // 0xC
	private uint _queue1; // 0x10
	private uint _queue2; // 0x14
	private uint _queue3; // 0x18
	private uint _length; // 0x1C

	// Methods

	// RVA: 0x1BD41E0 Offset: 0x1BD42E1 VA: 0x1BD41E0
	private static uint GenerateGlobalSeed() { }

	// RVA: -1 Offset: -1
	public static int Combine<T1>(T1 value1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557630 Offset: 0x2557731 VA: 0x2557630
	|-HashCode.Combine<DateTime>
	|
	|-RVA: 0x25576F0 Offset: 0x25577F1 VA: 0x25576F0
	|-HashCode.Combine<DateTimeOffset>
	|
	|-RVA: 0x25577B0 Offset: 0x25578B1 VA: 0x25577B0
	|-HashCode.Combine<double>
	|
	|-RVA: 0x2557870 Offset: 0x2557971 VA: 0x2557870
	|-HashCode.Combine<Guid>
	|
	|-RVA: 0x2557B40 Offset: 0x2557C41 VA: 0x2557B40
	|-HashCode.Combine<int>
	|
	|-RVA: 0x2557C00 Offset: 0x2557D01 VA: 0x2557C00
	|-HashCode.Combine<long>
	|
	|-RVA: 0x2558A70 Offset: 0x2558B71 VA: 0x2558A70
	|-HashCode.Combine<object>
	|
	|-RVA: 0x2558B40 Offset: 0x2558C41 VA: 0x2558B40
	|-HashCode.Combine<float>
	|
	|-RVA: 0x2558CE0 Offset: 0x2558DE1 VA: 0x2558CE0
	|-HashCode.Combine<ulong>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2>(T1 value1, T2 value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557A60 Offset: 0x2557B61 VA: 0x2557A60
	|-HashCode.Combine<int, int>
	|
	|-RVA: 0x2558970 Offset: 0x2558A71 VA: 0x2558970
	|-HashCode.Combine<object, object>
	|
	|-RVA: 0x2558C00 Offset: 0x2558D01 VA: 0x2558C00
	|-HashCode.Combine<uint, uint>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557930 Offset: 0x2557A31 VA: 0x2557930
	|-HashCode.Combine<int, int, DateTimeKind>
	|-HashCode.Combine<int, int, Int32Enum>
	|
	|-RVA: 0x2558850 Offset: 0x2558951 VA: 0x2558850
	|-HashCode.Combine<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558660 Offset: 0x2558761 VA: 0x2558660
	|-HashCode.Combine<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558430 Offset: 0x2558531 VA: 0x2558430
	|-HashCode.Combine<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25581E0 Offset: 0x25582E1 VA: 0x25581E0
	|-HashCode.Combine<object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557F50 Offset: 0x2558051 VA: 0x2557F50
	|-HashCode.Combine<object, object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557CC0 Offset: 0x2557DC1 VA: 0x2557CC0
	|-HashCode.Combine<object, object, object, object, object, object, object, object>
	*/

	// RVA: 0x1BD4330 Offset: 0x1BD4431 VA: 0x1BD4330
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	// RVA: 0x1BD4410 Offset: 0x1BD4511 VA: 0x1BD4410
	private static uint Round(uint hash, uint input) { }

	// RVA: 0x1BD4430 Offset: 0x1BD4531 VA: 0x1BD4430
	private static uint QueueRound(uint hash, uint queuedValue) { }

	// RVA: 0x1BD4450 Offset: 0x1BD4551 VA: 0x1BD4450
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	// RVA: 0x1BD4470 Offset: 0x1BD4571 VA: 0x1BD4470
	private static uint MixEmptyState() { }

	// RVA: 0x1BD44F0 Offset: 0x1BD45F1 VA: 0x1BD44F0
	private static uint MixFinal(uint hash) { }

	// RVA: -1 Offset: -1
	public void Add<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3278F0 Offset: 0x3279F1 VA: 0x3278F0
	|-HashCode.Add<char>
	|
	|-RVA: 0x327930 Offset: 0x327A31 VA: 0x327930
	|-HashCode.Add<int>
	|
	|-RVA: 0x327970 Offset: 0x327A71 VA: 0x327970
	|-HashCode.Add<object>
	*/

	// RVA: -1 Offset: -1
	public void Add<T>(T value, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279B0 Offset: 0x327AB1 VA: 0x3279B0
	|-HashCode.Add<object>
	*/

	// RVA: 0x26520 Offset: 0x26621 VA: 0x26520
	private void Add(int value) { }

	// RVA: 0x26530 Offset: 0x26631 VA: 0x26530
	public int ToHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	[EditorBrowsableAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	// RVA: 0x26540 Offset: 0x26641 VA: 0x26540 Slot: 2
	public override int GetHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	[EditorBrowsableAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	// RVA: 0x26550 Offset: 0x26651 VA: 0x26550 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BD49E0 Offset: 0x1BD4AE1 VA: 0x1BD49E0
	private static void .cctor() { }
}

internal struct HashCode // TypeDefIndex: 5110
{
	// Fields
	private static readonly uint s_seed; // 0x0
	private const uint Prime1 = 2654435761;
	private const uint Prime2 = 2246822519;
	private const uint Prime3 = 3266489917;
	private const uint Prime4 = 668265263;
	private const uint Prime5 = 374761393;
	private uint _v1; // 0x0
	private uint _v2; // 0x4
	private uint _v3; // 0x8
	private uint _v4; // 0xC
	private uint _queue1; // 0x10
	private uint _queue2; // 0x14
	private uint _queue3; // 0x18
	private uint _length; // 0x1C

	// Methods

	// RVA: 0x1BD41E0 Offset: 0x1BD42E1 VA: 0x1BD41E0
	private static uint GenerateGlobalSeed() { }

	// RVA: -1 Offset: -1
	public static int Combine<T1>(T1 value1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557630 Offset: 0x2557731 VA: 0x2557630
	|-HashCode.Combine<DateTime>
	|
	|-RVA: 0x25576F0 Offset: 0x25577F1 VA: 0x25576F0
	|-HashCode.Combine<DateTimeOffset>
	|
	|-RVA: 0x25577B0 Offset: 0x25578B1 VA: 0x25577B0
	|-HashCode.Combine<double>
	|
	|-RVA: 0x2557870 Offset: 0x2557971 VA: 0x2557870
	|-HashCode.Combine<Guid>
	|
	|-RVA: 0x2557B40 Offset: 0x2557C41 VA: 0x2557B40
	|-HashCode.Combine<int>
	|
	|-RVA: 0x2557C00 Offset: 0x2557D01 VA: 0x2557C00
	|-HashCode.Combine<long>
	|
	|-RVA: 0x2558A70 Offset: 0x2558B71 VA: 0x2558A70
	|-HashCode.Combine<object>
	|
	|-RVA: 0x2558B40 Offset: 0x2558C41 VA: 0x2558B40
	|-HashCode.Combine<float>
	|
	|-RVA: 0x2558CE0 Offset: 0x2558DE1 VA: 0x2558CE0
	|-HashCode.Combine<ulong>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2>(T1 value1, T2 value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557A60 Offset: 0x2557B61 VA: 0x2557A60
	|-HashCode.Combine<int, int>
	|
	|-RVA: 0x2558970 Offset: 0x2558A71 VA: 0x2558970
	|-HashCode.Combine<object, object>
	|
	|-RVA: 0x2558C00 Offset: 0x2558D01 VA: 0x2558C00
	|-HashCode.Combine<uint, uint>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557930 Offset: 0x2557A31 VA: 0x2557930
	|-HashCode.Combine<int, int, DateTimeKind>
	|-HashCode.Combine<int, int, Int32Enum>
	|
	|-RVA: 0x2558850 Offset: 0x2558951 VA: 0x2558850
	|-HashCode.Combine<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558660 Offset: 0x2558761 VA: 0x2558660
	|-HashCode.Combine<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558430 Offset: 0x2558531 VA: 0x2558430
	|-HashCode.Combine<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25581E0 Offset: 0x25582E1 VA: 0x25581E0
	|-HashCode.Combine<object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557F50 Offset: 0x2558051 VA: 0x2557F50
	|-HashCode.Combine<object, object, object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557CC0 Offset: 0x2557DC1 VA: 0x2557CC0
	|-HashCode.Combine<object, object, object, object, object, object, object, object>
	*/

	// RVA: 0x1BD4330 Offset: 0x1BD4431 VA: 0x1BD4330
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	// RVA: 0x1BD4410 Offset: 0x1BD4511 VA: 0x1BD4410
	private static uint Round(uint hash, uint input) { }

	// RVA: 0x1BD4430 Offset: 0x1BD4531 VA: 0x1BD4430
	private static uint QueueRound(uint hash, uint queuedValue) { }

	// RVA: 0x1BD4450 Offset: 0x1BD4551 VA: 0x1BD4450
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	// RVA: 0x1BD4470 Offset: 0x1BD4571 VA: 0x1BD4470
	private static uint MixEmptyState() { }

	// RVA: 0x1BD44F0 Offset: 0x1BD45F1 VA: 0x1BD44F0
	private static uint MixFinal(uint hash) { }

	// RVA: -1 Offset: -1
	public void Add<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3278F0 Offset: 0x3279F1 VA: 0x3278F0
	|-HashCode.Add<char>
	|
	|-RVA: 0x327930 Offset: 0x327A31 VA: 0x327930
	|-HashCode.Add<int>
	|
	|-RVA: 0x327970 Offset: 0x327A71 VA: 0x327970
	|-HashCode.Add<object>
	*/

	// RVA: -1 Offset: -1
	public void Add<T>(T value, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279B0 Offset: 0x327AB1 VA: 0x3279B0
	|-HashCode.Add<object>
	*/

	// RVA: 0x26520 Offset: 0x26621 VA: 0x26520
	private void Add(int value) { }

	// RVA: 0x26530 Offset: 0x26631 VA: 0x26530
	public int ToHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	[EditorBrowsableAttribute] // RVA: 0x139CA0 Offset: 0x139DA1 VA: 0x139CA0
	// RVA: 0x26540 Offset: 0x26641 VA: 0x26540 Slot: 2
	public override int GetHashCode() { }

	[ObsoleteAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	[EditorBrowsableAttribute] // RVA: 0x139D00 Offset: 0x139E01 VA: 0x139D00
	// RVA: 0x26550 Offset: 0x26651 VA: 0x26550 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BD49E0 Offset: 0x1BD4AE1 VA: 0x1BD49E0
	private static void .cctor() { }
}

