public class ItemEquipEffectPlayer : MonoBehaviour // TypeDefIndex: 7655
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x168810 Offset: 0x168911 VA: 0x168810
	private ParticleSystem <Effect>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x168820 Offset: 0x168921 VA: 0x168820
	private bool <IsPlaying>k__BackingField; // 0x20
	private float m_scale; // 0x24

	// Properties
	public ParticleSystem Effect { get; set; }
	public bool IsPlaying { get; set; }
	public float Scale { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A23C0 Offset: 0x1A24C1 VA: 0x1A23C0
	// RVA: 0x20D32B0 Offset: 0x20D33B1 VA: 0x20D32B0
	public ParticleSystem get_Effect() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A23D0 Offset: 0x1A24D1 VA: 0x1A23D0
	// RVA: 0x20D32C0 Offset: 0x20D33C1 VA: 0x20D32C0
	private void set_Effect(ParticleSystem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A23E0 Offset: 0x1A24E1 VA: 0x1A23E0
	// RVA: 0x20D32D0 Offset: 0x20D33D1 VA: 0x20D32D0
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A23F0 Offset: 0x1A24F1 VA: 0x1A23F0
	// RVA: 0x20D32E0 Offset: 0x20D33E1 VA: 0x20D32E0
	private void set_IsPlaying(bool value) { }

	// RVA: 0x20D32F0 Offset: 0x20D33F1 VA: 0x20D32F0
	public float get_Scale() { }

	// RVA: 0x20D3300 Offset: 0x20D3401 VA: 0x20D3300
	public void set_Scale(float value) { }

	// RVA: 0x20D33B0 Offset: 0x20D34B1 VA: 0x20D33B0
	private void OnLoaded(ParticleSystem effect) { }

	// RVA: 0x20D35B0 Offset: 0x20D36B1 VA: 0x20D35B0
	public void Play(EffectID effectID, float scale = 1) { }

	// RVA: 0x20D36A0 Offset: 0x20D37A1 VA: 0x20D36A0
	public void Stop() { }

	// RVA: 0x20D3690 Offset: 0x20D3791 VA: 0x20D3690
	public void SetScale(float scale) { }

	// RVA: 0x20D3780 Offset: 0x20D3881 VA: 0x20D3780
	public void LerpScale(float scale, float t) { }

	// RVA: 0x20D3820 Offset: 0x20D3921 VA: 0x20D3820
	public void .ctor() { }
}

