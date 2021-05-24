[ComVisibleAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[DefaultMemberAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1348
{
	// Fields
	private const int BitsPerInt32 = 32;
	private const int BytesPerInt32 = 4;
	private const int BitsPerByte = 8;
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _ShrinkThreshold = 256;

	// Properties
	public int Item { set; }
	public int Length { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x185C310 Offset: 0x185C411 VA: 0x185C310
	private void .ctor() { }

	// RVA: 0x185C320 Offset: 0x185C421 VA: 0x185C320
	public void .ctor(int length) { }

	// RVA: 0x185C330 Offset: 0x185C431 VA: 0x185C330
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x185C4A0 Offset: 0x185C5A1 VA: 0x185C4A0
	public void .ctor(int[] values) { }

	// RVA: 0x185C640 Offset: 0x185C741 VA: 0x185C640
	public void set_Item(int index, bool value) { }

	// RVA: 0x185C760 Offset: 0x185C861 VA: 0x185C760
	public bool Get(int index) { }

	// RVA: 0x185C650 Offset: 0x185C751 VA: 0x185C650
	public void Set(int index, bool value) { }

	// RVA: 0x185C850 Offset: 0x185C951 VA: 0x185C850
	public int get_Length() { }

	// RVA: 0x185C860 Offset: 0x185C961 VA: 0x185C860 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x185CC60 Offset: 0x185CD61 VA: 0x185CC60 Slot: 5
	public int get_Count() { }

	// RVA: 0x185CC70 Offset: 0x185CD71 VA: 0x185CC70 Slot: 7
	public object Clone() { }

	// RVA: 0x185CD00 Offset: 0x185CE01 VA: 0x185CD00 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x185C480 Offset: 0x185C581 VA: 0x185C480
	private static int GetArrayLength(int n, int div) { }
}

[ComVisibleAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[DefaultMemberAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1348
{
	// Fields
	private const int BitsPerInt32 = 32;
	private const int BytesPerInt32 = 4;
	private const int BitsPerByte = 8;
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _ShrinkThreshold = 256;

	// Properties
	public int Item { set; }
	public int Length { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x185C310 Offset: 0x185C411 VA: 0x185C310
	private void .ctor() { }

	// RVA: 0x185C320 Offset: 0x185C421 VA: 0x185C320
	public void .ctor(int length) { }

	// RVA: 0x185C330 Offset: 0x185C431 VA: 0x185C330
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x185C4A0 Offset: 0x185C5A1 VA: 0x185C4A0
	public void .ctor(int[] values) { }

	// RVA: 0x185C640 Offset: 0x185C741 VA: 0x185C640
	public void set_Item(int index, bool value) { }

	// RVA: 0x185C760 Offset: 0x185C861 VA: 0x185C760
	public bool Get(int index) { }

	// RVA: 0x185C650 Offset: 0x185C751 VA: 0x185C650
	public void Set(int index, bool value) { }

	// RVA: 0x185C850 Offset: 0x185C951 VA: 0x185C850
	public int get_Length() { }

	// RVA: 0x185C860 Offset: 0x185C961 VA: 0x185C860 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x185CC60 Offset: 0x185CD61 VA: 0x185CC60 Slot: 5
	public int get_Count() { }

	// RVA: 0x185CC70 Offset: 0x185CD71 VA: 0x185CC70 Slot: 7
	public object Clone() { }

	// RVA: 0x185CD00 Offset: 0x185CE01 VA: 0x185CD00 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x185C480 Offset: 0x185C581 VA: 0x185C480
	private static int GetArrayLength(int n, int div) { }
}

[ComVisibleAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[DefaultMemberAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1348
{
	// Fields
	private const int BitsPerInt32 = 32;
	private const int BytesPerInt32 = 4;
	private const int BitsPerByte = 8;
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _ShrinkThreshold = 256;

	// Properties
	public int Item { set; }
	public int Length { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x185C310 Offset: 0x185C411 VA: 0x185C310
	private void .ctor() { }

	// RVA: 0x185C320 Offset: 0x185C421 VA: 0x185C320
	public void .ctor(int length) { }

	// RVA: 0x185C330 Offset: 0x185C431 VA: 0x185C330
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x185C4A0 Offset: 0x185C5A1 VA: 0x185C4A0
	public void .ctor(int[] values) { }

	// RVA: 0x185C640 Offset: 0x185C741 VA: 0x185C640
	public void set_Item(int index, bool value) { }

	// RVA: 0x185C760 Offset: 0x185C861 VA: 0x185C760
	public bool Get(int index) { }

	// RVA: 0x185C650 Offset: 0x185C751 VA: 0x185C650
	public void Set(int index, bool value) { }

	// RVA: 0x185C850 Offset: 0x185C951 VA: 0x185C850
	public int get_Length() { }

	// RVA: 0x185C860 Offset: 0x185C961 VA: 0x185C860 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x185CC60 Offset: 0x185CD61 VA: 0x185CC60 Slot: 5
	public int get_Count() { }

	// RVA: 0x185CC70 Offset: 0x185CD71 VA: 0x185CC70 Slot: 7
	public object Clone() { }

	// RVA: 0x185CD00 Offset: 0x185CE01 VA: 0x185CD00 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x185C480 Offset: 0x185C581 VA: 0x185C480
	private static int GetArrayLength(int n, int div) { }
}

[ComVisibleAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[DefaultMemberAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1348
{
	// Fields
	private const int BitsPerInt32 = 32;
	private const int BytesPerInt32 = 4;
	private const int BitsPerByte = 8;
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _ShrinkThreshold = 256;

	// Properties
	public int Item { set; }
	public int Length { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x185C310 Offset: 0x185C411 VA: 0x185C310
	private void .ctor() { }

	// RVA: 0x185C320 Offset: 0x185C421 VA: 0x185C320
	public void .ctor(int length) { }

	// RVA: 0x185C330 Offset: 0x185C431 VA: 0x185C330
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x185C4A0 Offset: 0x185C5A1 VA: 0x185C4A0
	public void .ctor(int[] values) { }

	// RVA: 0x185C640 Offset: 0x185C741 VA: 0x185C640
	public void set_Item(int index, bool value) { }

	// RVA: 0x185C760 Offset: 0x185C861 VA: 0x185C760
	public bool Get(int index) { }

	// RVA: 0x185C650 Offset: 0x185C751 VA: 0x185C650
	public void Set(int index, bool value) { }

	// RVA: 0x185C850 Offset: 0x185C951 VA: 0x185C850
	public int get_Length() { }

	// RVA: 0x185C860 Offset: 0x185C961 VA: 0x185C860 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x185CC60 Offset: 0x185CD61 VA: 0x185CC60 Slot: 5
	public int get_Count() { }

	// RVA: 0x185CC70 Offset: 0x185CD71 VA: 0x185CC70 Slot: 7
	public object Clone() { }

	// RVA: 0x185CD00 Offset: 0x185CE01 VA: 0x185CD00 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x185C480 Offset: 0x185C581 VA: 0x185C480
	private static int GetArrayLength(int n, int div) { }
}

[ComVisibleAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[DefaultMemberAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1348
{
	// Fields
	private const int BitsPerInt32 = 32;
	private const int BytesPerInt32 = 4;
	private const int BitsPerByte = 8;
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _ShrinkThreshold = 256;

	// Properties
	public int Item { set; }
	public int Length { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x185C310 Offset: 0x185C411 VA: 0x185C310
	private void .ctor() { }

	// RVA: 0x185C320 Offset: 0x185C421 VA: 0x185C320
	public void .ctor(int length) { }

	// RVA: 0x185C330 Offset: 0x185C431 VA: 0x185C330
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x185C4A0 Offset: 0x185C5A1 VA: 0x185C4A0
	public void .ctor(int[] values) { }

	// RVA: 0x185C640 Offset: 0x185C741 VA: 0x185C640
	public void set_Item(int index, bool value) { }

	// RVA: 0x185C760 Offset: 0x185C861 VA: 0x185C760
	public bool Get(int index) { }

	// RVA: 0x185C650 Offset: 0x185C751 VA: 0x185C650
	public void Set(int index, bool value) { }

	// RVA: 0x185C850 Offset: 0x185C951 VA: 0x185C850
	public int get_Length() { }

	// RVA: 0x185C860 Offset: 0x185C961 VA: 0x185C860 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x185CC60 Offset: 0x185CD61 VA: 0x185CC60 Slot: 5
	public int get_Count() { }

	// RVA: 0x185CC70 Offset: 0x185CD71 VA: 0x185CC70 Slot: 7
	public object Clone() { }

	// RVA: 0x185CD00 Offset: 0x185CE01 VA: 0x185CD00 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x185C480 Offset: 0x185C581 VA: 0x185C480
	private static int GetArrayLength(int n, int div) { }
}

[ComVisibleAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[DefaultMemberAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1348
{
	// Fields
	private const int BitsPerInt32 = 32;
	private const int BytesPerInt32 = 4;
	private const int BitsPerByte = 8;
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _ShrinkThreshold = 256;

	// Properties
	public int Item { set; }
	public int Length { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x185C310 Offset: 0x185C411 VA: 0x185C310
	private void .ctor() { }

	// RVA: 0x185C320 Offset: 0x185C421 VA: 0x185C320
	public void .ctor(int length) { }

	// RVA: 0x185C330 Offset: 0x185C431 VA: 0x185C330
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x185C4A0 Offset: 0x185C5A1 VA: 0x185C4A0
	public void .ctor(int[] values) { }

	// RVA: 0x185C640 Offset: 0x185C741 VA: 0x185C640
	public void set_Item(int index, bool value) { }

	// RVA: 0x185C760 Offset: 0x185C861 VA: 0x185C760
	public bool Get(int index) { }

	// RVA: 0x185C650 Offset: 0x185C751 VA: 0x185C650
	public void Set(int index, bool value) { }

	// RVA: 0x185C850 Offset: 0x185C951 VA: 0x185C850
	public int get_Length() { }

	// RVA: 0x185C860 Offset: 0x185C961 VA: 0x185C860 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x185CC60 Offset: 0x185CD61 VA: 0x185CC60 Slot: 5
	public int get_Count() { }

	// RVA: 0x185CC70 Offset: 0x185CD71 VA: 0x185CC70 Slot: 7
	public object Clone() { }

	// RVA: 0x185CD00 Offset: 0x185CE01 VA: 0x185CD00 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x185C480 Offset: 0x185C581 VA: 0x185C480
	private static int GetArrayLength(int n, int div) { }
}

[ComVisibleAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[DefaultMemberAttribute] // RVA: 0xB2A90 Offset: 0xB2B91 VA: 0xB2A90
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1348
{
	// Fields
	private const int BitsPerInt32 = 32;
	private const int BytesPerInt32 = 4;
	private const int BitsPerByte = 8;
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _ShrinkThreshold = 256;

	// Properties
	public int Item { set; }
	public int Length { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x185C310 Offset: 0x185C411 VA: 0x185C310
	private void .ctor() { }

	// RVA: 0x185C320 Offset: 0x185C421 VA: 0x185C320
	public void .ctor(int length) { }

	// RVA: 0x185C330 Offset: 0x185C431 VA: 0x185C330
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x185C4A0 Offset: 0x185C5A1 VA: 0x185C4A0
	public void .ctor(int[] values) { }

	// RVA: 0x185C640 Offset: 0x185C741 VA: 0x185C640
	public void set_Item(int index, bool value) { }

	// RVA: 0x185C760 Offset: 0x185C861 VA: 0x185C760
	public bool Get(int index) { }

	// RVA: 0x185C650 Offset: 0x185C751 VA: 0x185C650
	public void Set(int index, bool value) { }

	// RVA: 0x185C850 Offset: 0x185C951 VA: 0x185C850
	public int get_Length() { }

	// RVA: 0x185C860 Offset: 0x185C961 VA: 0x185C860 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x185CC60 Offset: 0x185CD61 VA: 0x185CC60 Slot: 5
	public int get_Count() { }

	// RVA: 0x185CC70 Offset: 0x185CD71 VA: 0x185CC70 Slot: 7
	public object Clone() { }

	// RVA: 0x185CD00 Offset: 0x185CE01 VA: 0x185CD00 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x185C480 Offset: 0x185C581 VA: 0x185C480
	private static int GetArrayLength(int n, int div) { }
}

