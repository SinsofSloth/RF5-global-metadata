[Serializable]
internal sealed class TextWriter.SyncTextWriter : TextWriter, IDisposable // TypeDefIndex: 674
{
	// Fields
	private TextWriter _out; // 0x28

	// Properties
	public override IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x18B7400 Offset: 0x18B7501 VA: 0x18B7400
	internal void .ctor(TextWriter t) { }

	// RVA: 0x18B8360 Offset: 0x18B8461 VA: 0x18B8360 Slot: 7
	public override IFormatProvider get_FormatProvider() { }

	// RVA: 0x18B8380 Offset: 0x18B8481 VA: 0x18B8380 Slot: 8
	public override void Close() { }

	// RVA: 0x18B83A0 Offset: 0x18B84A1 VA: 0x18B83A0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B8470 Offset: 0x18B8571 VA: 0x18B8470 Slot: 10
	public override void Flush() { }

	// RVA: 0x18B8490 Offset: 0x18B8591 VA: 0x18B8490 Slot: 11
	public override void Write(char value) { }

	// RVA: 0x18B84B0 Offset: 0x18B85B1 VA: 0x18B84B0 Slot: 12
	public override void Write(char[] buffer) { }

	// RVA: 0x18B84D0 Offset: 0x18B85D1 VA: 0x18B84D0 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18B8500 Offset: 0x18B8601 VA: 0x18B8500 Slot: 14
	public override void Write(int value) { }

	// RVA: 0x18B8530 Offset: 0x18B8631 VA: 0x18B8530 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x18B8560 Offset: 0x18B8661 VA: 0x18B8560 Slot: 16
	public override void WriteLine() { }

	// RVA: 0x18B8590 Offset: 0x18B8691 VA: 0x18B8590 Slot: 17
	public override void WriteLine(char value) { }

	// RVA: 0x18B85C0 Offset: 0x18B86C1 VA: 0x18B85C0 Slot: 18
	public override void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x18B85F0 Offset: 0x18B86F1 VA: 0x18B85F0 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0x18B8620 Offset: 0x18B8721 VA: 0x18B8620 Slot: 20
	public override void WriteLine(string format, object arg0) { }

	// RVA: 0x18B8650 Offset: 0x18B8751 VA: 0x18B8650 Slot: 21
	public override void WriteLine(string format, object arg0, object arg1) { }
}

