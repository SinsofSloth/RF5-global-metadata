public class MocomocoController : MonsterControllerBase // TypeDefIndex: 7939
{
	// Fields
	private bool IsModelChanging; // 0x500

	// Methods

	// RVA: 0x1CC19A0 Offset: 0x1CC1AA1 VA: 0x1CC19A0 Slot: 153
	public override bool DoUseScissors(out float size) { }

	// RVA: 0x1CC1BE0 Offset: 0x1CC1CE1 VA: 0x1CC1BE0 Slot: 154
	public override bool CanUseScissors(HumanController character) { }

	// RVA: 0x1CC1B10 Offset: 0x1CC1C11 VA: 0x1CC1B10
	public bool CanCutWool() { }

	// RVA: 0x1CC1BD0 Offset: 0x1CC1CD1 VA: 0x1CC1BD0
	public void CutWool(bool isCreateItem = False, Action<bool> callBack) { }

	// RVA: 0x1CC20A0 Offset: 0x1CC21A1 VA: 0x1CC20A0
	public void GrowWool(Action<bool> callBack) { }

	// RVA: 0x1CC20B0 Offset: 0x1CC21B1 VA: 0x1CC20B0
	private void SpowanWoolItem() { }

	// RVA: 0x1CC1D00 Offset: 0x1CC1E01 VA: 0x1CC1D00
	private void ChangeModel(bool isWoolModel, bool isCreateItem = False, Action<bool> callBack) { }

	// RVA: 0x1CC24E0 Offset: 0x1CC25E1 VA: 0x1CC24E0
	private void CheckDamageWool(bool isDamage, ref DamageInfo damageInfo) { }

	// RVA: 0x1CC2560 Offset: 0x1CC2661 VA: 0x1CC2560 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1CC2630 Offset: 0x1CC2731 VA: 0x1CC2630
	public void .ctor() { }
}

