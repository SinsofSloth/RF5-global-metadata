internal class SequencePool // TypeDefIndex: 5170
{
	// Fields
	internal static readonly SequencePool Shared; // 0x0
	private const int MinimumSpanLength = 32768;
	private readonly int maxSize; // 0x10
	private readonly Stack<Sequence<byte>> pool; // 0x18
	private readonly ArrayPool<byte> arrayPool; // 0x20

	// Methods

	// RVA: 0x14F9840 Offset: 0x14F9941 VA: 0x14F9840
	internal void .ctor(int maxSize) { }

	// RVA: 0x14EAD80 Offset: 0x14EAE81 VA: 0x14EAD80
	internal SequencePool.Rental Rent() { }

	// RVA: 0x14F9940 Offset: 0x14F9A41 VA: 0x14F9940
	private void Return(Sequence<byte> value) { }

	// RVA: 0x14F9A70 Offset: 0x14F9B71 VA: 0x14F9A70
	private static void .cctor() { }
}

