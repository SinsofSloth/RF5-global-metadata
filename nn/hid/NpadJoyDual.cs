public static class NpadJoyDual // TypeDefIndex: 11577
{
	// Methods

	// RVA: 0x26B2D30 Offset: 0x26B2E31 VA: 0x26B2D30
	public static extern void GetState(ref NpadJoyDualState pOutValue, NpadId npadId) { }

	// RVA: 0x26B1D20 Offset: 0x26B1E21 VA: 0x26B1D20
	public static extern void GetState(ref NpadState pOutValue, NpadId npadId) { }

	// RVA: 0x26B2D40 Offset: 0x26B2E41 VA: 0x26B2D40
	public static extern int GetStates([Out] NpadJoyDualState[] pOutValues, int count, NpadId npadId) { }

	// RVA: 0x26B22F0 Offset: 0x26B23F1 VA: 0x26B22F0
	public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId) { }
}

