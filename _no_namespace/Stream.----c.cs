[CompilerGeneratedAttribute] // RVA: 0xAEA10 Offset: 0xAEB11 VA: 0xAEA10
[Serializable]
private sealed class Stream.<>c // TypeDefIndex: 662
{
	// Fields
	public static readonly Stream.<>c <>9; // 0x0
	public static Func<SemaphoreSlim> <>9__4_0; // 0x8
	public static Func<object, int> <>9__39_0; // 0x10
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__43_0; // 0x18
	public static Func<Stream, IAsyncResult, int> <>9__43_1; // 0x20
	public static Func<object, int> <>9__46_0; // 0x28
	public static Action<Task, object> <>9__47_0; // 0x30
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__53_0; // 0x38
	public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__53_1; // 0x40

	// Methods

	// RVA: 0x18B2350 Offset: 0x18B2451 VA: 0x18B2350
	private static void .cctor() { }

	// RVA: 0x18B23C0 Offset: 0x18B24C1 VA: 0x18B23C0
	public void .ctor() { }

	// RVA: 0x18B23D0 Offset: 0x18B24D1 VA: 0x18B23D0
	internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

	// RVA: 0x18B2440 Offset: 0x18B2541 VA: 0x18B2440
	internal int <BeginReadInternal>b__39_0(object <p0>) { }

	// RVA: 0x18B25D0 Offset: 0x18B26D1 VA: 0x18B25D0
	internal IAsyncResult <BeginEndReadAsync>b__43_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x18B2610 Offset: 0x18B2711 VA: 0x18B2610
	internal int <BeginEndReadAsync>b__43_1(Stream stream, IAsyncResult asyncResult) { }

	// RVA: 0x18B2640 Offset: 0x18B2741 VA: 0x18B2640
	internal int <BeginWriteInternal>b__46_0(object <p0>) { }

	// RVA: 0x18B2790 Offset: 0x18B2891 VA: 0x18B2790
	internal void <RunReadWriteTaskWhenReady>b__47_0(Task t, object state) { }

	// RVA: 0x18B2820 Offset: 0x18B2921 VA: 0x18B2820
	internal IAsyncResult <BeginEndWriteAsync>b__53_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x18B2860 Offset: 0x18B2961 VA: 0x18B2860
	internal VoidTaskResult <BeginEndWriteAsync>b__53_1(Stream stream, IAsyncResult asyncResult) { }
}

