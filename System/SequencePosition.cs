[IsReadOnlyAttribute] // RVA: 0x1286D0 Offset: 0x1287D1 VA: 0x1286D0
public struct SequencePosition : IEquatable<SequencePosition> // TypeDefIndex: 4371
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _integer; // 0x8

	// Methods

	// RVA: 0x20C70 Offset: 0x20D71 VA: 0x20C70
	public void .ctor(object object, int integer) { }

	[EditorBrowsableAttribute] // RVA: 0x128C30 Offset: 0x128D31 VA: 0x128C30
	// RVA: 0x20CA0 Offset: 0x20DA1 VA: 0x20CA0
	public object GetObject() { }

	[EditorBrowsableAttribute] // RVA: 0x128C50 Offset: 0x128D51 VA: 0x128C50
	// RVA: 0x20CB0 Offset: 0x20DB1 VA: 0x20CB0
	public int GetInteger() { }

	// RVA: 0x20CC0 Offset: 0x20DC1 VA: 0x20CC0 Slot: 4
	public bool Equals(SequencePosition other) { }

	[EditorBrowsableAttribute] // RVA: 0x128C70 Offset: 0x128D71 VA: 0x128C70
	// RVA: 0x20CE0 Offset: 0x20DE1 VA: 0x20CE0 Slot: 0
	public override bool Equals(object obj) { }

	[EditorBrowsableAttribute] // RVA: 0x128C90 Offset: 0x128D91 VA: 0x128C90
	// RVA: 0x20D80 Offset: 0x20E81 VA: 0x20D80 Slot: 2
	public override int GetHashCode() { }
}

