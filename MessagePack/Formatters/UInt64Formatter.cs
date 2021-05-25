public sealed class UInt64Formatter : IMessagePackFormatter<ulong>, IMessagePackFormatter // TypeDefIndex: 5478
{
	// Fields
	public static readonly UInt64Formatter Instance; // 0x0

	// Methods

	// RVA: 0x1662D90 Offset: 0x1662E91 VA: 0x1662D90
	private void .ctor() { }

	// RVA: 0x1662DA0 Offset: 0x1662EA1 VA: 0x1662DA0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ulong value, MessagePackSerializerOptions options) { }

	// RVA: 0x1662DB0 Offset: 0x1662EB1 VA: 0x1662DB0 Slot: 5
	public ulong Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1662DC0 Offset: 0x1662EC1 VA: 0x1662DC0
	private static void .cctor() { }
}

