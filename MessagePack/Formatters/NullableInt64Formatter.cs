public sealed class NullableInt64Formatter : IMessagePackFormatter<Nullable<long>>, IMessagePackFormatter // TypeDefIndex: 5470
{
	// Fields
	public static readonly NullableInt64Formatter Instance; // 0x0

	// Methods

	// RVA: 0x165F050 Offset: 0x165F151 VA: 0x165F050
	private void .ctor() { }

	// RVA: 0x165F060 Offset: 0x165F161 VA: 0x165F060 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<long> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165F100 Offset: 0x165F201 VA: 0x165F100 Slot: 5
	public Nullable<long> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165F1E0 Offset: 0x165F2E1 VA: 0x165F1E0
	private static void .cctor() { }
}

