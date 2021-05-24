public static class NpadJoyRight // TypeDefIndex: 11581
{
	// Methods

	// RVA: 0x2C63190 Offset: 0x2C63291 VA: 0x2C63190
	public static extern void GetState(ref NpadJoyRightState pOutValue, NpadId npadId) { }

	// RVA: 0x2C631A0 Offset: 0x2C632A1 VA: 0x2C631A0
	public static extern void GetState(ref NpadState pOutValue, NpadId npadId) { }

	// RVA: 0x2C631B0 Offset: 0x2C632B1 VA: 0x2C631B0
	public static extern int GetStates([Out] NpadJoyRightState[] pOutValues, int count, NpadId npadId) { }

	// RVA: 0x2C632F0 Offset: 0x2C633F1 VA: 0x2C632F0
	public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId) { }
}

