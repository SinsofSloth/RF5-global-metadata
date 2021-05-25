public class InstantStatus : StatusBase // TypeDefIndex: 8301
{
	// Fields
	private Parameter InstantParameter; // 0xF0
	private Alliance _Alliance; // 0x1AC
	[CompilerGeneratedAttribute] // RVA: 0x16EAF0 Offset: 0x16EBF1 VA: 0x16EAF0
	private int <Hp>k__BackingField; // 0x1B0

	// Properties
	public override Alliance Alliance { get; }
	public override int Hp { get; set; }

	// Methods

	// RVA: 0x20CBBE0 Offset: 0x20CBCE1 VA: 0x20CBBE0
	public void .ctor(Parameter parameter) { }

	// RVA: 0x20CBCC0 Offset: 0x20CBDC1 VA: 0x20CBCC0 Slot: 6
	public override Alliance get_Alliance() { }

	// RVA: 0x20CBCD0 Offset: 0x20CBDD1 VA: 0x20CBCD0
	public void SetAlliance(Alliance alliance) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6BC0 Offset: 0x1A6CC1 VA: 0x1A6BC0
	// RVA: 0x20CBCE0 Offset: 0x20CBDE1 VA: 0x20CBCE0 Slot: 8
	public override int get_Hp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6BD0 Offset: 0x1A6CD1 VA: 0x1A6BD0
	// RVA: 0x20CBCF0 Offset: 0x20CBDF1 VA: 0x20CBCF0 Slot: 9
	public override void set_Hp(int value) { }

	// RVA: 0x20CBD00 Offset: 0x20CBE01 VA: 0x20CBD00 Slot: 12
	public override ValueTuple<Parameter, EquipSubAttributeCollection> CalcCurrentParameter(HumanEquip humanEquip, bool isWeapon) { }
}

