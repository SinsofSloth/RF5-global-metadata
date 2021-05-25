public class EscapeManager : SingletonMonoBehaviour<EscapeManager> // TypeDefIndex: 6710
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15EFA0 Offset: 0x15F0A1 VA: 0x15EFA0
	private bool <InitCompleted>k__BackingField; // 0x18
	private EscapeManager.State m_State; // 0x1C
	private Character m_chara; // 0x20

	// Properties
	public bool InitCompleted { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CA80 Offset: 0x19CB81 VA: 0x19CA80
	// RVA: 0x1C199B0 Offset: 0x1C19AB1 VA: 0x1C199B0
	public bool get_InitCompleted() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CA90 Offset: 0x19CB91 VA: 0x19CA90
	// RVA: 0x1C199C0 Offset: 0x1C19AC1 VA: 0x1C199C0
	private void set_InitCompleted(bool value) { }

	// RVA: 0x1C199D0 Offset: 0x1C19AD1 VA: 0x1C199D0
	public bool IsPlaying() { }

	// RVA: 0x1C199F0 Offset: 0x1C19AF1 VA: 0x1C199F0
	public void OnDestroy() { }

	// RVA: 0x1C19A00 Offset: 0x1C19B01 VA: 0x1C19A00
	public void Init() { }

	// RVA: 0x1C19A10 Offset: 0x1C19B11 VA: 0x1C19A10
	public bool DoStart(Character chara, string sceneName, WarpPoints.WarpPoint warpPoint) { }

	// RVA: 0x1C19C90 Offset: 0x1C19D91 VA: 0x1C19C90
	private void Update() { }

	// RVA: 0x1C19EB0 Offset: 0x1C19FB1 VA: 0x1C19EB0
	private void OnTeleport() { }

	// RVA: 0x1C19CC0 Offset: 0x1C19DC1 VA: 0x1C19CC0
	private void OnUpdateStartLanding() { }

	// RVA: 0x1C19DE0 Offset: 0x1C19EE1 VA: 0x1C19DE0
	private void OnUpdateEnd() { }

	// RVA: 0x1C19EF0 Offset: 0x1C19FF1 VA: 0x1C19EF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CAA0 Offset: 0x19CBA1 VA: 0x19CAA0
	// RVA: 0x1C19F40 Offset: 0x1C1A041 VA: 0x1C19F40
	private void <OnUpdateStartLanding>b__13_0() { }
}

