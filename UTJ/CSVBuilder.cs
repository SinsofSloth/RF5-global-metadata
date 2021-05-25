public class CSVBuilder // TypeDefIndex: 9172
{
	// Fields
	private StringBuilder builder; // 0x10
	private char separatorCharacter; // 0x18
	private string currentSeparator; // 0x20

	// Methods

	// RVA: 0x1FFA1D0 Offset: 0x1FFA2D1 VA: 0x1FFA1D0
	public void .ctor(char newSeparatorCharacter = '\x2c') { }

	// RVA: 0x1FFA270 Offset: 0x1FFA371 VA: 0x1FFA270
	public void Append(string item) { }

	// RVA: 0x1FFA3B0 Offset: 0x1FFA4B1 VA: 0x1FFA3B0
	public void Append(GameObject gameObject) { }

	// RVA: 0x1FFA510 Offset: 0x1FFA611 VA: 0x1FFA510
	public void Append(object item) { }

	// RVA: 0x1FFAFD0 Offset: 0x1FFB0D1 VA: 0x1FFAFD0
	public void Append(Vector3 vector) { }

	// RVA: 0x1FFA710 Offset: 0x1FFA811 VA: 0x1FFA710
	public void Append(Transform transform) { }

	// RVA: 0x1FFB090 Offset: 0x1FFB191 VA: 0x1FFB090
	public void Append(IEnumerable<string> list) { }

	// RVA: 0x1FFB300 Offset: 0x1FFB401 VA: 0x1FFB300
	public void AppendLine() { }

	// RVA: 0x1FFB370 Offset: 0x1FFB471 VA: 0x1FFB370
	public void AppendLine(string item) { }

	// RVA: 0x1FFB3E0 Offset: 0x1FFB4E1 VA: 0x1FFB3E0
	public void AppendLine(IEnumerable<string> list) { }

	// RVA: 0x1FFB450 Offset: 0x1FFB551 VA: 0x1FFB450 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FFA870 Offset: 0x1FFA971 VA: 0x1FFA870
	private void InternalAppend(Type itemType, object item) { }
}

