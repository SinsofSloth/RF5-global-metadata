public struct ConsumableServiceItemId // TypeDefIndex: 11695
{
	// Fields
	public const int Length = 16;
	public string value; // 0x0

	// Methods

	// RVA: 0x3620D0 Offset: 0x3621D1 VA: 0x3620D0
	public void .ctor(string _value) { }

	// RVA: 0x3620E0 Offset: 0x3621E1 VA: 0x3620E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3620F0 Offset: 0x3621F1 VA: 0x3620F0
	public bool IsValid() { }

	// RVA: 0x26A74B0 Offset: 0x26A75B1 VA: 0x26A74B0
	private static extern bool IsValid(ConsumableServiceItemId itemId) { }
}

