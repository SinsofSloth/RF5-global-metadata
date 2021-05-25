[AttributeUsageAttribute] // RVA: 0x12AC10 Offset: 0x12AD11 VA: 0x12AC10
internal class SupportsChildTracksAttribute : Attribute // TypeDefIndex: 4619
{
	// Fields
	public readonly Type childType; // 0x10
	public readonly int levels; // 0x18

	// Methods

	// RVA: 0x17E6860 Offset: 0x17E6961 VA: 0x17E6860
	public void .ctor(Type childType, int levels = 2147483647) { }
}

