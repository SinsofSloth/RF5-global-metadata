public class InvisibleMonsterController : MonsterControllerBase // TypeDefIndex: 7895
{
	// Fields
	private const float InvisibleVelocity = 0.1;
	private bool CanInvisible; // 0x500
	private SimpleHpBar _SimpleHpBar; // 0x508
	private BadStatusEffectController _BadStatusEffectController; // 0x510

	// Properties
	private SimpleHpBar SimpleHpBar { get; }
	private BadStatusEffectController BadStatusEffectController { get; }

	// Methods

	// RVA: 0x20CEF00 Offset: 0x20CF001 VA: 0x20CEF00
	private SimpleHpBar get_SimpleHpBar() { }

	// RVA: 0x20CEFB0 Offset: 0x20CF0B1 VA: 0x20CEFB0
	private BadStatusEffectController get_BadStatusEffectController() { }

	// RVA: 0x20CF060 Offset: 0x20CF161 VA: 0x20CF060 Slot: 111
	public override void SetStatusController(MonsterStatusBase statusController) { }

	// RVA: 0x20CF0C0 Offset: 0x20CF1C1 VA: 0x20CF0C0
	private void EndInvisible() { }

	// RVA: 0x20CF320 Offset: 0x20CF421 VA: 0x20CF320 Slot: 144
	protected override void OnStartClearFadeOut() { }

	// RVA: 0x20CF330 Offset: 0x20CF431 VA: 0x20CF330 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x20CF360 Offset: 0x20CF461 VA: 0x20CF360
	private bool IsInvisible() { }

	// RVA: 0x20CF510 Offset: 0x20CF611 VA: 0x20CF510
	private void UpdateInvisible() { }

	// RVA: 0x20CF810 Offset: 0x20CF911 VA: 0x20CF810 Slot: 40
	protected override void Update() { }

	// RVA: 0x20CF850 Offset: 0x20CF951 VA: 0x20CF850
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3EB0 Offset: 0x1A3FB1 VA: 0x1A3EB0
	// RVA: 0x20CF8C0 Offset: 0x20CF9C1 VA: 0x20CF8C0
	private void <UpdateInvisible>b__13_0() { }
}

