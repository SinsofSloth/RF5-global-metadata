public static class NpadJoyLeft // TypeDefIndex: 11579
{
	// Methods

	// RVA: 0x2C62CB0 Offset: 0x2C62DB1 VA: 0x2C62CB0
	public static extern void GetState(ref NpadJoyLeftState pOutValue, NpadId npadId) { }

	// RVA: 0x2C62CC0 Offset: 0x2C62DC1 VA: 0x2C62CC0
	public static extern void GetState(ref NpadState pOutValue, NpadId npadId) { }

	// RVA: 0x2C62CD0 Offset: 0x2C62DD1 VA: 0x2C62CD0
	public static extern int GetStates([Out] NpadJoyLeftState[] pOutValues, int count, NpadId npadId) { }

	// RVA: 0x2C62E10 Offset: 0x2C62F11 VA: 0x2C62E10
	public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId) { }
}

