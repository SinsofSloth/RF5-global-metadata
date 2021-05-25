internal sealed class SerStack // TypeDefIndex: 1091
{
	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x150A6A0 Offset: 0x150A7A1 VA: 0x150A6A0
	internal void .ctor(string stackId) { }

	// RVA: 0x150A730 Offset: 0x150A831 VA: 0x150A730
	internal void Push(object obj) { }

	// RVA: 0x150A890 Offset: 0x150A991 VA: 0x150A890
	internal object Pop() { }

	// RVA: 0x150A7F0 Offset: 0x150A8F1 VA: 0x150A7F0
	internal void IncreaseCapacity() { }

	// RVA: 0x150A920 Offset: 0x150AA21 VA: 0x150A920
	internal object Peek() { }

	// RVA: 0x150A970 Offset: 0x150AA71 VA: 0x150A970
	internal object PeekPeek() { }

	// RVA: 0x150A9D0 Offset: 0x150AAD1 VA: 0x150A9D0
	internal bool IsEmpty() { }
}

