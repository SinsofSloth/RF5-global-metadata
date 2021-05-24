[MovedFromAttribute] // RVA: 0xC7720 Offset: 0xC7821 VA: 0xC7720
[NativeHeaderAttribute] // RVA: 0xC7720 Offset: 0xC7821 VA: 0xC7720
[NativeHeaderAttribute] // RVA: 0xC7720 Offset: 0xC7821 VA: 0xC7720
[NativeHeaderAttribute] // RVA: 0xC7720 Offset: 0xC7821 VA: 0xC7720
[NativeHeaderAttribute] // RVA: 0xC7720 Offset: 0xC7821 VA: 0xC7720
[UsedByNativeCodeAttribute] // RVA: 0xC7720 Offset: 0xC7821 VA: 0xC7720
[NativeHeaderAttribute] // RVA: 0xC7720 Offset: 0xC7821 VA: 0xC7720
public sealed class Profiler // TypeDefIndex: 3088
{
	// Properties
	public static bool supported { get; }
	public static bool enabled { get; set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xD8FD0 Offset: 0xD90D1 VA: 0xD8FD0
	// RVA: 0x2B73660 Offset: 0x2B73761 VA: 0x2B73660
	public static bool get_supported() { }

	[NativeMethodAttribute] // RVA: 0xD9020 Offset: 0xD9121 VA: 0xD9020
	[NativeConditionalAttribute] // RVA: 0xD9020 Offset: 0xD9121 VA: 0xD9020
	// RVA: 0x2B736A0 Offset: 0x2B737A1 VA: 0x2B736A0
	public static bool get_enabled() { }

	[NativeMethodAttribute] // RVA: 0xD90A0 Offset: 0xD91A1 VA: 0xD90A0
	// RVA: 0x2B736E0 Offset: 0x2B737E1 VA: 0x2B736E0
	public static void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0xD90F0 Offset: 0xD91F1 VA: 0xD90F0
	// RVA: 0x2B73730 Offset: 0x2B73831 VA: 0x2B73730
	public static long GetMonoHeapSizeLong() { }

	[NativeMethodAttribute] // RVA: 0xD9140 Offset: 0xD9241 VA: 0xD9140
	// RVA: 0x2B73770 Offset: 0x2B73871 VA: 0x2B73770
	public static long GetMonoUsedSizeLong() { }

	[StaticAccessorAttribute] // RVA: 0xD9190 Offset: 0xD9291 VA: 0xD9190
	[NativeConditionalAttribute] // RVA: 0xD9190 Offset: 0xD9291 VA: 0xD9190
	[NativeMethodAttribute] // RVA: 0xD9190 Offset: 0xD9291 VA: 0xD9190
	// RVA: 0x2B737B0 Offset: 0x2B738B1 VA: 0x2B737B0
	public static long GetTotalAllocatedMemoryLong() { }

	[StaticAccessorAttribute] // RVA: 0xD9230 Offset: 0xD9331 VA: 0xD9230
	[NativeConditionalAttribute] // RVA: 0xD9230 Offset: 0xD9331 VA: 0xD9230
	[NativeMethodAttribute] // RVA: 0xD9230 Offset: 0xD9331 VA: 0xD9230
	// RVA: 0x2B737F0 Offset: 0x2B738F1 VA: 0x2B737F0
	public static long GetTotalReservedMemoryLong() { }
}

