[DefaultMemberAttribute] // RVA: 0x108940 Offset: 0x108A41 VA: 0x108940
public struct Vector<T> : IEquatable<Vector<T>>, IFormattable // TypeDefIndex: 3758
{
	// Fields
	private Register register; // 0x0
	private static readonly int s_count; // 0x0
	private static readonly Vector<T> zero; // 0x0
	private static readonly Vector<T> one; // 0x0
	private static readonly Vector<T> allOnes; // 0x0

	// Properties
	[JitIntrinsicAttribute] // RVA: 0x108A20 Offset: 0x108B21 VA: 0x108A20
	public static int Count { get; }
	[JitIntrinsicAttribute] // RVA: 0x108A30 Offset: 0x108B31 VA: 0x108A30
	public static Vector<T> Zero { get; }
	[JitIntrinsicAttribute] // RVA: 0x108A40 Offset: 0x108B41 VA: 0x108A40
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x245ACA0 Offset: 0x245ADA1 VA: 0x245ACA0
	|-Vector<byte>.get_Count
	|
	|-RVA: 0x2C0A930 Offset: 0x2C0AA31 VA: 0x2C0A930
	|-Vector<ushort>.get_Count
	|
	|-RVA: 0x2C18960 Offset: 0x2C18A61 VA: 0x2C18960
	|-Vector<uint>.get_Count
	|
	|-RVA: 0x2C26990 Offset: 0x2C26A91 VA: 0x2C26990
	|-Vector<ulong>.get_Count
	*/

	// RVA: -1 Offset: -1
	public static Vector<T> get_Zero() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x245ADD0 Offset: 0x245AED1 VA: 0x245ADD0
	|-Vector<byte>.get_Zero
	|
	|-RVA: 0x2C0AA60 Offset: 0x2C0AB61 VA: 0x2C0AA60
	|-Vector<ushort>.get_Zero
	|
	|-RVA: 0x2C18A90 Offset: 0x2C18B91 VA: 0x2C18A90
	|-Vector<uint>.get_Zero
	|
	|-RVA: 0x2C26AC0 Offset: 0x2C26BC1 VA: 0x2C26AC0
	|-Vector<ulong>.get_Zero
	*/

	// RVA: -1 Offset: -1
	private static int InitializeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x245AF00 Offset: 0x245B001 VA: 0x245AF00
	|-Vector<byte>.InitializeCount
	|
	|-RVA: 0x2C0AB90 Offset: 0x2C0AC91 VA: 0x2C0AB90
	|-Vector<ushort>.InitializeCount
	|
	|-RVA: 0x2C18BC0 Offset: 0x2C18CC1 VA: 0x2C18BC0
	|-Vector<uint>.InitializeCount
	|
	|-RVA: 0x2C26BF0 Offset: 0x2C26CF1 VA: 0x2C26BF0
	|-Vector<ulong>.InitializeCount
	*/

	[JitIntrinsicAttribute] // RVA: 0x108980 Offset: 0x108A81 VA: 0x108980
	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315AD0 Offset: 0x315BD1 VA: 0x315AD0
	|-Vector<byte>..ctor
	|
	|-RVA: 0x3852F0 Offset: 0x3853F1 VA: 0x3852F0
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x3853D0 Offset: 0x3854D1 VA: 0x3853D0
	|-Vector<uint>..ctor
	|
	|-RVA: 0x3854B0 Offset: 0x3855B1 VA: 0x3854B0
	|-Vector<ulong>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315AE0 Offset: 0x315BE1 VA: 0x315AE0
	|-Vector<byte>..ctor
	|
	|-RVA: 0x385300 Offset: 0x385401 VA: 0x385300
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x3853E0 Offset: 0x3854E1 VA: 0x3853E0
	|-Vector<uint>..ctor
	|
	|-RVA: 0x3854C0 Offset: 0x3855C1 VA: 0x3854C0
	|-Vector<ulong>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B30 Offset: 0x315C31 VA: 0x315B30
	|-Vector<byte>..ctor
	|
	|-RVA: 0x385350 Offset: 0x385451 VA: 0x385350
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x385430 Offset: 0x385531 VA: 0x385430
	|-Vector<uint>..ctor
	|
	|-RVA: 0x385510 Offset: 0x385611 VA: 0x385510
	|-Vector<ulong>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(ref Register existingRegister) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B40 Offset: 0x315C41 VA: 0x315B40
	|-Vector<byte>..ctor
	|
	|-RVA: 0x385360 Offset: 0x385461 VA: 0x385360
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x385440 Offset: 0x385541 VA: 0x385440
	|-Vector<uint>..ctor
	|
	|-RVA: 0x385520 Offset: 0x385621 VA: 0x385520
	|-Vector<ulong>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x385530 Offset: 0x385631 VA: 0x385530
	|-Vector<ulong>.get_Item
	|
	|-RVA: 0x315B50 Offset: 0x315C51 VA: 0x315B50
	|-Vector<byte>.get_Item
	|
	|-RVA: 0x385370 Offset: 0x385471 VA: 0x385370
	|-Vector<ushort>.get_Item
	|
	|-RVA: 0x385450 Offset: 0x385551 VA: 0x385450
	|-Vector<uint>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B60 Offset: 0x315C61 VA: 0x315B60
	|-Vector<byte>.Equals
	|
	|-RVA: 0x385380 Offset: 0x385481 VA: 0x385380
	|-Vector<ushort>.Equals
	|
	|-RVA: 0x385460 Offset: 0x385561 VA: 0x385460
	|-Vector<uint>.Equals
	|
	|-RVA: 0x385540 Offset: 0x385641 VA: 0x385540
	|-Vector<ulong>.Equals
	*/

	[JitIntrinsicAttribute] // RVA: 0x108990 Offset: 0x108A91 VA: 0x108990
	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Vector<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B70 Offset: 0x315C71 VA: 0x315B70
	|-Vector<byte>.Equals
	|
	|-RVA: 0x385390 Offset: 0x385491 VA: 0x385390
	|-Vector<ushort>.Equals
	|
	|-RVA: 0x385470 Offset: 0x385571 VA: 0x385470
	|-Vector<uint>.Equals
	|
	|-RVA: 0x385550 Offset: 0x385651 VA: 0x385550
	|-Vector<ulong>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B80 Offset: 0x315C81 VA: 0x315B80
	|-Vector<byte>.GetHashCode
	|
	|-RVA: 0x3853A0 Offset: 0x3854A1 VA: 0x3853A0
	|-Vector<ushort>.GetHashCode
	|
	|-RVA: 0x385480 Offset: 0x385581 VA: 0x385480
	|-Vector<uint>.GetHashCode
	|
	|-RVA: 0x385560 Offset: 0x385661 VA: 0x385560
	|-Vector<ulong>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B90 Offset: 0x315C91 VA: 0x315B90
	|-Vector<byte>.ToString
	|
	|-RVA: 0x3853B0 Offset: 0x3854B1 VA: 0x3853B0
	|-Vector<ushort>.ToString
	|
	|-RVA: 0x385490 Offset: 0x385591 VA: 0x385490
	|-Vector<uint>.ToString
	|
	|-RVA: 0x385570 Offset: 0x385671 VA: 0x385570
	|-Vector<ulong>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315BA0 Offset: 0x315CA1 VA: 0x315BA0
	|-Vector<byte>.ToString
	|
	|-RVA: 0x3853C0 Offset: 0x3854C1 VA: 0x3853C0
	|-Vector<ushort>.ToString
	|
	|-RVA: 0x3854A0 Offset: 0x3855A1 VA: 0x3854A0
	|-Vector<uint>.ToString
	|
	|-RVA: 0x385580 Offset: 0x385681 VA: 0x385580
	|-Vector<ulong>.ToString
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2463480 Offset: 0x2463581 VA: 0x2463480
	|-Vector<byte>.op_Equality
	|
	|-RVA: 0x2C13110 Offset: 0x2C13211 VA: 0x2C13110
	|-Vector<ushort>.op_Equality
	|
	|-RVA: 0x2C21140 Offset: 0x2C21241 VA: 0x2C21140
	|-Vector<uint>.op_Equality
	|
	|-RVA: 0x2C2F170 Offset: 0x2C2F271 VA: 0x2C2F170
	|-Vector<ulong>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24634F0 Offset: 0x24635F1 VA: 0x24634F0
	|-Vector<byte>.op_Inequality
	|
	|-RVA: 0x2C13180 Offset: 0x2C13281 VA: 0x2C13180
	|-Vector<ushort>.op_Inequality
	|
	|-RVA: 0x2C211B0 Offset: 0x2C212B1 VA: 0x2C211B0
	|-Vector<uint>.op_Inequality
	|
	|-RVA: 0x2C2F1E0 Offset: 0x2C2F2E1 VA: 0x2C2F1E0
	|-Vector<ulong>.op_Inequality
	*/

	[JitIntrinsicAttribute] // RVA: 0x1089A0 Offset: 0x108AA1 VA: 0x1089A0
	// RVA: -1 Offset: -1
	public static Vector<byte> op_Explicit(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2463670 Offset: 0x2463771 VA: 0x2463670
	|-Vector<byte>.op_Explicit
	|
	|-RVA: 0x2C13300 Offset: 0x2C13401 VA: 0x2C13300
	|-Vector<ushort>.op_Explicit
	|
	|-RVA: 0x2C21330 Offset: 0x2C21431 VA: 0x2C21330
	|-Vector<uint>.op_Explicit
	|
	|-RVA: 0x2C2F360 Offset: 0x2C2F461 VA: 0x2C2F360
	|-Vector<ulong>.op_Explicit
	*/

	[JitIntrinsicAttribute] // RVA: 0x1089B0 Offset: 0x108AB1 VA: 0x1089B0
	[CLSCompliantAttribute] // RVA: 0x1089B0 Offset: 0x108AB1 VA: 0x1089B0
	// RVA: -1 Offset: -1
	public static Vector<ulong> op_Explicit(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24636D0 Offset: 0x24637D1 VA: 0x24636D0
	|-Vector<byte>.op_Explicit
	|
	|-RVA: 0x2C13370 Offset: 0x2C13471 VA: 0x2C13370
	|-Vector<ushort>.op_Explicit
	|
	|-RVA: 0x2C213A0 Offset: 0x2C214A1 VA: 0x2C213A0
	|-Vector<uint>.op_Explicit
	|
	|-RVA: 0x2C2F3D0 Offset: 0x2C2F4D1 VA: 0x2C2F3D0
	|-Vector<ulong>.op_Explicit
	*/

	[JitIntrinsicAttribute] // RVA: 0x1089F0 Offset: 0x108AF1 VA: 0x1089F0
	// RVA: -1 Offset: -1
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2463740 Offset: 0x2463841 VA: 0x2463740
	|-Vector<byte>.Equals
	|
	|-RVA: 0x2C133D0 Offset: 0x2C134D1 VA: 0x2C133D0
	|-Vector<ushort>.Equals
	|
	|-RVA: 0x2C21400 Offset: 0x2C21501 VA: 0x2C21400
	|-Vector<uint>.Equals
	|
	|-RVA: 0x2C2F430 Offset: 0x2C2F531 VA: 0x2C2F430
	|-Vector<ulong>.Equals
	*/

	// RVA: -1 Offset: -1
	private static bool ScalarEquals(T left, T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2466A50 Offset: 0x2466B51 VA: 0x2466A50
	|-Vector<byte>.ScalarEquals
	|
	|-RVA: 0x2C166E0 Offset: 0x2C167E1 VA: 0x2C166E0
	|-Vector<ushort>.ScalarEquals
	|
	|-RVA: 0x2C24710 Offset: 0x2C24811 VA: 0x2C24710
	|-Vector<uint>.ScalarEquals
	|
	|-RVA: 0x2C32740 Offset: 0x2C32841 VA: 0x2C32740
	|-Vector<ulong>.ScalarEquals
	*/

	// RVA: -1 Offset: -1
	private static T GetZeroValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2467820 Offset: 0x2467921 VA: 0x2467820
	|-Vector<byte>.GetZeroValue
	|
	|-RVA: 0x2C174B0 Offset: 0x2C175B1 VA: 0x2C174B0
	|-Vector<ushort>.GetZeroValue
	|
	|-RVA: 0x2C254E0 Offset: 0x2C255E1 VA: 0x2C254E0
	|-Vector<uint>.GetZeroValue
	|
	|-RVA: 0x2C33510 Offset: 0x2C33611 VA: 0x2C33510
	|-Vector<ulong>.GetZeroValue
	*/

	// RVA: -1 Offset: -1
	private static T GetOneValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2467E00 Offset: 0x2467F01 VA: 0x2467E00
	|-Vector<byte>.GetOneValue
	|
	|-RVA: 0x2C17A90 Offset: 0x2C17B91 VA: 0x2C17A90
	|-Vector<ushort>.GetOneValue
	|
	|-RVA: 0x2C25AC0 Offset: 0x2C25BC1 VA: 0x2C25AC0
	|-Vector<uint>.GetOneValue
	|
	|-RVA: 0x2C33AF0 Offset: 0x2C33BF1 VA: 0x2C33AF0
	|-Vector<ulong>.GetOneValue
	*/

	// RVA: -1 Offset: -1
	private static T GetAllBitsSetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2468410 Offset: 0x2468511 VA: 0x2468410
	|-Vector<byte>.GetAllBitsSetValue
	|
	|-RVA: 0x2C180A0 Offset: 0x2C181A1 VA: 0x2C180A0
	|-Vector<ushort>.GetAllBitsSetValue
	|
	|-RVA: 0x2C260D0 Offset: 0x2C261D1 VA: 0x2C260D0
	|-Vector<uint>.GetAllBitsSetValue
	|
	|-RVA: 0x2C34100 Offset: 0x2C34201 VA: 0x2C34100
	|-Vector<ulong>.GetAllBitsSetValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2468A20 Offset: 0x2468B21 VA: 0x2468A20
	|-Vector<byte>..cctor
	|
	|-RVA: 0x2C186B0 Offset: 0x2C187B1 VA: 0x2C186B0
	|-Vector<ushort>..cctor
	|
	|-RVA: 0x2C266E0 Offset: 0x2C267E1 VA: 0x2C266E0
	|-Vector<uint>..cctor
	|
	|-RVA: 0x2C34710 Offset: 0x2C34811 VA: 0x2C34710
	|-Vector<ulong>..cctor
	*/
}

