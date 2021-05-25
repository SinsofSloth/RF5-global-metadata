public class DamageHpPercentChecker // TypeDefIndex: 7734
{
	// Fields
	private List<DamageHpPercentChecker.DamageHPPercentChecker> DamageHPPercentCheckerList; // 0x10
	private float RemoveTime; // 0x18
	private float HitHPPercent; // 0x1C
	private float MaxHP; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x169020 Offset: 0x169121 VA: 0x169020
	private bool <IsHit>k__BackingField; // 0x24

	// Properties
	public bool IsHit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2BD0 Offset: 0x1A2CD1 VA: 0x1A2BD0
	// RVA: 0x1CA9E60 Offset: 0x1CA9F61 VA: 0x1CA9E60
	public bool get_IsHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2BE0 Offset: 0x1A2CE1 VA: 0x1A2BE0
	// RVA: 0x1CA9E70 Offset: 0x1CA9F71 VA: 0x1CA9E70
	private void set_IsHit(bool value) { }

	// RVA: 0x1CA9E80 Offset: 0x1CA9F81 VA: 0x1CA9E80
	public void Setup(float removeTime, float hitHPPercent, float maxHP) { }

	// RVA: 0x1CA9F10 Offset: 0x1CAA011 VA: 0x1CA9F10
	public void Reset() { }

	// RVA: 0x1CA9F70 Offset: 0x1CAA071 VA: 0x1CA9F70
	public void Update() { }

	// RVA: 0x1CAA140 Offset: 0x1CAA241 VA: 0x1CAA140
	public void TakeDamage(int amount) { }

	// RVA: 0x1CAA270 Offset: 0x1CAA371 VA: 0x1CAA270
	public void .ctor() { }
}

