internal static class Internal_SubsystemInstances // TypeDefIndex: 3448
{
	// Fields
	internal static List<ISubsystem> s_IntegratedSubsystemInstances; // 0x0
	internal static List<ISubsystem> s_StandaloneSubsystemInstances; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xE5BF0 Offset: 0xE5CF1 VA: 0xE5BF0
	// RVA: 0x1BDDD70 Offset: 0x1BDDE71 VA: 0x1BDDD70
	internal static void Internal_InitializeManagedInstance(IntPtr ptr, IntegratedSubsystem inst) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xE5C00 Offset: 0xE5D01 VA: 0xE5C00
	// RVA: 0x1BDDE40 Offset: 0x1BDDF41 VA: 0x1BDDE40
	internal static void Internal_ClearManagedInstances() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xE5C10 Offset: 0xE5D11 VA: 0xE5C10
	// RVA: 0x1BDE000 Offset: 0x1BDE101 VA: 0x1BDE000
	internal static void Internal_RemoveInstanceByPtr(IntPtr ptr) { }

	// RVA: 0x1BDE1F0 Offset: 0x1BDE2F1 VA: 0x1BDE1F0
	internal static IntegratedSubsystem Internal_GetInstanceByPtr(IntPtr ptr) { }

	// RVA: 0x1BDE390 Offset: 0x1BDE491 VA: 0x1BDE390
	private static void .cctor() { }
}

