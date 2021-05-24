private sealed class Task.DelayPromise : Task<VoidTaskResult> // TypeDefIndex: 852
{
	// Fields
	internal readonly CancellationToken Token; // 0x58
	internal CancellationTokenRegistration Registration; // 0x60
	internal Timer Timer; // 0x78

	// Methods

	// RVA: 0x1584B50 Offset: 0x1584C51 VA: 0x1584B50
	internal void .ctor(CancellationToken token) { }

	// RVA: 0x1585490 Offset: 0x1585591 VA: 0x1585490
	internal void Complete() { }
}

