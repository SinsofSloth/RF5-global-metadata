public class Stopwatch // TypeDefIndex: 1795
{
	// Fields
	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }
	public bool IsRunning { get; }

	// Methods

	// RVA: 0x28E9D40 Offset: 0x28E9E41 VA: 0x28E9D40
	public static long GetTimestamp() { }

	// RVA: 0x28E9D50 Offset: 0x28E9E51 VA: 0x28E9D50
	public static Stopwatch StartNew() { }

	// RVA: 0x28E9E10 Offset: 0x28E9F11 VA: 0x28E9E10
	public void .ctor() { }

	// RVA: 0x28E9EB0 Offset: 0x28E9FB1 VA: 0x28E9EB0
	public TimeSpan get_Elapsed() { }

	// RVA: 0x28EA0B0 Offset: 0x28EA1B1 VA: 0x28EA0B0
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x28EA020 Offset: 0x28EA121 VA: 0x28EA020
	public long get_ElapsedTicks() { }

	// RVA: 0x28EA230 Offset: 0x28EA331 VA: 0x28EA230
	public bool get_IsRunning() { }

	// RVA: 0x28EA240 Offset: 0x28EA341 VA: 0x28EA240
	public void Reset() { }

	// RVA: 0x28E9E20 Offset: 0x28E9F21 VA: 0x28E9E20
	public void Start() { }

	// RVA: 0x28EA250 Offset: 0x28EA351 VA: 0x28EA250
	public void Stop() { }

	// RVA: 0x28EA2E0 Offset: 0x28EA3E1 VA: 0x28EA2E0
	private static void .cctor() { }
}

