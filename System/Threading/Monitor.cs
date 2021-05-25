[ComVisibleAttribute] // RVA: 0xAF2E0 Offset: 0xAF3E1 VA: 0xAF2E0
public static class Monitor // TypeDefIndex: 791
{
	// Methods

	// RVA: 0x1A116C0 Offset: 0x1A117C1 VA: 0x1A116C0
	public static void Enter(object obj) { }

	// RVA: 0x1A104C0 Offset: 0x1A105C1 VA: 0x1A104C0
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x1A116D0 Offset: 0x1A117D1 VA: 0x1A116D0
	private static void ThrowLockTakenException() { }

	[ReliabilityContractAttribute] // RVA: 0xB8B80 Offset: 0xB8C81 VA: 0xB8B80
	// RVA: 0x1A10570 Offset: 0x1A10671 VA: 0x1A10570
	public static void Exit(object obj) { }

	// RVA: 0x1A11800 Offset: 0x1A11901 VA: 0x1A11800
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x1A11310 Offset: 0x1A11411 VA: 0x1A11310
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x1A11970 Offset: 0x1A11A71 VA: 0x1A11970
	public static void Pulse(object obj) { }

	// RVA: 0x1A10800 Offset: 0x1A10901 VA: 0x1A10800
	public static void PulseAll(object obj) { }

	// RVA: 0x1A11B80 Offset: 0x1A11C81 VA: 0x1A11B80
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x1A11B90 Offset: 0x1A11C91 VA: 0x1A11B90
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x1A11A60 Offset: 0x1A11B61 VA: 0x1A11A60
	private static void ObjPulse(object obj) { }

	// RVA: 0x1A11BA0 Offset: 0x1A11CA1 VA: 0x1A11BA0
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x1A11AF0 Offset: 0x1A11BF1 VA: 0x1A11AF0
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x1A11BB0 Offset: 0x1A11CB1 VA: 0x1A11BB0
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x1A118A0 Offset: 0x1A119A1 VA: 0x1A118A0
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x1A11BC0 Offset: 0x1A11CC1 VA: 0x1A11BC0
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1A11BD0 Offset: 0x1A11CD1 VA: 0x1A11BD0
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x1A11760 Offset: 0x1A11861 VA: 0x1A11760
	private static void ReliableEnter(object obj, ref bool lockTaken) { }
}

