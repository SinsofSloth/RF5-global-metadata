[AttributeUsageAttribute] // RVA: 0x12AB80 Offset: 0x12AC81 VA: 0x12AB80
public class TrackClipTypeAttribute : Attribute // TypeDefIndex: 4615
{
	// Fields
	public readonly Type inspectedType; // 0x10
	public readonly bool allowAutoCreate; // 0x18

	// Methods

	// RVA: 0x1B45980 Offset: 0x1B45A81 VA: 0x1B45980
	public void .ctor(Type clipClass) { }

	// RVA: 0x1B459C0 Offset: 0x1B45AC1 VA: 0x1B459C0
	public void .ctor(Type clipClass, bool allowAutoCreate) { }
}

