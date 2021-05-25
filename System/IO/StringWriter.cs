[ComVisibleAttribute] // RVA: 0xAEA80 Offset: 0xAEB81 VA: 0xAEA80
[Serializable]
public class StringWriter : TextWriter // TypeDefIndex: 667
{
	// Fields
	private StringBuilder _sb; // 0x28
	private bool _isOpen; // 0x30

	// Methods

	// RVA: 0x18B60E0 Offset: 0x18B61E1 VA: 0x18B60E0
	public void .ctor() { }

	// RVA: 0x18B6170 Offset: 0x18B6271 VA: 0x18B6170
	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	// RVA: 0x18B6260 Offset: 0x18B6361 VA: 0x18B6260 Slot: 8
	public override void Close() { }

	// RVA: 0x18B6270 Offset: 0x18B6371 VA: 0x18B6270 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B6280 Offset: 0x18B6381 VA: 0x18B6280 Slot: 11
	public override void Write(char value) { }

	// RVA: 0x18B62D0 Offset: 0x18B63D1 VA: 0x18B62D0 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18B6490 Offset: 0x18B6591 VA: 0x18B6490 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x18B64F0 Offset: 0x18B65F1 VA: 0x18B64F0 Slot: 3
	public override string ToString() { }
}

